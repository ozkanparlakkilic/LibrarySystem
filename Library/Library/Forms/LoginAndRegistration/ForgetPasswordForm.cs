using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Forms.LoginAndRegistration
{
    public partial class ForgetPasswordForm : Form
    {
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlCommand cmd;
        private string query;
        public static string email;
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(conString))
                    {
                        query =
                            "SELECT * FROM LOGIN L INNER JOIN PERSONEL P ON L.PERSONEL_ID = P.ID WHERE USERNAME = @USERNAME AND EMAIL = @EMAIL";
                        connection.Open();
                        cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@USERNAME", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            email = txtEmail.Text;
                            ChangePasswordForm changePassword = new ChangePasswordForm();
                            changePassword.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Email or User Name");
                            rd.Close();
                            connection.Close();
                        }

                        rd.Close();
                        connection.Close();

                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }


        }

        private void ForgetPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Exit == DialogResult.No)
            {
                Application.Run();
            }
        }
    }
}
