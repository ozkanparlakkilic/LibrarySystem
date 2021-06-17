using Library.Classes;
using Library.Classes.Dal_DatabaseOperation_;
using Library.Classes.SelectImage;
using Library.Classes.TableChecked;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class AddAuthor : Form
    {
        private AuthorDal _authorDal = new AuthorDal();

        private static string conString =
            "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";

        private SqlConnection connection = new SqlConnection(conString);
        public SqlDataReader Reader;
        private int count;
        private string imageLocationString = "";
        private string imageLocation;
        private bool tableChecked = false;
        private SelectImage selectImage = new SelectImage();
        private TableCheckFromDatabase tableCheckFromDatabase = new TableCheckFromDatabase();
        private FormDesignControl formDesign = new FormDesignControl();


        public AddAuthor()
        {
            InitializeComponent();
        }

        private void authorChecked()
        {
            try
            {
                connection.Open();
                string sorgu = String.Concat("SELECT * FROM AUTHOR WHERE NAME = @NAME AND SURNAME = @SURNAME AND  NATIONALITY = @NATIONALITY " +
                                             "AND GENDER = @GENDER AND YEAR_OF_BIRTH = @YEAR_OF_BIRTH AND IMAGE = @IMAGE");
                SqlCommand cmd = new SqlCommand(sorgu, connection);
                cmd.Parameters.AddWithValue("@NAME", txtYazarName.Text);
                cmd.Parameters.AddWithValue("@SURNAME", txtYazarSurname.Text);
                cmd.Parameters.AddWithValue("@NATIONALITY", cmbNationality.Text);
                cmd.Parameters.AddWithValue("@YEAR_OF_BIRTH", dtpYearOfBirth.Text);

                if (rbMan.Checked)
                {
                    cmd.Parameters.AddWithValue("@GENDER", rbMan.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GENDER", rbWoman.Text);
                }

                cmd.Parameters.AddWithValue("@IMAGE", imageLocation);
                Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                Reader.Close();
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
                if (txtYazarName.Text == "" || txtYazarSurname.Text == "" || cmbNationality.Text == "" ||
                    dtpYearOfBirth.Text == "" || imageLocation == "" || (rbMan.Checked == false && rbWoman.Checked == false))
                {
                    MessageBox.Show("Boş bırakmayınız");
                }
                else
                {
                    if (rbMan.Checked)
                    {
                        tableChecked = tableCheckFromDatabase.IsTableExisting("AUTHOR");


                        if (tableChecked)
                        {
                            authorChecked();
                        }

                        if (count == 0)
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
                            MessageBox.Show("Added");
                        }
                        else
                        {
                            MessageBox.Show("Bu yazar zaten mevcut");
                        }

                    }
                    else
                    {
                        if (tableChecked)
                        {
                            authorChecked();
                        }
                        if (count == 0)
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
                            MessageBox.Show("Added");
                        }
                        else
                        {
                            MessageBox.Show("Bu yazar zaten mevcut");
                        }

                    }

                    count = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }


        private void ptxAddAuthor_Click(object sender, EventArgs e)
        {
            imageLocation = selectImage.GetImage(ptxAddAuthor, imageLocationString);
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {
            formDesign.FormDesignSetControls(Controls, this);
            dtpYearOfBirth.CustomFormat = "dd-MM-yyyy";
        }
    }
}
