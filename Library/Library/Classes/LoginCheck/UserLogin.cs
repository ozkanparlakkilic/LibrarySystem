using Library.Forms.OperationForm;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Classes.LoginCheck
{
    class UserLogin
    {
        private static string connectionString =
           "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlConnection con = new SqlConnection(connectionString);
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlCommand commandPersonel;
        private SqlDataReader readerPersonel;

        public void girisYap(string ad, string sifre, Form frm1)
        {
            con.Open();
            command = new SqlCommand("SELECT * FROM LOGIN L INNER JOIN PERSONEL P ON L.PERSONEL_ID = P.ID WHERE USERNAME = @UserName " +
                                     "AND PASSWORD = @Password AND P.POSITION = 'ADMIN'", con);
            command.Parameters.AddWithValue("@UserName", ad);
            command.Parameters.AddWithValue("@Password", sifre);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                LibrarySystemForm librarySystemForm = new LibrarySystemForm();
                librarySystemForm.Show();
                frm1.Hide();
            }
            else
            {
                reader.Close();
                commandPersonel = new SqlCommand("SELECT * FROM LOGIN L INNER JOIN PERSONEL P ON L.PERSONEL_ID = P.ID WHERE USERNAME = @UserName " +
                                                 "AND PASSWORD = @Password AND P.POSITION = 'AUTHORIZED'", con);
                commandPersonel.Parameters.AddWithValue("@UserName", ad);
                commandPersonel.Parameters.AddWithValue("@Password", sifre);
                readerPersonel = commandPersonel.ExecuteReader();

                if (readerPersonel.Read())
                {
                    PersonelPanelForm operation = new PersonelPanelForm();
                    operation.Show();
                    frm1.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı / Şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                readerPersonel.Close();
            }
            con.Close();
            command.Dispose();
        }
    }
}
