using Library.Classes;
using Library.Classes.Dal_DatabaseOperation_;
using Library.Classes.SelectImage;
using Library.Classes.TableChecked;
using Library.Classes.TableClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Forms.BookForms
{
    public partial class AddBook : Form
    {
        private List<Panel> listPanel = new List<Panel>();
        private AuthorDal _authorDal = new AuthorDal();
        private PublisherDal _publisherDal = new PublisherDal();
        private BookDal _bookDal = new BookDal();
        private int index;
        public static int author_id;
        public static int publisher_id;
        public static int book_id;
        private int countAuthor;
        private int countPublisher;
        private string imageLocationString = "";
        private string imageLocation;
        private SelectImage selectImage = new SelectImage();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(conString);
        public string isbnNo;
        public static string isbnNoText;
        private bool tableChecked = false;
        private TableCheckFromDatabase tableCheckFromDatabase = new TableCheckFromDatabase();
        private DataTable tbl = new DataTable();
        private DataTable tblPublisher = new DataTable();
        private DataTable tblBook = new DataTable();
        private FormDesignControl formDesign = new FormDesignControl();

        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelYazar);
            listPanel.Add(panelYayinEvi);
            listPanel.Add(panelBook);
            listPanel[index].BringToFront();
            LoadAuthors();
            LoadPublishers();
            LoadBooks();
            formDesign.FormDesignSetControls(Controls, this);
            dtpYayinEvi.CustomFormat = "dd-MM-yyyy";
            dtpYearOfBirth.CustomFormat = "dd-MM-yyyy";
        }

        private void LoadAuthors()
        {
            dgwAuthor.DataSource = _authorDal.GetAll();
        }

        private void LoadPublishers()
        {
            dgwPublisher.DataSource = _publisherDal.GetAll();
        }

        private void LoadBooks()
        {
            dgwBook.DataSource = _bookDal.GetAll();
        }

        private void isbn_No_Checked()
        {
            try
            {
                connection.Open();
                string Isbn_No = txtAddISBN_NO.Text;
                string sorgu = String.Concat("SELECT * FROM BOOK WHERE ISBN_NO = '" + Isbn_No + "'");
                SqlCommand cmd = new SqlCommand(sorgu, connection);
                isbnNo = Convert.ToString(cmd.ExecuteScalar());
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (countAuthor == 0)
                {
                    if (txtYazarName.Text == "" || txtYazarSurname.Text == "" || cmbNationality.Text == "" || dtpYearOfBirth.Text == ""
                    || dtpYearOfBirth.Text == "" || imageLocation == "" || (rbMan.Checked == false && rbWoman.Checked == false))
                    {
                        MessageBox.Show("Boş bırakmayınız");
                    }
                    else
                    {
                        if (rbMan.Checked)
                        {
                            _authorDal.Add(new AUTHOR
                            {
                                NAME = txtYazarName.Text,
                                SURNAME = txtYazarSurname.Text,
                                NATIONALITY = cmbNationality.Text,
                                YEAR_OF_BIRTH = dtpYearOfBirth.Text,
                                GENDER = rbMan.Text,
                                IMAGE = imageLocation
                            });
                        }
                        else
                        {
                            _authorDal.Add(new AUTHOR
                            {
                                NAME = txtYazarName.Text,
                                SURNAME = txtYazarSurname.Text,
                                NATIONALITY = cmbNationality.Text,
                                YEAR_OF_BIRTH = dtpYearOfBirth.Text,
                                GENDER = rbWoman.Text,
                                IMAGE = imageLocation
                            });
                        }

                        MessageBox.Show($"{txtYazarName.Text} {txtYazarSurname.Text} Added");
                        SearchAuthor();
                    }
                }
                else
                {
                    MessageBox.Show("Bu kayıt zaten ekli");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (countPublisher == 0)
                {
                    if (txtYayinEviName.Text == "" || txtAddress.Text == "" || dtpYayinEvi.Text == "")
                    {
                        MessageBox.Show("Boş bırakmayınız");
                        btnPrev.Enabled = false;
                    }
                    else
                    {
                        _publisherDal.Add(new PUBLISHER
                        {
                            NAME = txtYayinEviName.Text,
                            ADDRESS = txtAddress.Text,
                            YEAR_OF_FOUNDATION = dtpYayinEvi.Text
                        });

                        MessageBox.Show($"{txtYayinEviName.Text} Added");
                        SearchPublisher();
                    }
                }
                else
                {
                    MessageBox.Show("Bu kayıt zaten ekli");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }

            if (index == 2)
            {
                btnNext.Visible = false;
                btnPrev.Visible = false;
                btnGo.Visible = true;

                if (txtYayinEviName.Text == "" || txtAddress.Text == "" || dtpYayinEvi.Text == "" ||
                   txtYazarName.Text == "" || txtYazarSurname.Text == "" || cmbNationality.Text == "" ||
                   dtpYearOfBirth.Text == "" || (rbMan.Checked == false && rbWoman.Checked == false))
                {
                    MessageBox.Show("Boş bırakmayınız");
                }
                else
                {
                    txtAddAuthorId.Text = txtYazarName.Text;
                    txtAddPublisherId.Text = txtYayinEviName.Text;
                    btnGo.Enabled = true;
                }


            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
        }

        private void dgwYazar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                author_id = Convert.ToInt32(dgwAuthor.CurrentRow.Cells[0].Value.ToString());
                txtYazarName.Text = dgwAuthor.CurrentRow.Cells[1].Value.ToString();
                txtYazarSurname.Text = dgwAuthor.CurrentRow.Cells[2].Value.ToString();
                cmbNationality.Text = dgwAuthor.CurrentRow.Cells[3].Value.ToString();
                dtpYearOfBirth.Text = dgwAuthor.CurrentRow.Cells[4].Value.ToString();
                if (dgwAuthor.CurrentRow.Cells[5].Value.ToString() == "Man")
                {
                    rbMan.Checked = true;
                }
                else
                {
                    rbWoman.Checked = true;
                }
                ptxAddAuthor.Image = Image.FromFile(dgwAuthor.CurrentRow.Cells[6].Value.ToString());
                btnAddAuthor.Enabled = false;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }


        public void SearchAuthor()
        {
            tbl.Clear();
            try
            {
                string sql = "SELECT * FROM AUTHOR";
                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();
                        if (!string.IsNullOrEmpty(txtYazarName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtYazarName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtYazarSurname.Text))
                        {
                            clauses.Add("SURNAME like @SURNAME");
                            cmd.Parameters.Add("@SURNAME", SqlDbType.NVarChar).Value =
                                txtYazarSurname.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbNationality.Text))
                        {
                            clauses.Add("NATIONALITY like @NATIONALITY");
                            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar).Value =
                                cmbNationality.Text.Trim() + "%";
                        }

                        if (rbMan.Checked)
                        {
                            clauses.Add("GENDER like @GENDERMAN");
                            cmd.Parameters.Add("@GENDERMAN", SqlDbType.NVarChar).Value =
                                rbMan.Text.Trim() + "%";
                        }

                        if (rbWoman.Checked)
                        {
                            clauses.Add("GENDER like @GENDERWOMAN");
                            cmd.Parameters.Add("@GENDERWOMAN", SqlDbType.NVarChar).Value =
                                rbWoman.Text.Trim() + "%";
                        }

                        if (clauses.Count > 0)
                        {
                            sql += " where " + string.Join(" and ", clauses);
                        }

                        cmd.Connection = con;
                        cmd.CommandText = sql;
                        con.Open();

                        tbl.Load(cmd.ExecuteReader());
                        con.Close();


                        dgwAuthor.DataSource = tbl;
                        countAuthor = dgwAuthor.Rows.Count - 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void SearchPublisher()
        {
            tblPublisher.Clear();
            try
            {
                string sql = "SELECT * FROM PUBLISHER";
                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtYayinEviName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtYayinEviName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtAddress.Text))
                        {
                            clauses.Add("ADDRESS like @ADDRESS");
                            cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar).Value =
                                txtAddress.Text.Trim() + "%";
                        }

                        if (clauses.Count > 0)
                        {
                            sql += " where " + string.Join(" and ", clauses);
                        }

                        cmd.Connection = con;
                        cmd.CommandText = sql;
                        con.Open();

                        tblPublisher.Load(cmd.ExecuteReader());
                        con.Close();


                        dgwPublisher.DataSource = tblPublisher;
                        countPublisher = dgwPublisher.Rows.Count - 1;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SearchBook()
        {
            tblBook.Clear();
            try
            {
                string sql = "SELECT * FROM BOOK";
                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtAddISBN_NO.Text))
                        {
                            clauses.Add("ISBN_NO like @ISBN_NO");
                            cmd.Parameters.Add("@ISBN_NO", SqlDbType.NVarChar).Value =
                                txtAddISBN_NO.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtAddBookName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtAddBookName.Text.Trim() + "%";
                        }
                        if (!string.IsNullOrEmpty(txtAddPageNumber.Text))
                        {
                            clauses.Add("PageNUMBER like @PAGENUMBER");
                            cmd.Parameters.Add("@PAGENUMBER", SqlDbType.NVarChar).Value =
                                txtAddPageNumber.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbAddLanguage.Text))
                        {
                            clauses.Add("LANGUAGE like @LANGUAGE");
                            cmd.Parameters.Add("@LANGUAGE", SqlDbType.NVarChar).Value =
                                cmbAddLanguage.Text.Trim() + "%";
                        }

                        if (clauses.Count > 0)
                        {
                            sql += " where " + string.Join(" and ", clauses);
                        }

                        cmd.Connection = con;
                        cmd.CommandText = sql;
                        con.Open();

                        tblBook.Load(cmd.ExecuteReader());
                        con.Close();


                        dgwBook.DataSource = tblBook;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtYazarName_TextChanged(object sender, EventArgs e)
        {
            SearchAuthor();
        }

        private void txtYazarSurname_TextChanged(object sender, EventArgs e)
        {
            SearchAuthor();
        }

        private void cmbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAuthor();
        }

        private void rbMan_CheckedChanged(object sender, EventArgs e)
        {
            SearchAuthor();
        }

        private void rbWoman_CheckedChanged(object sender, EventArgs e)
        {
            SearchAuthor();
        }

        private void txtYayinEviName_TextChanged(object sender, EventArgs e)
        {
            SearchPublisher();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            SearchPublisher();
        }

        private void dgwPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            publisher_id = Convert.ToInt32(dgwAuthor.CurrentRow.Cells[0].Value.ToString());
            txtYayinEviName.Text = dgwPublisher.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgwPublisher.CurrentRow.Cells[2].Value.ToString();
            dtpYayinEvi.Text = dgwPublisher.CurrentRow.Cells[3].Value.ToString();
            btnYayinEviEkle.Enabled = false;
            btnNext.Enabled = true;
        }

        private void ptxAddAuthor_Click(object sender, EventArgs e)
        {
            imageLocation = selectImage.GetImage(ptxAddAuthor, imageLocationString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tableChecked = tableCheckFromDatabase.IsTableExisting("BOOK");
                if (tableChecked)
                {
                    isbn_No_Checked();
                }

                if (isbnNo == "")
                {
                    if (txtAddISBN_NO.Text == "" && txtAddBookName.Text == "" && txtAddPageNumber.Text == "" && cmbAddLanguage.Text == "")
                    {
                        MessageBox.Show("Boş bırakmayınız");
                    }
                    else
                    {
                        _bookDal.Add(new BOOK
                        {
                            ISBN_NO = txtAddISBN_NO.Text,
                            NAME = txtAddBookName.Text,
                            PageNUMBER = txtAddPageNumber.Text,
                            LANGUAGE = cmbAddLanguage.Text,
                            AUTHOR_ID = author_id,
                            PUBLISHER_ID = publisher_id
                        });
                    }

                    MessageBox.Show($"{txtAddBookName.Text} was added ");
                    txtAddISBN_NO.Clear();
                    txtAddBookName.Clear();
                    txtAddPageNumber.Clear();
                    cmbAddLanguage.SelectedIndex = -1;
                }

                else
                {
                    MessageBox.Show($"{txtAddBookName.Text} zaten ekli ");
                    txtAddISBN_NO.Clear();
                    txtAddBookName.Clear();
                    txtAddPageNumber.Clear();
                    cmbAddLanguage.SelectedIndex = -1;

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.InnerException.ToString(), exception.StackTrace);
            }

        }

        private void dgwBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                book_id = Convert.ToInt32(dgwBook.CurrentRow.Cells[0].Value.ToString());
                txtAddISBN_NO.Text = dgwBook.CurrentRow.Cells[1].Value.ToString();
                txtAddBookName.Text = dgwBook.CurrentRow.Cells[2].Value.ToString();
                txtAddPageNumber.Text = dgwBook.CurrentRow.Cells[3].Value.ToString();
                cmbAddLanguage.Text = dgwBook.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.StackTrace);
            }

        }

        private void txtAddISBN_NO_TextChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

        private void txtAddBookName_TextChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

        private void txtAddPageNumber_TextChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

        private void cmbAddLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBook();
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            isbnNoText = txtAddISBN_NO.Text;
            BookInformation bookInformation = new BookInformation();
            bookInformation.Show();
        }
    }
}
