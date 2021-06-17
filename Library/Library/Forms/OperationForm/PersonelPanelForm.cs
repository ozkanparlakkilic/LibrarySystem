using Library.Classes;
using Library.Forms.BookForms;
using System;
using System.Windows.Forms;

namespace Library.Forms.OperationForm
{
    public partial class PersonelPanelForm : Form
    {
        private FormDesignControl formDesignControl = new FormDesignControl();
        public PersonelPanelForm()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void btnTheBookBack_Click(object sender, EventArgs e)
        {
            MemberBookIsBack memberBookIsBack = new MemberBookIsBack();
            memberBookIsBack.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporForm.RaporForm raporForm = new RaporForm.RaporForm();
            raporForm.Show();
        }

        private void PersonelPanelForm_Load(object sender, EventArgs e)
        {
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
