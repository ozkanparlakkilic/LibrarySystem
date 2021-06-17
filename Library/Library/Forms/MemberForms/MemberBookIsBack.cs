using Library.Classes;
using Library.Classes.Dal_DatabaseOperation;
using Library.Classes.TableClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class MemberBookIsBack : Form
    {
        private string conString =
            "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";

        private LoanDal _loanDal = new LoanDal();
        private BookInformationDal _bookInformationDal = new BookInformationDal();
        private PunishmentDal _punishmentDal = new PunishmentDal();
        private DataTable tbl = new DataTable();
        private SqlDataReader reader;
        private SqlCommand cmd;
        private FormDesignControl formDesignControl = new FormDesignControl();

        public MemberBookIsBack()
        {
            InitializeComponent();
        }

        private void MemberBookIsBack_Load(object sender, EventArgs e)
        {
            formDesignControl.FormDesignSetControls(Controls, this);
            LoadMemberIsBackBookList();
        }

        private void LoadMemberIsBackBookList()
        {
            var select = @"SELECT B.NAME,M.USERNAME,L.RECEIVED_DATE,L.THE_BOOK_IS_BACK
                                FROM LOAN L
                                INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID
                                INNER JOIN BOOK B ON L.BOOK_ID = B.ID WHERE THE_BOOK_IS_BACK = 'False'";
            var c = new SqlConnection(conString);
            var dataAdapter = new SqlDataAdapter(@select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgwBookIsBack.ReadOnly = true;
            dgwBookIsBack.DataSource = ds.Tables[0];

            formDesignControl.FormDesignSetControls(Controls, this);
        }

        private void dgwBookIsBack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookName.TextChanged -= new EventHandler(txtBookName_TextChanged);
            txtUserName.TextChanged -= new EventHandler(txtUserName_TextChanged);

            txtBookName.Text = dgwBookIsBack.CurrentRow.Cells[0].Value.ToString();
            txtUserName.Text = dgwBookIsBack.CurrentRow.Cells[1].Value.ToString();
        }

        public void Search()
        {
            tbl.Clear();
            try
            {
                string sql = @"SELECT B.NAME,M.USERNAME,L.RECEIVED_DATE,L.THE_BOOK_IS_BACK
                                FROM LOAN L
                                INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID
                                INNER JOIN BOOK B ON L.BOOK_ID = B.ID  WHERE THE_BOOK_IS_BACK = 'False' AND ";

                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtBookName.Text))
                        {
                            clauses.Add("B.NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtBookName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUserName.Text))
                        {
                            clauses.Add("M.USERNAME like @USERNAME");
                            cmd.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value =
                                txtUserName.Text.Trim() + "%";
                        }

                        if (clauses.Count > 0)
                        {
                            sql += string.Join(" and ", clauses);
                        }

                        cmd.Connection = con;
                        cmd.CommandText = sql;
                        con.Open();

                        tbl.Load(cmd.ExecuteReader());
                        con.Close();

                        dgwBookIsBack.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnUpdateBookIsBackStatus_Click(object sender, EventArgs e)
        {
            int bookId;
            int memberId;
            int loanId;
            int punishmentId;
            int delayedDay;
            float kdv = 0.18f;
            float penaltyAmount = 1;
            string receivedDate;
            string libraryName;
            string bookShelf;
            int bookInformationId;
            int bookAmount;

            DialogResult secenek = MessageBox.Show($"{txtUserName.Text} adlı kullanıcının bilgilerini " +
                                                   $"güncellemeyi Onaylıyor musunuz?"
                , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string sorgu1 = String.Concat(@"SELECT ID FROM MEMBER 
                                                WHERE USERNAME = @Username");
                    cmd = new SqlCommand(sorgu1, connection);
                    cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                    memberId = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu2 = String.Concat(@"SELECT ID FROM BOOK WHERE NAME = @NAME");
                    cmd = new SqlCommand(sorgu2, connection);
                    cmd.Parameters.AddWithValue("@NAME", txtBookName.Text);
                    bookId = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu3 = String.Concat(@"SELECT L.RECEIVED_DATE
                                                   FROM LOAN L 
                                                   INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID
                                                   INNER JOIN BOOK B ON L.BOOK_ID = B.ID 
                                                   WHERE B.NAME = @NAME AND M.USERNAME = @Username AND THE_BOOK_IS_BACK = 'False'");
                    cmd = new SqlCommand(sorgu3, connection);
                    cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@NAME", txtBookName.Text);
                    receivedDate = Convert.ToString(cmd.ExecuteScalar());

                    string sorgu4 = String.Concat(@"SELECT L.ID
                                                   FROM LOAN L 
                                                   INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID
                                                   INNER JOIN BOOK B ON L.BOOK_ID = B.ID 
                                                   WHERE B.NAME = @NAME AND M.USERNAME = @Username AND THE_BOOK_IS_BACK = 'False'");
                    cmd = new SqlCommand(sorgu4, connection);
                    cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@NAME", txtBookName.Text);
                    loanId = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu5 = String.Concat(@"SELECT P.ID
                                                   FROM PUNISHMENT P
                                                   INNER JOIN LOAN L ON P.LOAN_ID = L.ID
                                                   WHERE L.ID = @LOAN_ID");

                    cmd = new SqlCommand(sorgu5, connection);
                    cmd.Parameters.AddWithValue("@LOAN_ID", loanId);
                    punishmentId = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu6 = String.Concat(@"SELECT P.DELAYED_DAY
                                                   FROM PUNISHMENT P
                                                   INNER JOIN LOAN L ON P.LOAN_ID = L.ID
                                                   WHERE L.ID = @LOAN_ID");

                    cmd = new SqlCommand(sorgu6, connection);
                    cmd.Parameters.AddWithValue("@LOAN_ID", loanId);
                    delayedDay = Convert.ToInt32(cmd.ExecuteScalar());


                    string sorgu7 = String.Concat(@"SELECT BI.ID
                                                FROM BOOK_INFORMATION BI WHERE BI.BOOK_ID = @BOOK_ID");

                    cmd = new SqlCommand(sorgu7, connection);
                    cmd.Parameters.AddWithValue("@BOOK_ID", bookId);
                    bookInformationId = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu8 = String.Concat(@"SELECT BI.LIBRARY_NAME
                                                FROM BOOK_INFORMATION BI WHERE BI.BOOK_ID = @BOOK_ID");

                    cmd = new SqlCommand(sorgu8, connection);
                    cmd.Parameters.AddWithValue("@BOOK_ID", bookId);
                    libraryName = Convert.ToString(cmd.ExecuteScalar());

                    string sorgu9 = String.Concat(@"SELECT BI.BOOK_SHELF
                                                FROM BOOK_INFORMATION BI WHERE BI.BOOK_ID = @BOOK_ID");

                    cmd = new SqlCommand(sorgu9, connection);
                    cmd.Parameters.AddWithValue("@BOOK_ID", bookId);
                    bookShelf = Convert.ToString(cmd.ExecuteScalar());

                    string sorgu10 = String.Concat(@"SELECT BI.AMOUNT
                                                FROM BOOK_INFORMATION BI WHERE BI.BOOK_ID = @BOOK_ID");

                    cmd = new SqlCommand(sorgu10, connection);
                    cmd.Parameters.AddWithValue("@BOOK_ID", bookId);
                    bookAmount = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();
                }


                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    if (secenek == DialogResult.Yes)
                    {

                        _loanDal.Update(new LOAN
                        {
                            ID = loanId,
                            BOOK_ID = bookId,
                            MEMBER_ID = memberId,
                            RECEIVED_DATE = receivedDate,
                            THE_BOOK_IS_BACK = "True"
                        });


                        _bookInformationDal.Update(new BOOK_INFORMATION
                        {
                            ID = bookInformationId,
                            BOOK_ID = bookId,
                            LIBRARY_NAME = libraryName,
                            BOOK_SHELF = bookShelf,
                            AMOUNT = Convert.ToInt32(bookAmount + 1)
                        });

                        if (delayedDay != 0)
                        {
                            _punishmentDal.Update(new PUNISHMENT
                            {
                                ID = punishmentId,
                                LOAN_ID = loanId,
                                KDV_TUTARI = kdv,
                                PENALTY_AMOUNT = penaltyAmount,
                                DELAYED_DAY = delayedDay,
                                TODAY = DateTime.Today.ToString("dd-MM-yyyy"),
                                TOTAL_AMOUNT = (delayedDay * penaltyAmount) + (delayedDay * penaltyAmount * kdv),
                                INVOICE = true
                            });
                        }

                        MessageBox.Show("Güncellendi");

                    }
                    else
                    {
                        txtBookName.Clear();
                        txtUserName.Clear();
                    }


                    LoadMemberIsBackBookList();
                    txtBookName.TextChanged += new EventHandler(txtBookName_TextChanged);
                    txtUserName.TextChanged += new EventHandler(txtUserName_TextChanged);

                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.StackTrace);
            }

        }
    }
}
