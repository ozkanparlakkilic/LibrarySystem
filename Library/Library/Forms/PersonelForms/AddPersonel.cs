using Library.Classes;
using Library.Classes.Dal_DatabaseOperation_;
using Library.Classes.SelectImage;
using Library.Classes.TableChecked;
using Library.Classes.TableClasses;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library
{
    public partial class AddPersonel : Form
    {
        private PersonelDal _personelDal = new PersonelDal();
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(conString);
        public SqlDataReader Reader;
        private int count;
        private string imageLocationString = "";
        private bool tableChecked = false;
        private SelectImage selectImage = new SelectImage();
        private string imageLocation;
        private TableCheckFromDatabase tableCheckFromDatabase = new TableCheckFromDatabase();
        private FormDesignControl formDesign = new FormDesignControl();
        public AddPersonel()
        {
            InitializeComponent();
        }

        private void personelChecked()
        {
            try
            {
                connection.Open();
                string sorgu = String.Concat("SELECT * FROM PERSONEL WHERE NAME = @NAME AND SURNAME = @SURNAME AND EMAIL = @EMAIL AND" +
                                             " YEAR_OF_BIRTH = @YEAR_OF_BIRTH " +
                                             " AND  NATIONALITY = @NATIONALITY AND GENDER = @GENDER AND POSITION = @POSITION");
                SqlCommand cmd = new SqlCommand(sorgu, connection);
                cmd.Parameters.AddWithValue("@NAME", txtPersonelName.Text);
                cmd.Parameters.AddWithValue("@SURNAME", txtPersonelSurname.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtPersonelEmail.Text);
                cmd.Parameters.AddWithValue("@YEAR_OF_BIRTH", dtpAddPersonel.Text);
                cmd.Parameters.AddWithValue("@NATIONALITY", cmbPersonelNationality.Text);
                cmd.Parameters.AddWithValue("@POSITION", cmbPosition.Text);

                if (rbPersonelMan.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@GENDER", rbPersonelMan.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GENDER", rbPersonelWoman.Text);
                }

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
        private bool txtEmail_Leave()
        {
            Regex mRegxExpression;
            if (txtPersonelEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtPersonelEmail.Text.Trim()))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnAddPersonel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPersonelName.Text == "" || txtPersonelSurname.Text == "" || txtPersonelEmail.Text == "" || dtpAddPersonel.Text == ""
                    || cmbPersonelNationality.Text == "" || (imageLocation == null || imageLocation == "")
                    || (rbPersonelMan.Checked == false && rbPersonelWoman.Checked == false))
                {
                    MessageBox.Show("Boş bırakmayınız");
                }
                else
                {
                    if (rbPersonelMan.Checked)
                    {
                        tableChecked = tableCheckFromDatabase.IsTableExisting("PERSONEL");


                        if (tableChecked)
                        {
                            personelChecked();
                        }

                        if (count == 0)
                        {
                            if (txtEmail_Leave())
                            {
                                _personelDal.Add(new PERSONEL()
                                {
                                    NAME = txtPersonelName.Text,
                                    SURNAME = txtPersonelSurname.Text,
                                    EMAIL = txtPersonelEmail.Text,
                                    NATIONALITY = cmbPersonelNationality.Text,
                                    YEAR_OF_BIRTH = dtpAddPersonel.Text,
                                    GENDER = rbPersonelMan.Text,
                                    POSITION = cmbPosition.Text,
                                    IMAGE = imageLocation
                                });
                                MessageBox.Show("Added");
                            }
                            else
                            {
                                MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPersonelEmail.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu personel zaten mevcut");
                        }

                    }
                    else
                    {
                        txtEmail_Leave();
                        tableChecked = tableCheckFromDatabase.IsTableExisting("PERSONEL");


                        if (tableChecked)
                        {
                            personelChecked();
                        }

                        if (count == 0)
                        {
                            if (txtEmail_Leave())
                            {
                                _personelDal.Add(new PERSONEL()
                                {
                                    NAME = txtPersonelName.Text,
                                    SURNAME = txtPersonelSurname.Text,
                                    EMAIL = txtPersonelEmail.Text,
                                    NATIONALITY = cmbPersonelNationality.Text,
                                    YEAR_OF_BIRTH = dtpAddPersonel.Text,
                                    GENDER = rbPersonelWoman.Text,
                                    POSITION = cmbPosition.Text,
                                    IMAGE = imageLocation
                                });
                                MessageBox.Show("Added");
                            }
                            else
                            {
                                MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPersonelEmail.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu personel zaten mevcut");
                        }
                    }

                    count = 0;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ptxAddPersonel_Click(object sender, EventArgs e)
        {
            imageLocation = selectImage.GetImage(ptxAddPersonel, imageLocationString);
        }

        private void AddPersonel_Load(object sender, EventArgs e)
        {
            formDesign.FormDesignSetControls(Controls, this);
            dtpAddPersonel.CustomFormat = "dd-MM-yyyy";
        }
    }
}
