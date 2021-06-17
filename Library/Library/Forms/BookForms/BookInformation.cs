using Library.Classes;
using Library.Classes.Dal_DatabaseOperation;
using Library.Classes.TableClasses;
using Library.Forms.BookForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class BookInformation : Form
    {
        private static string conString = "Data Source=DESKTOP-PBVR37A\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";
        private SqlCommand cmd;
        private SqlDataReader reader;
        private int bookId;
        private string isbnNo;
        private BookInformationDal _bookInformationDal = new BookInformationDal();
        private FormDesignControl formDesignControl = new FormDesignControl();
        public BookInformation()
        {
            InitializeComponent();
        }

        private void btnAddBookInformation_Click(object sender, EventArgs e)
        {
            int Amount = 0;
            int Id = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string sorgu = @"SELECT ID FROM BOOK_INFORMATION WHERE BOOK_ID = @BOOK_ID";
                    cmd = new SqlCommand(sorgu, connection);
                    cmd.Parameters.AddWithValue("@BOOK_ID", bookId);
                    Id = Convert.ToInt32(cmd.ExecuteScalar());

                    string sorgu2 = @"SELECT AMOUNT FROM BOOK_INFORMATION WHERE BOOK_ID = @BOOK_ID";
                    cmd = new SqlCommand(sorgu2, connection);
                    cmd.Parameters.AddWithValue("@BOOK_ID", bookId);
                    Amount = Convert.ToInt32(cmd.ExecuteScalar());
                    connection.Close();
                }

                if (txtBookIsbnNo.Text == "" && txtLibraryName.Text == "" && txtBookShelf.Text == ""
                    && txtAmount.Text == "")
                {
                    MessageBox.Show("Boş bırakmayınız");
                }
                else
                {
                    if (Id != 0 && Amount != 0)
                    {
                        _bookInformationDal.Update(new BOOK_INFORMATION
                        {
                            ID = Id,
                            BOOK_ID = bookId,
                            LIBRARY_NAME = txtLibraryName.Text,
                            BOOK_SHELF = txtBookShelf.Text,
                            AMOUNT = Amount + Convert.ToInt32(txtAmount.Text)
                        });

                        MessageBox.Show("Save");
                    }
                    else
                    {

                        _bookInformationDal.Add(new BOOK_INFORMATION
                        {
                            BOOK_ID = bookId,
                            LIBRARY_NAME = txtLibraryName.Text,
                            BOOK_SHELF = txtBookShelf.Text,
                            AMOUNT = Convert.ToInt32(txtAmount.Text)
                        });
                        MessageBox.Show("Added");
                    }
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.InnerException.ToString(), exception.StackTrace);
            }
        }

        private void BookInformation_Load(object sender, EventArgs e)
        {
            bookId = AddBook.book_id;
            isbnNo = AddBook.isbnNoText;
            txtBookIsbnNo.Text = isbnNo;
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
