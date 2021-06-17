using Library.Classes;
using Library.Classes.Dal_DatabaseOperation_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class SearchBook : Form
    {
        private BookDal _bookDal = new BookDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        DataTable tbl = new DataTable();
        private FormDesignControl formDesign = new FormDesignControl();
        public SearchBook()
        {
            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            LoadBook();
            formDesign.FormDesignSetControls(Controls, this);
        }
        private void LoadBook()
        {
            dgwSearchBook.DataSource = _bookDal.GetAll();
        }

        public void Search()
        {
            tbl.Clear();
            try
            {
                string sql = "SELECT * FROM BOOK";
                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtSearchISBN_NO.Text))
                        {
                            clauses.Add("ISBN_NO LIKE @ISBN_NO");
                            cmd.Parameters.Add("@ISBN_NO", SqlDbType.NVarChar).Value =
                                txtSearchISBN_NO.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchBookName.Text))
                        {
                            clauses.Add("NAME LIKE @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtSearchBookName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchPageNumber.Text))
                        {
                            clauses.Add("PageNUMBER LIKE @PageNUMBER");
                            cmd.Parameters.Add("@PageNUMBER", SqlDbType.NVarChar).Value =
                                txtSearchPageNumber.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbSearchLanguage.Text))
                        {
                            clauses.Add("LANGUAGE LIKE @LANGUAGE");
                            cmd.Parameters.Add("@LANGUAGE", SqlDbType.NVarChar).Value =
                                cmbSearchLanguage.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchAuthorId.Text))
                        {
                            clauses.Add("AUTHOR_ID LIKE @AUTHOR_ID");
                            cmd.Parameters.Add("@AUTHOR_ID", SqlDbType.NVarChar).Value =
                                txtSearchAuthorId.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtSearchPublisherId.Text))
                        {
                            clauses.Add("PUBLISHER_ID LIKE @PUBLISHER_ID");
                            cmd.Parameters.Add("@PUBLISHER_ID", SqlDbType.NVarChar).Value =
                                txtSearchPublisherId.Text.Trim() + "%";
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


                        dgwSearchBook.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void txtSearchISBN_NO_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchBookName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchPageNumber_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbSearchLANGUAGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchAuthorId_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchPublisherId_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
