using Library.Classes.Dal_DatabaseOperation;
using Library.Classes.EmailFormatCheck;
using Library.Classes.HashPassword;
using Library.Classes.TableChecked;
using Library.Classes.TableClasses;
using Library.Forms.LoginAndRegistration;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Library
{
    public partial class MemberRegistration : Form
    {
        private MemberDal _memberDal = new MemberDal();
        private MemberInformationDal _memberInformationDal = new MemberInformationDal();
        private EmailFormatCheck emailFormatCheck = new EmailFormatCheck();
        private HashPassword hashPassword = new HashPassword();
        private bool tableChecked = false;
        private TableCheckFromDatabase tableCheckFromDatabase = new TableCheckFromDatabase();

        private static string conString =
            "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        public SqlDataReader Reader;
        private SqlCommand cmd;
        private int count = 0;
        private int checkCount = 0;

        public MemberRegistration()
        {
            InitializeComponent();
        }

        private void memberChecked()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    if (checkNational.Checked)
                    {
                        string sorgu = String.Concat("SELECT * FROM MEMBER WHERE PASAPORT_NO = @PASAPORT_NO");
                        SqlCommand cmd = new SqlCommand(sorgu, connection);
                        cmd.Parameters.AddWithValue("@PASAPORT_NO", txtNo.Text);
                        Reader = cmd.ExecuteReader();
                        if (Reader.Read())
                        {
                            count++;
                        }
                        else
                        {
                            count = 0;
                        }
                        Reader.Close();
                        connection.Close();
                    }
                    else
                    {
                        string sorgu = String.Concat("SELECT * FROM MEMBER WHERE TC_NO = @TC_NO");
                        SqlCommand cmd = new SqlCommand(sorgu, connection);
                        cmd.Parameters.AddWithValue("@TC_NO", txtNo.Text);
                        Reader = cmd.ExecuteReader();
                        if (Reader.Read())
                        {
                            count++;
                        }
                        else
                        {
                            count = 0;
                        }
                        Reader.Close();
                        connection.Close();
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int memberId;
            try
            {
                tableChecked = tableCheckFromDatabase.IsTableExisting("MEMBER");

                if (tableChecked)
                {
                    memberChecked();
                }

                if (txtEmail.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || txtName.Text == ""
                    || txtNo.Text == "")
                {
                    MessageBox.Show("Boş bırakmayınız");
                }
                else
                {

                    if (emailFormatCheck.txtEmail_Leave(txtEmail))
                    {
                        if (checkNational.Checked)
                        {

                            if (count == 0)
                            {
                                _memberDal.Add(new MEMBER()
                                {
                                    MEMBER_NAME = txtName.Text,
                                    MEMBER_SURNAME = txtSurname.Text,
                                    USERNAME = txtUserName.Text,
                                    EMAIL = txtEmail.Text,
                                    PASSWORD = hashPassword.hashPasswordText(txtPassword),
                                    TC_NO = "-",
                                    PASAPORT_NO = txtNo.Text
                                });
                                AddMemberInformation();
                                MessageBox.Show("Added");
                            }
                            else
                            {
                                MessageBox.Show("Zaten üyesiniz");
                            }

                        }
                        else
                        {
                            if (count == 0)
                            {
                                _memberDal.Add(new MEMBER()
                                {
                                    MEMBER_NAME = txtName.Text,
                                    MEMBER_SURNAME = txtSurname.Text,
                                    USERNAME = txtUserName.Text,
                                    EMAIL = txtEmail.Text,
                                    PASSWORD = hashPassword.hashPasswordText(txtPassword),
                                    TC_NO = txtNo.Text,
                                    PASAPORT_NO = "-"
                                });

                                AddMemberInformation();
                                MessageBox.Show("Added");

                            }
                            else
                            {
                                MessageBox.Show("Zaten üyesiniz");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Mail doğru formatta değil");
                    }

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddMemberInformation()
        {
            int memberId;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string sorgu = @"SELECT ID FROM MEMBER WHERE USERNAME = @Username";
                cmd = new SqlCommand(sorgu, connection);
                cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                memberId = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
            }

            _memberInformationDal.Add(new MEMBER_INFORMATION
            {
                MEMBER_ID = memberId,
                RANK = "MEMBER",
                STATUS = "ACTIVE"
            });
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtUserName.Focus();
        }

        private void MemberRegistration_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void checkNational_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCount == 0)
            {
                panelPasaport.Visible = true;
                panelTc.Visible = false;
                checkCount++;
            }
            else if (checkCount == 1)
            {
                panelPasaport.Visible = false;
                panelTc.Visible = true;
                checkCount--;
            }

        }
    }
}
