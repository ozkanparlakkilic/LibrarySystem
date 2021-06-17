using Library.Classes;
using Library.Classes.Dal_DatabaseOperation_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class SearchPersonel : Form
    {
        private PersonelDal _personelDal = new PersonelDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        DataTable tbl = new DataTable();
        private FormDesignControl formDesign = new FormDesignControl();
        public SearchPersonel()
        {
            InitializeComponent();
        }
        private void LoadPersonel()
        {
            dgwSearchPersonel.DataSource = _personelDal.GetAll();
        }
        private void SearchPersonel_Load(object sender, EventArgs e)
        {
            LoadPersonel();
            formDesign.FormDesignSetControls(Controls, this);
        }

        public void Search()
        {
            tbl.Clear();
            try
            {
                string sql = "SELECT * FROM PERSONEL";
                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtSearchPersonelName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtSearchPersonelName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchPersonelSurname.Text))
                        {
                            clauses.Add("SURNAME like @SURNAME");
                            cmd.Parameters.Add("@SURNAME", SqlDbType.NVarChar).Value =
                                txtSearchPersonelSurname.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchPersonelSurname.Text))
                        {
                            clauses.Add("EMAIL like @EMAIL");
                            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value =
                                txtSearchPersonelEmail.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbSearchPersonelNationality.Text))
                        {
                            clauses.Add("NATIONALITY like @NATIONALITY");
                            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar).Value =
                                cmbSearchPersonelNationality.Text.Trim() + "%";
                        }

                        if (rbSearchPersonelMan.Checked)
                        {
                            clauses.Add("GENDER like @GENDERMAN");
                            cmd.Parameters.Add("@GENDERMAN", SqlDbType.NVarChar).Value =
                                rbSearchPersonelMan.Text.Trim() + "%";
                        }

                        if (rbSearchPersonelWoman.Checked)
                        {
                            clauses.Add("GENDER like @GENDERWOMAN");
                            cmd.Parameters.Add("@GENDERWOMAN", SqlDbType.NVarChar).Value =
                                rbSearchPersonelWoman.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbSearchPosition.Text))
                        {
                            clauses.Add("POSITION like @POSITION");
                            cmd.Parameters.Add("@POSITION", SqlDbType.NVarChar).Value =
                                cmbSearchPosition.Text.Trim() + "%";
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


                        dgwSearchPersonel.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtSearchPersonelName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchPersonelSurname_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbSearchPersonelNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbSearchPersonelMan_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbSearchPersonelWoman_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbSearchPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchPersonelEmail_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
