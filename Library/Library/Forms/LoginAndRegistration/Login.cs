using Library.Classes.HashPassword;
using Library.Classes.LoginCheck;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Forms.LoginAndRegistration
{

    public partial class Login : Form
    {
        private static string conString =
            "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private static bool check;
        private HashPassword hashPassword = new HashPassword();
        private string username;
        public static string userName;

        private SqlCommand cmd;
        private int checkTableData;
        public Login()
        {
            InitializeComponent();
            Init_Data();
        }

        public void updateGetdate()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string date;
                    connection.Open();

                    string sorgu = @"SELECT CASE WHEN OBJECT_ID('dbo.PUNISHMENT', 'U') IS NOT NULL THEN 1 ELSE 0 END";
                    cmd = new SqlCommand(sorgu, connection);
                    checkTableData = Convert.ToInt32(cmd.ExecuteScalar());

                    if (checkTableData != 0)
                    {
                        string sorguControl2 = @"SELECT TOP(1) TODAY FROM PUNISHMENT";
                        cmd = new SqlCommand(sorguControl2, connection);
                        date = Convert.ToString(cmd.ExecuteScalar());

                        if (date != DateTime.Today.ToString("dd-MM-yyyy"))
                        {
                            CezaAndStatusAndRankControl(connection);
                            //MessageBox.Show("Control");
                        }
                        //else
                        //{
                        //    MessageBox.Show("Zaten güncel");
                        //}

                    }


                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void CezaAndStatusAndRankControl(SqlConnection connection)
        {
            try
            {
                string sorgu = @"UPDATE PUNISHMENT
                                    SET TODAY = FORMAT(CONVERT(date,GETDATE(),103),'dd-MM-yyyy')";
                cmd = new SqlCommand(sorgu, connection);
                cmd.ExecuteNonQuery();

                string sorgu1 =
                    @"DECLARE @id INT, @Day VARCHAR(50),@KdvTutari REAL,@PenaltyAmount REAL,@TotalAmount REAL,@DataCheck INT
                        DECLARE DefaultCursor CURSOR
                        FOR
                         SELECT L.ID,DATEDIFF(DAY,CONVERT(DATE,L.RECEIVED_DATE,103),CONVERT(DATE,GETDATE(),103)) - 20 AS [DELAYED DAY] FROM LOAN L 
                          WHERE DATEDIFF(DAY,CONVERT(DATE,L.RECEIVED_DATE,103),CONVERT(DATE,GETDATE(),103)) - 20 > 0 AND L.THE_BOOK_IS_BACK = 'False'

                        OPEN DefaultCursor
                        SET @KdvTutari = 0.18
                        SET @PenaltyAmount = 1

                        FETCH NEXT  FROM DefaultCursor  INTO @id,@Day 
                        WHILE @@FETCH_STATUS = 0
                        BEGIN
                         SET @DataCheck = (SELECT COUNT(LOAN_ID) FROM PUNISHMENT WHERE LOAN_ID = @id) 
                         IF(@DataCheck = 0)
                             BEGIN
                                SET @TotalAmount = ((@PenaltyAmount * @Day) + (@KdvTutari * @PenaltyAmount * @Day))
                                INSERT INTO PUNISHMENT VALUES(@id,@KdvTutari,@PenaltyAmount,@Day,FORMAT(CONVERT(DATE,GETDATE(),103),'dd-MM-yyyy'),@TotalAmount,'False')
                             END
                         FETCH NEXT  FROM DefaultCursor  INTO @id,@Day
                        END
                        CLOSE DefaultCursor
                        DEALLOCATE DefaultCursor";
                cmd = new SqlCommand(sorgu1, connection);
                cmd.ExecuteNonQuery();

                string sorgu2 =
                    @"DECLARE @id INT,@DataCheck INT
                        DECLARE memberStatusCursor CURSOR
                        FOR
                                    SELECT DISTINCT(L.MEMBER_ID) FROM LOAN L
                                    WHERE L.THE_BOOK_IS_BACK = 'False'
                                    
                        OPEN memberStatusCursor
                        FETCH NEXT  FROM memberStatusCursor  INTO @id 
                        WHILE @@FETCH_STATUS = 0
                        BEGIN
                         SET @DataCheck = (SELECT COUNT(L.MEMBER_ID) FROM PUNISHMENT P INNER JOIN LOAN L
                                            ON P.LOAN_ID = L.ID WHERE L.MEMBER_ID = @id) 
                         IF(@DataCheck >= 5)
                             BEGIN
                                --PRINT @DataCheck
                                UPDATE MEMBER_INFORMATION 
                                    SET STATUS = 'PASSIVE'
                                    FROM MEMBER_INFORMATION WHERE MEMBER_ID = @id
                             END
                         FETCH NEXT  FROM memberStatusCursor  INTO @id
                        END
                        CLOSE memberStatusCursor
                        DEALLOCATE memberStatusCursor";
                cmd = new SqlCommand(sorgu2, connection);
                cmd.ExecuteNonQuery();

                string sorgu3 =
                    @"DECLARE @id INT,@DataCheck INT,@CezaCheck INT
                        DECLARE memberRankCursor CURSOR
                        FOR
                                    SELECT DISTINCT(L.MEMBER_ID) FROM LOAN L

                        OPEN memberRankCursor
                        FETCH NEXT  FROM memberRankCursor  INTO @id 
                        WHILE @@FETCH_STATUS = 0
                        BEGIN
                         SET @DataCheck = (SELECT Count(L.MEMBER_ID) FROM LOAN L
                                                WHERE L.MEMBER_ID = @id AND L.THE_BOOK_IS_BACK = 'True')
                         SET @CezaCheck = (SELECT Count(L.MEMBER_ID) FROM PUNISHMENT P  INNER JOIN LOAN L 
                                                                    ON P.LOAN_ID = L.ID WHERE L.MEMBER_ID = @id)                        
                         IF(@DataCheck >= 5 AND @CezaCheck < 3)
                             BEGIN
                                UPDATE MEMBER_INFORMATION 
                                    SET RANK = 'VIP'
                                    FROM MEMBER_INFORMATION WHERE MEMBER_ID = @id
                             END
                         FETCH NEXT  FROM memberRankCursor  INTO @id
                        END
                        CLOSE memberRankCursor
                        DEALLOCATE memberRankCursor";
                cmd = new SqlCommand(sorgu3, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void iconBtnClearFields_Click(object sender, System.EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnLogIn_Click(object sender, System.EventArgs e)
        {
            username = txtUserName.Text;
            string password = hashPassword.hashPasswordText(txtPassword);
            Save_Data();
            updateGetdate();
            UserLogin control = new UserLogin();
            control.girisYap(username, password, this);
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void linkLblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            forgetPasswordForm.Show();
            this.Hide();
        }

        private void iconExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Init_Data()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                if (Properties.Settings.Default.Remember)
                {
                    txtUserName.Text = Properties.Settings.Default.UserName;
                    txtPassword.Text = Properties.Settings.Default.Password;
                    chkRemember.Checked = true;
                }
                else
                {
                    txtUserName.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private void Save_Data()
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtMemberPassword.PasswordChar = '*';
        }

        private void ıconBtnPersonelLogin_Click(object sender, EventArgs e)
        {
            panelPersonelLogin.Visible = false;
            panelMemberLogin.Visible = true;
        }

        private void ıconBtnMemberLogin_Click(object sender, EventArgs e)
        {
            panelPersonelLogin.Visible = true;
            panelMemberLogin.Visible = false;
        }

        private void btnMemberRegister_Click(object sender, EventArgs e)
        {
            MemberRegistration registration = new MemberRegistration();
            registration.Show();
            this.Hide();
        }

        private void btnMemberLogIn_click(object sender, EventArgs e)
        {
            string username = txtMemberUsername.Text;
            string password = hashPassword.hashPasswordText(txtMemberPassword);
            updateGetdate();
            userName = txtMemberUsername.Text;
            UserMemberLogin control = new UserMemberLogin();
            control.girisYapMember(username, password, this);
        }

        private void ıconBtnClearMemberText_Click(object sender, EventArgs e)
        {
            txtMemberPassword.Clear();
            txtMemberUsername.Clear();
            txtMemberUsername.Focus();
        }

        private void ıconBtnMemberExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
