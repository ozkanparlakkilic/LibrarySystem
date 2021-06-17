using Library.Classes;
using Library.Classes.ClearClass;
using Library.Classes.Dal_DatabaseOperation_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class DeleteBook : Form
    {
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private BookDal _bookDal = new BookDal();
        private ClearTxtAndCmb clear = new ClearTxtAndCmb();
        DataTable tbl = new DataTable();
        private FormDesignControl formDesign = new FormDesignControl();
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void dgwRemoveBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRemoveISBN_NO.Text = dgwRemoveBook.CurrentRow.Cells[1].Value.ToString();
            txtRemoveBookName.Text = dgwRemoveBook.CurrentRow.Cells[2].Value.ToString();
            txtRemovePageNumber.Text = dgwRemoveBook.CurrentRow.Cells[3].Value.ToString();
            cmbRemoveLanguage.Text = dgwRemoveBook.CurrentRow.Cells[4].Value.ToString();
            txtRemoveAuthorId.Text = dgwRemoveBook.CurrentRow.Cells[5].Value.ToString();
            txtRemovePublisherId.Text = dgwRemoveBook.CurrentRow.Cells[6].Value.ToString();
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

                        if (!string.IsNullOrEmpty(txtRemoveISBN_NO.Text))
                        {
                            clauses.Add("ISBN_NO LIKE @ISBN_NO");
                            cmd.Parameters.Add("@ISBN_NO", SqlDbType.NVarChar).Value =
                                txtRemoveISBN_NO.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtRemoveBookName.Text))
                        {
                            clauses.Add("NAME LIKE @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtRemoveBookName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtRemovePageNumber.Text))
                        {
                            clauses.Add("PageNUMBER LIKE @PageNUMBER");
                            cmd.Parameters.Add("@PageNUMBER", SqlDbType.NVarChar).Value =
                                txtRemovePageNumber.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbRemoveLanguage.Text))
                        {
                            clauses.Add("LANGUAGE LIKE @LANGUAGE");
                            cmd.Parameters.Add("@LANGUAGE", SqlDbType.NVarChar).Value =
                                cmbRemoveLanguage.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtRemoveAuthorId.Text))
                        {
                            clauses.Add("AUTHOR_ID LIKE @AUTHOR_ID");
                            cmd.Parameters.Add("@AUTHOR_ID", SqlDbType.NVarChar).Value =
                                txtRemoveAuthorId.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtRemovePublisherId.Text))
                        {
                            clauses.Add("PUBLISHER_ID LIKE @PUBLISHER_ID");
                            cmd.Parameters.Add("@PUBLISHER_ID", SqlDbType.NVarChar).Value =
                                txtRemovePublisherId.Text.Trim() + "%";
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


                        dgwRemoveBook.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtRemoveISBN_NO_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtRemoveBookName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtRemovePageNumber_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbRemoveLANGUAGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtRemoveAuthorId_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtRemovePublisherId_TextChanged(object sender, EventArgs e)
        {
            Search();
        }


        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secenek = MessageBox.Show($"Are you sure you want to delete {txtRemoveBookName.Text} ?"
                               , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (secenek == DialogResult.Yes)
                {
                    _bookDal.Delete(new BOOK
                    {
                        ID = Convert.ToInt32(dgwRemoveBook.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show($"{txtRemoveBookName.Text} was deleted ");
                    LoadBook();

                    clear.ClearAllText(this);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            LoadBook();
            formDesign.FormDesignSetControls(Controls, this);
        }
        private void LoadBook()
        {
            dgwRemoveBook.DataSource = _bookDal.GetAll();
        }
    }
}
