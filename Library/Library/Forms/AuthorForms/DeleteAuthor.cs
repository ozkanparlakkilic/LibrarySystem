using Library.Classes;
using Library.Classes.ClearClass;
using Library.Classes.Dal_DatabaseOperation_;
using Library.Classes.SelectImage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class DeleteAuthor : Form
    {
        private AuthorDal _authotDal = new AuthorDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        DataTable tbl = new DataTable();
        private ClearTxtAndCmb clear = new ClearTxtAndCmb();
        private SqlConnection connection = new SqlConnection(conString);
        private BookDal _bookDal = new BookDal();
        private string imageLocationString = "";
        private string imageLocation;
        private SelectImage selectImage = new SelectImage();
        private FormDesignControl formDesign = new FormDesignControl();

        public DeleteAuthor()
        {
            InitializeComponent();
        }
        private void LoadAuthor()
        {
            dgwDeleteAuthor.DataSource = _authotDal.GetAll();
        }
        private void DeleteAuthor_Load(object sender, EventArgs e)
        {
            LoadAuthor();
            formDesign.FormDesignSetControls(Controls, this);
            dtpDeleteAuthorYearOfBirth.CustomFormat = "dd-MM-yyyy";
        }

        private void dgwDeleteAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeleteAuthorName.Text = dgwDeleteAuthor.CurrentRow.Cells[1].Value.ToString();
            txtDeleteAuthorSurname.Text = dgwDeleteAuthor.CurrentRow.Cells[2].Value.ToString();
            cmbDeleteNationality.Text = dgwDeleteAuthor.CurrentRow.Cells[3].Value.ToString();
            dtpDeleteAuthorYearOfBirth.Text = dgwDeleteAuthor.CurrentRow.Cells[4].Value.ToString();
            if (rbDeleteAuthorMan.Text == dgwDeleteAuthor.CurrentRow.Cells[5].Value.ToString())
            {
                rbDeleteAuthorMan.Checked = true;
            }
            else
            {
                rbDeleteAuthorWoman.Checked = true;
            }

            ptxDeleteAuthor.Image = Image.FromFile(dgwDeleteAuthor.CurrentRow.Cells[6].Value.ToString());
        }
        public void Search()
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

                        if (!string.IsNullOrEmpty(txtDeleteAuthorName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtDeleteAuthorName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtDeleteAuthorSurname.Text))
                        {
                            clauses.Add("SURNAME like @SURNAME");
                            cmd.Parameters.Add("@SURNAME", SqlDbType.NVarChar).Value =
                                txtDeleteAuthorSurname.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbDeleteNationality.Text))
                        {
                            clauses.Add("NATIONALITY like @NATIONALITY");
                            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar).Value =
                                cmbDeleteNationality.Text.Trim() + "%";
                        }

                        if (rbDeleteAuthorMan.Checked)
                        {
                            clauses.Add("GENDER like @GENDERMAN");
                            cmd.Parameters.Add("@GENDERMAN", SqlDbType.NVarChar).Value =
                                rbDeleteAuthorMan.Text.Trim() + "%";
                        }

                        if (rbDeleteAuthorWoman.Checked)
                        {
                            clauses.Add("GENDER like @GENDERWOMAN");
                            cmd.Parameters.Add("@GENDERWOMAN", SqlDbType.NVarChar).Value =
                                rbDeleteAuthorWoman.Text.Trim() + "%";
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


                        dgwDeleteAuthor.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtDeleteAuthorName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtDeleteAuthorSurname_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbDeleteNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbDeleteAuthorMan_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbDeleteAuthorWoman_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }



        private void btmDeleteAuthor_Click(object sender, EventArgs e)
        {
            int id;
            string sorgu;
            SqlCommand cmd;
            try
            {
                connection.Open();
                sorgu = String.Concat("SELECT * FROM AUTHOR WHERE ID = '" + Convert.ToInt32(dgwDeleteAuthor.CurrentRow.Cells[0].Value) + "'");
                cmd = new SqlCommand(sorgu, connection);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                DialogResult secenek = MessageBox.Show($"Are you sure you want to delete {txtDeleteAuthorName.Text} " +
                                                       $"{txtDeleteAuthorSurname.Text} ?"
                    , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);


                if (secenek == DialogResult.Yes)
                {
                    if (id == 0)
                    {
                        _authotDal.Delete(new AUTHOR
                        {
                            ID = Convert.ToInt32(dgwDeleteAuthor.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show($"{txtDeleteAuthorName.Text} {txtDeleteAuthorSurname.Text} was deleted ");
                        LoadAuthor();

                        clear.ClearAllText(this);
                    }
                    else
                    {
                        MessageBox.Show("Bu yazar silinemez kullanıldığı kayıt var");
                        clear.ClearAllText(this);
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ptxDeleteAuthor_Click(object sender, EventArgs e)
        {
            imageLocation = selectImage.GetImage(ptxDeleteAuthor, imageLocationString);
        }
    }
}
