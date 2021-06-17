using System.Data.SqlClient;

namespace Library.Classes.TableChecked
{
    class TableCheckFromDatabase
    {
        private static string conString =
            "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        public bool IsTableExisting(string table)
        {
            string command = $"select * from sys.tables";
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand com = new SqlCommand(command, con))
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0).ToLower() == table.ToLower())
                        return true;
                }
                reader.Close();
                con.Close();
            }
            return false;
        }
    }
}
