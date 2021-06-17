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
    public partial class UpdatePersonel : Form
    {
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private PersonelDal _personelDal = new PersonelDal();
        private SqlCommand cmd;
        private SqlConnection connection = new SqlConnection(conString);
        private int id;
        private ClearTxtAndCmb clear = new ClearTxtAndCmb();
        DataTable tbl = new DataTable();
        private string imageLocation;
        private string imageLocationString = "";
        private SelectImage selectImage = new SelectImage();
        private FormDesignControl formDesign = new FormDesignControl();
        public UpdatePersonel()
        {
            InitializeComponent();
        }

        private void LoadPersonel()
        {
            dgwUpdatePersonel.DataSource = _personelDal.GetAll();
        }

        private void UpdatePersonel_Load(object sender, EventArgs e)
        {
            LoadPersonel();
            formDesign.FormDesignSetControls(Controls, this);
            dtpUpdatePersonel.CustomFormat = "dd-MM-yyyy";
        }

        private void dgwUpdatePersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgwUpdatePersonel.CurrentRow.Cells[0].Value);
            txtUpdatePersonelName.Text = dgwUpdatePersonel.CurrentRow.Cells[1].Value.ToString();
            txtUpdatePersonelSurname.Text = dgwUpdatePersonel.CurrentRow.Cells[2].Value.ToString();
            txtUpdatePersonelEmail.Text = dgwUpdatePersonel.CurrentRow.Cells[3].Value.ToString();
            dtpUpdatePersonel.Text = dgwUpdatePersonel.CurrentRow.Cells[4].Value.ToString();
            cmbUpdatePersonelNationality.Text = dgwUpdatePersonel.CurrentRow.Cells[5].Value.ToString();
            if (rbUpdatePersonelMan.Text == dgwUpdatePersonel.CurrentRow.Cells[6].Value.ToString())
            {
                rbUpdatePersonelMan.Checked = true;
            }
            else
            {
                rbUpdatePersonelWoman.Checked = true;
            }

            cmbUpdatePosition.Text = dgwUpdatePersonel.CurrentRow.Cells[7].Value.ToString();
            try
            {
                ptxUpdatePersonel.Image = Image.FromFile(dgwUpdatePersonel.CurrentRow.Cells[8].Value.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.StackTrace);
            }

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

                        if (!string.IsNullOrEmpty(txtUpdatePersonelName.Text))
                        {
                            clauses.Add("NAME like @NAME");
                            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value =
                                txtUpdatePersonelName.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUpdatePersonelSurname.Text))
                        {
                            clauses.Add("SURNAME like @SURNAME");
                            cmd.Parameters.Add("@SURNAME", SqlDbType.NVarChar).Value =
                                txtUpdatePersonelSurname.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(txtUpdatePersonelEmail.Text))
                        {
                            clauses.Add("EMAIL like @EMAIL");
                            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value =
                                txtUpdatePersonelEmail.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbUpdatePersonelNationality.Text))
                        {
                            clauses.Add("NATIONALITY like @NATIONALITY");
                            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar).Value =
                                cmbUpdatePersonelNationality.Text.Trim() + "%";
                        }

                        if (rbUpdatePersonelMan.Checked)
                        {
                            clauses.Add("GENDER like @GENDERMAN");
                            cmd.Parameters.Add("@GENDERMAN", SqlDbType.NVarChar).Value =
                                rbUpdatePersonelMan.Text.Trim() + "%";
                        }

                        if (rbUpdatePersonelWoman.Checked)
                        {
                            clauses.Add("GENDER like @GENDERWOMAN");
                            cmd.Parameters.Add("@GENDERWOMAN", SqlDbType.NVarChar).Value =
                                rbUpdatePersonelWoman.Text.Trim() + "%";
                        }

                        if (!string.IsNullOrEmpty(cmbUpdatePosition.Text))
                        {
                            clauses.Add("POSITION like @POSITION");
                            cmd.Parameters.Add("@POSITION", SqlDbType.NVarChar).Value =
                                cmbUpdatePosition.Text.Trim() + "%";
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


                        dgwUpdatePersonel.DataSource = tbl;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtUpdatePersonelName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtUpdatePersonelSurname_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void txtUpdatePersonelEmail_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void cmbUpdatePersonelNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbUpdatePersonelMan_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rbUpdatePersonelWoman_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbUpdatePosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnUpdatePersonel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secenek = MessageBox.Show($"Are you sure you want to update {txtUpdatePersonelName.Text} " +
                                                                  $"{txtUpdatePersonelSurname.Text} ?"
                               , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (secenek == DialogResult.Yes)
                {
                    if (rbUpdatePersonelMan.Checked)
                    {
                        _personelDal.Update(new PERSONEL
                        {
                            ID = id,
                            NAME = txtUpdatePersonelName.Text,
                            SURNAME = txtUpdatePersonelSurname.Text,
                            EMAIL = txtUpdatePersonelEmail.Text,
                            YEAR_OF_BIRTH = dtpUpdatePersonel.Text,
                            NATIONALITY = cmbUpdatePersonelNationality.Text,
                            GENDER = rbUpdatePersonelMan.Text,
                            POSITION = cmbUpdatePosition.Text,
                            IMAGE = imageLocation
                        });
                    }
                    else
                    {
                        _personelDal.Update(new PERSONEL
                        {
                            ID = id,
                            NAME = txtUpdatePersonelName.Text,
                            SURNAME = txtUpdatePersonelSurname.Text,
                            EMAIL = txtUpdatePersonelEmail.Text,
                            YEAR_OF_BIRTH = dtpUpdatePersonel.Text,
                            NATIONALITY = cmbUpdatePersonelNationality.Text,
                            GENDER = rbUpdatePersonelWoman.Text,
                            POSITION = cmbUpdatePosition.Text,
                            IMAGE = imageLocation
                        });
                    }
                    MessageBox.Show($"{txtUpdatePersonelName.Text} {txtUpdatePersonelSurname.Text} was updated ");
                    LoadPersonel();

                    clear.ClearAllText(this);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ptxUpdatePersonel_Click(object sender, EventArgs e)
        {
            imageLocation = selectImage.GetImage(ptxUpdatePersonel, imageLocationString);
        }

    }
}
