using Library.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Forms.RaporForm
{
    public partial class RaporForm : Form
    {
        private string conString =
            "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private FormDesignControl formDesignControl = new FormDesignControl();
        private string sorgu;

        public RaporForm()
        {
            InitializeComponent();
        }

        private void DataGridViewQueryList(string sorgu)
        {
            var select = sorgu;
            var c = new SqlConnection(conString);
            var dataAdapter = new SqlDataAdapter(@select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgwRapor.ReadOnly = true;
            dgwRapor.DataSource = ds.Tables[0];
        }

        private void btnMonthlyTopBooksRead_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT DISTINCT(B.NAME),COUNT(B.NAME) AS [COUNT] FROM LOAN L INNER JOIN BOOK B ON L.BOOK_ID = B.ID 
                        WHERE DATEDIFF(DAY, CONVERT(DATE, L.RECEIVED_DATE,103),CONVERT(DATE, GETDATE(), 103)) <= 30
                        GROUP BY B.NAME ORDER BY COUNT(B.NAME) DESC";
            DataGridViewQueryList(sorgu);
        }


        private void btnWeeklyTopBooksRead_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT DISTINCT(B.NAME),COUNT(B.NAME) AS [COUNT] FROM LOAN L INNER JOIN BOOK B ON L.BOOK_ID = B.ID 
                        WHERE DATEDIFF(DAY, CONVERT(DATE, L.RECEIVED_DATE,103),CONVERT(DATE, GETDATE(), 103)) <= 7
                        GROUP BY B.NAME ORDER BY COUNT(B.NAME) DESC";
            DataGridViewQueryList(sorgu);
        }

        private void btnMonthlyTheMostPunished_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT DISTINCT(M.USERNAME),M.MEMBER_NAME,COUNT(M.MEMBER_NAME) AS COUNT_PUNISH FROM PUNISHMENT P 
                INNER JOIN LOAN L ON P.LOAN_ID = L.ID 
                INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID 
                WHERE DATEDIFF(DAY,CONVERT(DATE,L.RECEIVED_DATE,103),CONVERT(DATE,GETDATE(),103)) - 20 <= 30
                GROUP BY M.USERNAME,M.MEMBER_NAME ORDER BY COUNT(M.MEMBER_NAME) DESC";
            DataGridViewQueryList(sorgu);
        }

        private void btnWeeklyTheMostPunished_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT DISTINCT(M.USERNAME),M.MEMBER_NAME,COUNT(M.MEMBER_NAME) AS COUNT_PUNISH FROM PUNISHMENT P 
                INNER JOIN LOAN L ON P.LOAN_ID = L.ID 
                INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID 
                WHERE DATEDIFF(DAY,CONVERT(DATE,L.RECEIVED_DATE,103),CONVERT(DATE,GETDATE(),103)) - 20 <= 7
                GROUP BY M.USERNAME,M.MEMBER_NAME ORDER BY COUNT(M.MEMBER_NAME) DESC";
            DataGridViewQueryList(sorgu);
        }

        private void btnMonthlyThoseWhoDontPayPenalties_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT DISTINCT(M.USERNAME),M.MEMBER_NAME,COUNT(M.MEMBER_NAME) AS COUNT_PUNISH FROM PUNISHMENT P 
                        INNER JOIN LOAN L ON P.LOAN_ID = L.ID 
                        INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID 
                        WHERE (INVOICE = 'False') AND (DATEDIFF(DAY,CONVERT(DATE,L.RECEIVED_DATE,103),CONVERT(DATE,GETDATE(),103)) - 20 <= 30)
                        GROUP BY M.USERNAME,M.MEMBER_NAME ORDER BY COUNT(M.MEMBER_NAME) DESC";
            DataGridViewQueryList(sorgu);
        }

        private void btnWeeklyThoseWhoDontPayPenalties_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT DISTINCT(M.USERNAME),M.MEMBER_NAME,COUNT(M.MEMBER_NAME) AS COUNT_PUNISH FROM PUNISHMENT P 
                        INNER JOIN LOAN L ON P.LOAN_ID = L.ID 
                        INNER JOIN MEMBER M ON L.MEMBER_ID = M.ID 
                        WHERE (INVOICE = 'False') AND (DATEDIFF(DAY,CONVERT(DATE,L.RECEIVED_DATE,103),CONVERT(DATE,GETDATE(),103)) - 20 <= 7)
                        GROUP BY M.USERNAME,M.MEMBER_NAME ORDER BY COUNT(M.MEMBER_NAME) DESC";
            DataGridViewQueryList(sorgu);
        }

        private void btnMonthlyBooksOutOfStock_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT DISTINCT(B.NAME),COUNT(B.NAME) AS [COUNT] FROM STOCK_RAPOR SP INNER JOIN MEMBER M ON SP.MEMBER_ID = M.ID
                                 INNER JOIN BOOK B ON SP.BOOK_ID = B.ID
                                 WHERE DATEDIFF(DAY,CONVERT(DATE,SP.REQUEST_DATE,103),CONVERT(DATE,GETDATE(),103)) <= 30
                                 GROUP BY B.NAME ORDER BY COUNT(B.NAME) DESC";
            DataGridViewQueryList(sorgu);
        }

        private void btnWeeklyBooksOutOfStock_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT DISTINCT(B.NAME),COUNT(B.NAME) AS [COUNT] FROM STOCK_RAPOR SP INNER JOIN MEMBER M ON SP.MEMBER_ID = M.ID
                                 INNER JOIN BOOK B ON SP.BOOK_ID = B.ID
                                 WHERE DATEDIFF(DAY,CONVERT(DATE,SP.REQUEST_DATE,103),CONVERT(DATE,GETDATE(),103)) <= 7
                                 GROUP BY B.NAME ORDER BY COUNT(B.NAME) DESC";
            DataGridViewQueryList(sorgu);
        }

        private void btnVipAccount_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT M.MEMBER_NAME,M.USERNAME,MI.RANK,MI.STATUS FROM MEMBER_INFORMATION MI 
                        INNER JOIN MEMBER M ON M.ID = MI.MEMBER_ID WHERE RANK = 'VIP'";
            DataGridViewQueryList(sorgu);
        }

        private void btnBlockedAccount_Click(object sender, EventArgs e)
        {
            sorgu = @"SELECT M.MEMBER_NAME,M.USERNAME,MI.RANK,MI.STATUS FROM MEMBER_INFORMATION MI 
                        INNER JOIN MEMBER M ON M.ID = MI.MEMBER_ID WHERE STATUS = 'PASSIVE'";
            DataGridViewQueryList(sorgu);
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            formDesignControl.FormDesignSetControls(Controls, this);
            dgwRapor.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 240, 15);
        }
    }
}
