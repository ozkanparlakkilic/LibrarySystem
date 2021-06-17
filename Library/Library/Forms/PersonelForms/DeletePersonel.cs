using Library.Classes;
using Library.Classes.ClearClass;
using Library.Classes.Dal_DatabaseOperation_;
using Library.Classes.SelectImage;
using Library.Classes.TableClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class DeletePersonel : Form
    {
        private PersonelDal _personelDal = new PersonelDal();
        private SqlCommand cmd;
        private string sql;
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        DataTable tbl = new DataTable();
        private LoginDal _loginDal = new LoginDal();
        private SqlConnection connection = new SqlConnection(conString);
        private ClearTxtAndCmb clear = new ClearTxtAndCmb();
        private SelectImage selectImage = new SelectImage();
        private string imageLocationString = "";
        private FormDesignControl formDesign = new FormDesignControl();

        public DeletePersonel()
        {
            InitializeComponent();
        }

        private void dgwRemovePersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRemovePersonelName.Text = dgwRemovePersonel.CurrentRow.Cells[1].Value.ToString();
            txtRemovePersonelSurname.Text = dgwRemovePersonel.CurrentRow.Cells[2].Value.ToString();
            txtRemovePersonelEmail.Text = dgwRemovePersonel.CurrentRow.Cells[3].Value.ToString();
            dtpDeletePersonel.Text = dgwRemovePersonel.CurrentRow.Cells[4].Value.ToString();
            cmbRemovePersonelNationality.Text = dgwRemovePersonel.CurrentRow.Cells[5].Value.ToString();
            if (rbRemovePersonelMan.Text == dgwRemovePersonel.CurrentRow.Cells[6].Value.ToString())
            {
                rbRemovePersonelMan.Checked = true;
            }
            else
            {
                rbRemovePersonelWoman.Checked = true;
            }

            cmbRemovePosition.Text = dgwRemovePersonel.CurrentRow.Cells[7].Value.ToString();
            ptxDeletePersonel.Image = Image.FromFile(dgwRemovePersonel.CurrentRow.Cells[8].Value.ToString());
        }
        private void LoadPersonel()
        {
            dgwRemovePersonel.DataSource = _personelDal.GetAll();
        }
        private void DeletePersonel_Load(object sender, EventArgs e)
        {
            LoadPersonel();
            formDesign.FormDesignSetControls(Controls, this);
            dtpDeletePersonel.CustomFormat = "dd-MM-yyyy";
        }


        public void Search()
        {

            tbl.Clear();
            try
            {
                string sql = "SELECT * FROM PERSONEL";
                using (var con = new SqlConnection(conString))
                {
                    using (var cmd = new SqlCommand())
                    {
                        List<string> clauses = new List<string>();

                        if (!string.IsNullOrEmpty(txtRemovePersonelName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtRemovePersonelName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtRemovePersonelSurname.Text))
                        {
                            clauses.Add("SURNAME like @SURNAME");
                            cmd.Parameters.Add("@SURNAME", SqlDbType.NVarChar).Value =
                                txtRemovePersonelSurname.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtRemovePersonelEmail.Text))
                        {
                            clauses.Add("EMAIL like @EMAIL");
                            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value =
                                txtRemovePersonelEmail.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbRemovePersonelNationality.Text))
                        {
                            clauses.Add("NATIONALITY like @NATIONALITY");
                            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar).Value =
                                cmbRemovePersonelNationality.Text.Trim() + "%";
                        }

                        if (rbRemovePersonelMan.Checked == true)
                        {
                            clauses.Add("GENDER like @GENDERMAN");
                            cmd.Parameters.Add("@GENDERMAN", SqlDbType.NVarChar).Value =
                                rbRemovePersonelMan.Text.Trim() + "%";
                        }

                        if (rbRemovePersonelWoman.Checked == true)
                        {
                            clauses.Add("GENDER like @GENDERWOMAN");
                            cmd.Parameters.Add("@GENDERWOMAN", SqlDbType.NVarChar).Value =
                                rbRemovePersonelWoman.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbRemovePosition.Text))
                        {
                            clauses.Add("POSITION like @POSITION");
                            cmd.Parameters.Add("@POSITION", SqlDbType.NVarChar).Value =
                                cmbRemovePosition.Text.Trim() + "%";
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


                        dgwRemovePersonel.DataSource = tbl;

                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtRemovePersonelName_TextChanged(object sender, EventArgs e)
        {
            Search();

        }

        private void txtRemovePersonelSurname_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void txtRemovePersonelEmail_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void cmbRemovePersonelNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();

        }
        private void rbRemovePersonelMan_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbRemovePersonelWoman_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbRemovePosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnRemovePersonel_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                connection.Open();
                string sorgu = String.Concat("SELECT * FROM LOGIN WHERE PERSONEL_ID = '" + Convert.ToInt32(dgwRemovePersonel.CurrentRow.Cells[0].Value) + "'");
                SqlCommand cmd = new SqlCommand(sorgu, connection);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                DialogResult secenek = MessageBox.Show($"Are you sure you want to delete {txtRemovePersonelName.Text} " +
                                                       $"{txtRemovePersonelSurname.Text} ?"
                    , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (secenek == DialogResult.Yes)
                {
                    if (id == 0)
                    {
                        _personelDal.Delete(new PERSONEL
                        {
                            ID = Convert.ToInt32(dgwRemovePersonel.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show($"{txtRemovePersonelName.Text} {txtRemovePersonelSurname.Text} was deleted ");
                        LoadPersonel();

                        clear.ClearAllText(this);
                    }
                    else
                    {
                        _loginDal.Delete(new LOGIN
                        {
                            ID = id,
                        });
                        _personelDal.Delete(new PERSONEL
                        {
                            ID = Convert.ToInt32(dgwRemovePersonel.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show($"{txtRemovePersonelName.Text} {txtRemovePersonelSurname.Text} was deleted ");
                        LoadPersonel();

                        clear.ClearAllText(this);
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ptxDeletePersonel_Click(object sender, EventArgs e)
        {
            selectImage.GetImage(ptxDeletePersonel, imageLocationString);
        }

    }
}
