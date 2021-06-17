using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Library.Forms.LoginAndRegistration
{
    public partial class ChangePasswordForm : Form
    {
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlCommand cmd, cmdReader;
        private string query;
        private string queryReader;
        private string email;
        private string hashPassword;
        SHA1 sha = new SHA1CryptoServiceProvider();

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult Exit;
            //Exit = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            //if (Exit == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //if (Exit == DialogResult.No)
            //{
            //    Application.Run();
            //}
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız");
            }
            else
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    SqlDataReader rd;
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(conString))
                        {
                            connection.Open();
                            email = ForgetPasswordForm.email;
                            query = "UPDATE LOGIN SET PASSWORD = @PASSWORD WHERE PERSONEL_ID = " +
                                    " (SELECT ID FROM PERSONEL WHERE EMAIL = @EMAIL) ";
                            queryReader = "SELECT ID FROM PERSONEL WHERE EMAIL = @EMAIL";
                            cmd = new SqlCommand(query, connection);
                            cmdReader = new SqlCommand(queryReader, connection);
                            hashPassword = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(txtNewPassword.Text)));
                            cmd.Parameters.AddWithValue("@PASSWORD", hashPassword);
                            cmd.Parameters.AddWithValue("@EMAIL", email);
                            cmdReader.Parameters.AddWithValue("@EMAIL", email);
                            cmd.ExecuteNonQuery();
                            rd = cmdReader.ExecuteReader();
                            if (rd.Read())
                            {
                                MessageBox.Show("Şifre başarıyla değiştirildi");
                                Login login = new Login();
                                login.iconBtnClearFields_Click(sender, e);
                                login.Show();
                                this.Close();
                                connection.Close();
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Parolalar uyuşmuyor");
                }
            }



        }

    }
}
