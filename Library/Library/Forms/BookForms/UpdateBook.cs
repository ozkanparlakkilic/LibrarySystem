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
    public partial class UpdateBook : Form
    {
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private BookDal _bookDal = new BookDal();
        private int id;
        private ClearTxtAndCmb clear = new ClearTxtAndCmb();
        DataTable tbl = new DataTable();
        private FormDesignControl formDesign = new FormDesignControl();
        public UpdateBook()
        {
            InitializeComponent();
        }
        private void LoadBook()
        {
            dgwUpdateBook.DataSource = _bookDal.GetAll();
        }
        private void UpdateBook_Load(object sender, System.EventArgs e)
        {
            LoadBook();
            formDesign.FormDesignSetControls(Controls, this);
        }

        private void dgwUpdateBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgwUpdateBook.CurrentRow.Cells[0].Value);
            txtUpdateISBN_NO.Text = dgwUpdateBook.CurrentRow.Cells[1].Value.ToString();
            txtUpdateBookName.Text = dgwUpdateBook.CurrentRow.Cells[2].Value.ToString();
            txtUpdatePageNumber.Text = dgwUpdateBook.CurrentRow.Cells[3].Value.ToString();
            cmbUpdateLanguage.Text = dgwUpdateBook.CurrentRow.Cells[4].Value.ToString();
            txtUpdateAuthorId.Text = dgwUpdateBook.CurrentRow.Cells[5].Value.ToString();
            txtUpdatePublisherId.Text = dgwUpdateBook.CurrentRow.Cells[6].Value.ToString();
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

                        if (!string.IsNullOrEmpty(txtUpdateISBN_NO.Text))
                        {
                            clauses.Add("ISBN_NO LIKE @ISBN_NO");
                            cmd.Parameters.Add("@ISBN_NO", SqlDbType.NVarChar).Value =
                                txtUpdateISBN_NO.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUpdateBookName.Text))
                        {
                            clauses.Add("NAME LIKE @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtUpdateBookName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUpdatePageNumber.Text))
                        {
                            clauses.Add("PageNUMBER LIKE @PageNUMBER");
                            cmd.Parameters.Add("@PageNUMBER", SqlDbType.NVarChar).Value =
                                txtUpdatePageNumber.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbUpdateLanguage.Text))
                        {
                            clauses.Add("LANGUAGE LIKE @LANGUAGE");
                            cmd.Parameters.Add("@LANGUAGE", SqlDbType.NVarChar).Value =
                                cmbUpdateLanguage.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUpdateAuthorId.Text))
                        {
                            clauses.Add("AUTHOR_ID LIKE @AUTHOR_ID");
                            cmd.Parameters.Add("@AUTHOR_ID", SqlDbType.NVarChar).Value =
                                txtUpdateAuthorId.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUpdatePublisherId.Text))
                        {
                            clauses.Add("PUBLISHER_ID LIKE @PUBLISHER_ID");
                            cmd.Parameters.Add("@PUBLISHER_ID", SqlDbType.NVarChar).Value =
                                txtUpdatePublisherId.Text.Trim() + "%";
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


                        dgwUpdateBook.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtUpdateISBN_NO_TextChanged(object sender, System.EventArgs e)
        {
            Search();
        }

        private void txtUpdateBookName_TextChanged(object sender, System.EventArgs e)
        {
            Search();
        }

        private void txtUpdatePageNumber_TextChanged(object sender, System.EventArgs e)
        {
            Search();
        }

        private void cmbUpdateLANGUAGE_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Search();
        }

        private void txtUpdateAuthorId_TextChanged(object sender, System.EventArgs e)
        {
            Search();
        }

        private void txtUpdatePublisherId_TextChanged(object sender, System.EventArgs e)
        {
            Search();
        }

        private void btnUpdateBook_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult secenek = MessageBox.Show($"Are you sure you want to update {txtUpdateBookName.Text}?"
                                , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (secenek == DialogResult.Yes)
                {
                    _bookDal.Update(new BOOK
                    {
                        ID = id,
                        ISBN_NO = txtUpdateISBN_NO.Text,
                        NAME = txtUpdateBookName.Text,
                        PageNUMBER = txtUpdatePageNumber.Text,
                        LANGUAGE = cmbUpdateLanguage.Text,
                        AUTHOR_ID = Convert.ToInt32(txtUpdateAuthorId.Text),
                        PUBLISHER_ID = Convert.ToInt32(txtUpdatePublisherId.Text)
                    });

                    MessageBox.Show($"{txtUpdateBookName.Text} was updated ");
                    LoadBook();

                    clear.ClearAllText(this);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
