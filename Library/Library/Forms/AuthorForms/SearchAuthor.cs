using Library.Classes;
using Library.Classes.Dal_DatabaseOperation_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Forms
{

    public partial class SearchAuthor : Form
    {
        private AuthorDal _authorDal = new AuthorDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        DataTable tbl = new DataTable();
        private FormDesignControl formDesign = new FormDesignControl();
        public SearchAuthor()
        {
            InitializeComponent();
        }
        private void LoadAuthor()
        {
            dgwSearchAuthor.DataSource = _authorDal.GetAll();
        }
        private void SearchAuthor_Load(object sender, EventArgs e)
        {
            LoadAuthor();
            formDesign.FormDesignSetControls(Controls, this);
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

                        if (!string.IsNullOrEmpty(txtSearchAuthorId.Text))
                        {
                            clauses.Add("ID like @ID");
                            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value =
                                txtSearchAuthorId.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchAuthorName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtSearchAuthorName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchAuthorSurname.Text))
                        {
                            clauses.Add("SURNAME like @SURNAME");
                            cmd.Parameters.Add("@SURNAME", SqlDbType.NVarChar).Value =
                                txtSearchAuthorSurname.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbNationality.Text))
                        {
                            clauses.Add("NATIONALITY like @NATIONALITY");
                            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar).Value =
                                cmbNationality.Text.Trim() + "%";
                        }

                        if (rbSearchAuthorMan.Checked)
                        {
                            clauses.Add("GENDER like @GENDERMAN");
                            cmd.Parameters.Add("@GENDERMAN", SqlDbType.NVarChar).Value =
                                rbSearchAuthorMan.Text.Trim() + "%";
                        }

                        if (rbSearchAuthorWoman.Checked)
                        {
                            clauses.Add("GENDER like @GENDERWOMAN");
                            cmd.Parameters.Add("@GENDERWOMAN", SqlDbType.NVarChar).Value =
                                rbSearchAuthorWoman.Text.Trim() + "%";
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


                        dgwSearchAuthor.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtSearchAuthorId_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchAuthorName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchAuthorSurname_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbSearchAuthorMan_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbSearchAuthorWoman_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

    }
}
