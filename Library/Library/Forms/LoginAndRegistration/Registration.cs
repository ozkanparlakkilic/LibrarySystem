using Library.Classes.Dal_DatabaseOperation_;
using Library.Classes.TableClasses;
using Library.Forms.LoginAndRegistration;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Registration : Form
    {
        private LoginDal _loginDal = new LoginDal();
        private string hashPassword;
        SHA1 sha = new SHA1CryptoServiceProvider();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(conString);
        public SqlDataReader Reader;
        private int count;
        private int id;

        public Registration()
        {
            InitializeComponent();
        }

        private void positionChecked()
        {
            try
            {
                connection.Open();
                id = Convert.ToInt32(txtID.Text);
                string sorgu = String.Concat("SELECT * FROM PERSONEL WHERE ID = @ID AND (POSITION = 'ADMIN' OR POSITION = 'AUTHORIZED')");
                SqlCommand cmd = new SqlCommand(sorgu, connection);
                cmd.Parameters.AddWithValue("@ID", id);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                positionChecked();
                if (txtID.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Boş bırakmayınız");
                }
                else
                {
                    if (count == 1)
                    {
                        hashPassword = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text)));
                        _loginDal.Add(new LOGIN()
                        {
                            PERSONEL_ID = Int32.Parse(txtID.Text),
                            USERNAME = txtUserName.Text,
                            PASSWORD = hashPassword
                        });
                        MessageBox.Show("Added");
                    }
                    else
                    {
                        MessageBox.Show("Yetkiniz bulunmamaktadır");
                    }
                }

                count = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtID.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
