using Library.Classes;
using Library.Classes.Dal_DatabaseOperation_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class SearchPublisher : Form
    {
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private PublisherDal _publisherDal = new PublisherDal();
        DataTable tbl = new DataTable();
        private FormDesignControl formDesign = new FormDesignControl();
        public SearchPublisher()
        {
            InitializeComponent();
        }
        private void LoadPublisher()
        {
            dgwSearchPublisher.DataSource = _publisherDal.GetAll();
        }
        private void SearchPublisher_Load(object sender, EventArgs e)
        {
            LoadPublisher();
            formDesign.FormDesignSetControls(Controls, this);
        }

        public void Search()
        {
            tbl.Clear();
            try
            {
                string sql = "SELECT * FROM PUBLISHER";
                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtSearchPusblisherId.Text))
                        {
                            clauses.Add("ID like @ID");
                            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value =
                                txtSearchPusblisherId.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchPublisherName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtSearchPublisherName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchAddress.Text))
                        {
                            clauses.Add("ADDRESS like @ADDRESS");
                            cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar).Value =
                                txtSearchAddress.Text.Trim() + "%";
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


                        dgwSearchPublisher.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtSearchPusblisherId_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchPublisherName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchAddress_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

    }
}
