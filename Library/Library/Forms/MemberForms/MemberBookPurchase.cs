using Library.Classes;
using Library.Classes.Dal_DatabaseOperation;
using Library.Classes.TableClasses;
using Library.Forms.LoginAndRegistration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class MemberBookPurchase : Form
    {
        private string conString =
            "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private BookInformationDal _bookInformationDal = new BookInformationDal();
        private LoanDal _loanDal = new LoanDal();
        private StockRaporDal _stockRaporDal = new StockRaporDal();
        private DataTable tbl = new DataTable();
        private SqlDataReader reader;
        private string username;
        private SqlCommand cmd;
        private FormDesignControl formDesignControl = new FormDesignControl();

        public MemberBookPurchase()
        {
            InitializeComponent();
        }

        private void MemberBookPurchase_Load(object sender, EventArgs e)
        {
            var select = "SELECT B.ISBN_NO,B.NAME,BI.LIBRARY_NAME,BI.BOOK_SHELF FROM BOOK_INFORMATION BI " +
                         "INNER JOIN BOOK B ON BI.BOOK_ID = B.ID";
            var c = new SqlConnection(conString);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgwMemberPurchase.ReadOnly = true;
            dgwMemberPurchase.DataSource = ds.Tables[0];

            formDesignControl.FormDesignSetControls(Controls, this);
        }


        private void dgwMemberPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIsbnNo.Text = dgwMemberPurchase.CurrentRow.Cells[0].Value.ToString();
            txtBookName.Text = dgwMemberPurchase.CurrentRow.Cells[1].Value.ToString();
            cmbLibraryName.Text = dgwMemberPurchase.CurrentRow.Cells[2].Value.ToString();
            txtShelfNo.Text = dgwMemberPurchase.CurrentRow.Cells[3].Value.ToString();
        }

        public void Search()
        {
            tbl.Clear();
            try
            {
                string sql = "SELECT B.ISBN_NO,B.NAME,BI.LIBRARY_NAME,BI.BOOK_SHELF FROM BOOK_INFORMATION BI " +
                             "INNER JOIN BOOK B ON BI.BOOK_ID = B.ID";

                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtIsbnNo.Text))
                        {
                            clauses.Add("B.ISBN_NO like @ISBN_NO");
                            cmd.Parameters.Add("@ISBN_NO", SqlDbType.NVarChar).Value =
                                txtIsbnNo.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtBookName.Text))
                        {
                            clauses.Add("B.NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtBookName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbLibraryName.Text))
                        {
                            clauses.Add("BI.LIBRARY_NAME like @LIBRARY_NAME");
                            cmd.Parameters.Add("@LIBRARY_NAME", SqlDbType.NVarChar).Value =
                                cmbLibraryName.Text.Trim() + "%";
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

                        dgwMemberPurchase.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void txtIsbnNo_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbLibraryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnBookPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                username = Login.userName;
                int usernameCheck;
                int bookInformationId;
                int bookId;
                int memberId;
                int bookAmount;


                DialogResult secenek = MessageBox.Show($"Are you sure you want to take {txtBookName.Text}?"
                                , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string sorgu = String.Concat(@"SELECT count(*)FROM LOAN L
                                                    INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID
                                                    WHERE L.THE_BOOK_IS_BACK = 'False' AND M.USERNAME = @Username");
                    cmd = new SqlCommand(sorgu, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    usernameCheck = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu2 = String.Concat(@"SELECT M.ID FROM MEMBER M
                                                 WHERE USERNAME = @Username");

                    cmd = new SqlCommand(sorgu2, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    memberId = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu3 = String.Concat(@"SELECT ID FROM BOOK WHERE ISBN_NO = @ISBN_NO");
                    cmd = new SqlCommand(sorgu3, connection);
                    cmd.Parameters.AddWithValue("@ISBN_NO", txtIsbnNo.Text);
                    bookId = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu4 = String.Concat(@"SELECT AMOUNT FROM BOOK_INFORMATION 
                                                WHERE BOOK_ID = @BookId");
                    cmd = new SqlCommand(sorgu4, connection);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    bookAmount = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu5 = String.Concat(@"SELECT ID FROM BOOK_INFORMATION WHERE BOOK_ID = @BookId");
                    cmd = new SqlCommand(sorgu5, connection);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    bookInformationId = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();

                }

                if (secenek == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();

                        string sorguControl = String.Concat(@"SELECT M.USERNAME AS NAME ,B.ISBN_NO,B.NAME AS [BOOK NAME],
                                                L.RECEIVED_DATE,L.THE_BOOK_IS_BACK FROM LOAN L 
                                                INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID
                                                INNER JOIN BOOK B ON L.BOOK_ID = B.ID 
                                                WHERE M.USERNAME = @Username AND L.THE_BOOK_IS_BACK = 'False' AND B.ISBN_NO = @IsbnNo");
                        cmd = new SqlCommand(sorguControl, con);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@IsbnNo", txtIsbnNo.Text);
                        reader = cmd.ExecuteReader();

                        if (usernameCheck == 3)
                        {
                            MessageBox.Show("Aldığınız kitapları iade etmeden daha fazla kitap alamazsınız");
                            reader.Close();
                        }
                        else
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Bu kitabı zaten aldınız");
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();

                                if (bookAmount == 0)
                                {
                                    MessageBox.Show("İstediğiniz kitaptan stokta kalmamıştır. Sonra tekrar geliniz");
                                    _stockRaporDal.Add(new STOCK_RAPOR
                                    {
                                        BOOK_ID = bookId,
                                        MEMBER_ID = memberId,
                                        REQUEST_DATE = DateTime.Today.ToString("dd-MM-yyyy")
                                    });

                                    MessageBox.Show("Stock Raporuna Eklendi");

                                }
                                else
                                {
                                    _loanDal.Add(new LOAN
                                    {
                                        BOOK_ID = bookId,
                                        MEMBER_ID = memberId,
                                        RECEIVED_DATE = DateTime.Today.ToString("dd-MM-yyyy"),
                                        THE_BOOK_IS_BACK = "False"
                                    });

                                    _bookInformationDal.Update(new BOOK_INFORMATION
                                    {
                                        ID = bookInformationId,
                                        BOOK_ID = bookId,
                                        LIBRARY_NAME = cmbLibraryName.Text,
                                        BOOK_SHELF = txtShelfNo.Text,
                                        AMOUNT = Convert.ToInt32(bookAmount - 1)
                                    });

                                    MessageBox.Show("İşlem Başarılı");
                                }
                            }
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.InnerException.ToString());
            }

            txtBookName.Clear();
            txtIsbnNo.Clear();
            cmbLibraryName.SelectedIndex = -1;
            txtShelfNo.Clear();
        }
    }
}
