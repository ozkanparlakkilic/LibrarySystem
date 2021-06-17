using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Classes.LoginCheck
{


    class UserMemberLogin
    {
        private static string connectionString =
    "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlConnection con = new SqlConnection(connectionString);
        private SqlCommand command;
        private SqlDataReader reader;
        private int checkTableData;


        public void girisYapMember(string ad, string sifre, Form frm1)
        {
            con.Open();
            command = new SqlCommand("SELECT * FROM MEMBER WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD", con);
            command.Parameters.AddWithValue("@USERNAME", ad);
            command.Parameters.AddWithValue("@PASSWORD", sifre);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string memberStatus;
                        connection.Open();

                        string sorgu = @"SELECT CASE WHEN OBJECT_ID('dbo.MEMBER_INFORMATION', 'U') IS NOT NULL THEN 1 ELSE 0 END";
                        command = new SqlCommand(sorgu, connection);
                        checkTableData = Convert.ToInt32(command.ExecuteScalar());

                        if (checkTableData != 0)
                        {
                            string sorguControl = @"SELECT STATUS FROM MEMBER_INFORMATION MI INNER JOIN MEMBER M 
                                                ON MI.MEMBER_ID = M.ID WHERE M.USERNAME = @memberUsername";
                            command = new SqlCommand(sorguControl, connection);
                            command.Parameters.AddWithValue("@memberUsername", ad);
                            memberStatus = Convert.ToString(command.ExecuteScalar());

                            if (memberStatus == "ACTIVE")
                            {
                                MemberBookPurchase memberBookPurchase = new MemberBookPurchase();
                                memberBookPurchase.Show();
                                frm1.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hesabınız borçlarınızdan dolayı bloke olmuştur");
                            }
                        }
                        else
                        {
                            MemberBookPurchase memberBookPurchase = new MemberBookPurchase();
                            memberBookPurchase.Show();
                            frm1.Hide();
                        }

                        connection.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
            else
            {
                reader.Close();
                MessageBox.Show("Kullanıcı Adı / Şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            command.Dispose();
        }
    }
}
