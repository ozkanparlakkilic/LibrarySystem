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
    public partial class UpdatePublisher : Form
    {
        private PublisherDal _publisherDal = new PublisherDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        DataTable tbl = new DataTable();
        private ClearTxtAndCmb clear = new ClearTxtAndCmb();
        private SqlConnection connection = new SqlConnection(conString);
        private BookDal _bookDal = new BookDal();
        private int id;
        private FormDesignControl formDesign = new FormDesignControl();
        public UpdatePublisher()
        {
            InitializeComponent();
        }
        private void LoadPublisher()
        {
            dgwUpdatePublisher.DataSource = _publisherDal.GetAll();
        }
        private void UpdatePublisher_Load(object sender, EventArgs e)
        {
            LoadPublisher();
            formDesign.FormDesignSetControls(Controls, this);
        }

        private void dgwUpdatePublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgwUpdatePublisher.CurrentRow.Cells[0].Value);
            txtUpdatePublisherName.Text = dgwUpdatePublisher.CurrentRow.Cells[1].Value.ToString();
            txtUpdateAddress.Text = dgwUpdatePublisher.CurrentRow.Cells[2].Value.ToString();
            dtpUpdatePublisher.Text = dgwUpdatePublisher.CurrentRow.Cells[3].Value.ToString();
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

                        if (!string.IsNullOrEmpty(txtUpdatePublisherName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtUpdatePublisherName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUpdateAddress.Text))
                        {
                            clauses.Add("ADDRESS like @ADDRESS");
                            cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar).Value =
                                txtUpdateAddress.Text.Trim() + "%";
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


                        dgwUpdatePublisher.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtUpdatePublisherName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtUpdateAddress_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btmDeletePublisher_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secenek = MessageBox.Show($"Are you sure you want to update {txtUpdatePublisherName.Text} ?"
                                , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (secenek == DialogResult.Yes)
                {
                    _publisherDal.Update(new PUBLISHER
                    {
                        ID = id,
                        NAME = txtUpdatePublisherName.Text,
                        ADDRESS = txtUpdateAddress.Text,
                        YEAR_OF_FOUNDATION = dtpUpdatePublisher.Text

                    });
                    MessageBox.Show($"{txtUpdatePublisherName.Text}  was update ");
                    LoadPublisher();

                    clear.ClearAllText(this);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
