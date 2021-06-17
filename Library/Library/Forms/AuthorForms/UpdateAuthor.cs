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
    public partial class UpdateAuthor : Form
    {
        private AuthorDal _authorDal = new AuthorDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        DataTable tbl = new DataTable();
        private ClearTxtAndCmb clear = new ClearTxtAndCmb();
        private int id;
        private string imageLocationString = "";
        private string imageLocation;
        private SelectImage selectImage = new SelectImage();
        private FormDesignControl formDesign = new FormDesignControl();
        public UpdateAuthor()
        {
            InitializeComponent();
        }
        private void LoadAuthor()
        {
            dgwUpdateAuthor.DataSource = _authorDal.GetAll();
        }

        private void UpdateAuthor_Load(object sender, EventArgs e)
        {
            LoadAuthor();
            formDesign.FormDesignSetControls(Controls, this);
            dtpUpdateAuthorYearOfBirth.CustomFormat = "dd-MM-yyyy";
        }

        private void dgwUpdateAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgwUpdateAuthor.CurrentRow.Cells[0].Value);
            txtUpdateAuthorName.Text = dgwUpdateAuthor.CurrentRow.Cells[1].Value.ToString();
            txtUpdateAuthorSurname.Text = dgwUpdateAuthor.CurrentRow.Cells[2].Value.ToString();
            cmbUpdateNationality.Text = dgwUpdateAuthor.CurrentRow.Cells[3].Value.ToString();
            dtpUpdateAuthorYearOfBirth.Text = dgwUpdateAuthor.CurrentRow.Cells[4].Value.ToString();
            if (rbUpdateAuthorMan.Text == dgwUpdateAuthor.CurrentRow.Cells[5].Value.ToString())
            {
                rbUpdateAuthorMan.Checked = true;
            }
            else
            {
                rbUpdateAuthorWoman.Checked = true;
            }
            ptxUpdateAuthor.Image = Image.FromFile(dgwUpdateAuthor.CurrentRow.Cells[6].Value.ToString());
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

                        if (!string.IsNullOrEmpty(txtUpdateAuthorName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtUpdateAuthorName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUpdateAuthorSurname.Text))
                        {
                            clauses.Add("SURNAME like @SURNAME");
                            cmd.Parameters.Add("@SURNAME", SqlDbType.NVarChar).Value =
                                txtUpdateAuthorSurname.Text.Trim() + "%";
                        }


                        if (!string.IsNullOrEmpty(cmbUpdateNationality.Text))
                        {
                            clauses.Add("NATIONALITY like @NATIONALITY");
                            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar).Value =
                                cmbUpdateNationality.Text.Trim() + "%";
                        }

                        if (rbUpdateAuthorMan.Checked)
                        {
                            clauses.Add("GENDER like @GENDERMAN");
                            cmd.Parameters.Add("@GENDERMAN", SqlDbType.NVarChar).Value =
                                rbUpdateAuthorMan.Text.Trim() + "%";
                        }

                        if (rbUpdateAuthorWoman.Checked)
                        {
                            clauses.Add("GENDER like @GENDERWOMAN");
                            cmd.Parameters.Add("@GENDERWOMAN", SqlDbType.NVarChar).Value =
                                rbUpdateAuthorWoman.Text.Trim() + "%";
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


                        dgwUpdateAuthor.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtUpdateAuthorName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtUpdateAuthorSurname_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbUpdateNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbUpdateAuthorMan_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbUpdateAuthorWoman_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btmUpdateAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secenek = MessageBox.Show($"Are you sure you want to update {txtUpdateAuthorName.Text} " +
                                                       $"{txtUpdateAuthorSurname.Text} ?"
                    , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (secenek == DialogResult.Yes)
                {
                    if (rbUpdateAuthorMan.Checked)
                    {
                        _authorDal.Update(new AUTHOR
                        {
                            ID = id,
                            NAME = txtUpdateAuthorName.Text,
                            SURNAME = txtUpdateAuthorSurname.Text,
                            NATIONALITY = cmbUpdateNationality.Text,
                            GENDER = rbUpdateAuthorMan.Text,
                            YEAR_OF_BIRTH = dtpUpdateAuthorYearOfBirth.Text,
                            IMAGE = imageLocation
                        });
                    }
                    else
                    {
                        _authorDal.Update(new AUTHOR
                        {
                            ID = id,
                            NAME = txtUpdateAuthorName.Text,
                            SURNAME = txtUpdateAuthorSurname.Text,
                            NATIONALITY = cmbUpdateNationality.Text,
                            GENDER = rbUpdateAuthorWoman.Text,
                            YEAR_OF_BIRTH = dtpUpdateAuthorYearOfBirth.Text,
                            IMAGE = imageLocation
                        });
                    }

                    MessageBox.Show($"{txtUpdateAuthorName.Text} {txtUpdateAuthorSurname.Text} was updated ");
                    LoadAuthor();

                    clear.ClearAllText(this);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ptxUpdateAuthor_Click(object sender, EventArgs e)
        {
            imageLocation = selectImage.GetImage(ptxUpdateAuthor, imageLocationString);
        }
    }
}
