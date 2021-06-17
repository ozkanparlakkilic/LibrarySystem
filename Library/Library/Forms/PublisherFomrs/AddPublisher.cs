using Library.Classes;
using Library.Classes.Dal_DatabaseOperation_;
using Library.Classes.TableChecked;
using Library.Classes.TableClasses;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class AddPublisher : Form
    {
        private PublisherDal _publisherDal = new PublisherDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(conString);
        public SqlDataReader Reader;
        private int count;
        private bool tableChecked = false;
        private TableCheckFromDatabase tableCheckFromDatabase = new TableCheckFromDatabase();
        private FormDesignControl formDesign = new FormDesignControl();
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void publisherChecked()
        {
            try
            {
                connection.Open();
                string sorgu = String.Concat("SELECT * FROM PUBLISHER WHERE NAME = @NAME AND ADDRESS = @ADDRESS AND YEAR_OF_FOUNDATION = @YEAR_OF_FOUNDATION");
                SqlCommand cmd = new SqlCommand(sorgu, connection);
                cmd.Parameters.AddWithValue("@NAME", txtYayinEviName.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", txtAddress.Text);
                cmd.Parameters.AddWithValue("@YEAR_OF_FOUNDATION", dtpYayinEvi.Text);

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

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tableChecked = tableCheckFromDatabase.IsTableExisting("PUBLISHER");
                if (tableChecked)
                {
                    publisherChecked();
                }

                if (txtYayinEviName.Text == "" || txtAddress.Text == "" || dtpYayinEvi.Text == "")
                {
                    MessageBox.Show("Boş bırakmayınız");
                }
                else
                {
                    if (count == 0)
                    {
                        _publisherDal.Add(new PUBLISHER
                        {
                            NAME = txtYayinEviName.Text,
                            ADDRESS = txtAddress.Text,
                            YEAR_OF_FOUNDATION = dtpYayinEvi.Text
                        });

                        MessageBox.Show("Added");
                    }
                    else
                    {
                        MessageBox.Show("Bu Yayin evi zaten ekli");
                    }

                }

                count = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {
            formDesign.FormDesignSetControls(Controls, this);
        }
    }
}
