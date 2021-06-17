using Library.Classes;
using Library.Classes.ClearClass;
using Library.Classes.Dal_DatabaseOperation_;
using Library.Classes.TableClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class DeletePublisher : Form
    {
        private PublisherDal _publisherDal = new PublisherDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        DataTable tbl = new DataTable();
        private ClearTxtAndCmb clear = new ClearTxtAndCmb();
        private SqlConnection connection = new SqlConnection(conString);
        private BookDal _bookDal = new BookDal();
        private FormDesignControl formDesign = new FormDesignControl();
        public DeletePublisher()
        {
            InitializeComponent();
        }
        private void LoadPublisher()
        {
            dgwDeletePublisher.DataSource = _publisherDal.GetAll();
        }

        private void DeletePublisher_Load(object sender, EventArgs e)
        {
            LoadPublisher();
            formDesign.FormDesignSetControls(Controls, this);
        }

        private void dgwDeletePublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeletePublisherName.Text = dgwDeletePublisher.CurrentRow.Cells[1].Value.ToString();
            txtDeleteAddress.Text = dgwDeletePublisher.CurrentRow.Cells[2].Value.ToString();
            dtpDeletePublisher.Text = dgwDeletePublisher.CurrentRow.Cells[3].Value.ToString();
        }
        public void Search()
        {
            tbl.Clear();
            try
            {
                string sql = "SELECT * FROM PUBLISHER";
                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtDeletePublisherName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtDeletePublisherName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtDeleteAddress.Text))
                        {
                            clauses.Add("ADDRESS like @ADDRESS");
                            cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar).Value =
                                txtDeleteAddress.Text.Trim() + "%";
                        }


                        if (clauses.Count > 0)
                        {
                            sql += " where " + string.Join(" and ", clauses);
                        }

                        cmd.Connection = con;
                        cmd.CommandText = sql;
                        con.Open();

                        tbl.Load(cmd.ExecuteReader());
                        con.Close();


                        dgwDeletePublisher.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtDeletePublisherName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtDeleteAddress_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btmDeletePublisher_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                connection.Open();
                string sorgu = String.Concat("SELECT * FROM PUBLISHER WHERE ID = '" + dgwDeletePublisher.CurrentRow.Cells[0].Value + "'");
                SqlCommand cmd = new SqlCommand(sorgu, connection);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                DialogResult secenek = MessageBox.Show($"Are you sure you want to delete {txtDeletePublisherName.Text} ?"
                    , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (secenek == DialogResult.Yes)
                {
                    if (id == 0)
                    {
                        _publisherDal.Delete(new PUBLISHER
                        {
                            ID = Convert.ToInt32(dgwDeletePublisher.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show($"{txtDeletePublisherName.Text}  was deleted ");
                        LoadPublisher();

                        clear.ClearAllText(this);
                    }
                    else
                    {
                        MessageBox.Show("Bu yayin evi silinemez kullanıldığı kayıt var");
                        clear.ClearAllText(this);
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
