using FontAwesome.Sharp;
using Library.Forms.BookForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Forms.OperationForm
{
    public partial class LibrarySystemForm : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        int count = 0;
        public LibrarySystemForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 44);
            panelSideMenu.Controls.Add(leftBorderBtn);
            customizeDesign();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.BlueViolet;
            public static Color color2 = Color.Aqua;
            public static Color color3 = Color.Lime;
            public static Color color4 = Color.Yellow;
            public static Color color5 = Color.Red;
        };

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                try
                {
                    DisableButton();

                    currentButton = (IconButton)senderBtn;
                    currentButton.ForeColor = color;
                    currentButton.TextAlign = ContentAlignment.MiddleLeft;
                    currentButton.IconColor = color;
                    currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y + panelLogo.Height);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.DarkRed;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void customizeDesign()
        {
            panelPersonel.Visible = false;
            panelAuthor.Visible = false;
            panelPublisher.Visible = false;
            panelBook.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelPersonel.Visible)
            {
                panelPersonel.Visible = false;
            }
            if (panelAuthor.Visible)
            {
                panelAuthor.Visible = false;
            }
            if (panelPublisher.Visible)
            {
                panelPublisher.Visible = false;
            }
            if (panelBook.Visible)
            {
                panelBook.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Show();
        }

        private void iconBtnPersonel_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelPersonel);
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconBtnAuthor_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelAuthor);
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconBtnPublisher_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelPublisher);
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconBtnBook_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelBook);
            ActivateButton(sender, RGBColors.color4);
        }


        private void iconBtnAddPersonel_Click(object sender, System.EventArgs e)
        {
            openChildForm(new AddPersonel());
            HideSubMenu();
        }

        private void iconBtnUpdatePersonel_Click(object sender, System.EventArgs e)
        {
            openChildForm(new UpdatePersonel());
            HideSubMenu();
        }

        private void iconBtnRemovePersonel_Click(object sender, System.EventArgs e)
        {
            openChildForm(new DeletePersonel());
            HideSubMenu();
        }

        private void iconBtnSearchPersonel_Click(object sender, System.EventArgs e)
        {
            openChildForm(new SearchPersonel());
            HideSubMenu();
        }

        private void iconBtnAddAuthor_Click(object sender, System.EventArgs e)
        {
            openChildForm(new AddAuthor());
            HideSubMenu();
        }

        private void iconBtnUpdateAuthor_Click(object sender, System.EventArgs e)
        {
            openChildForm(new UpdateAuthor());
            HideSubMenu();
        }

        private void iconBtnRemoveAuthor_Click(object sender, System.EventArgs e)
        {
            openChildForm(new DeleteAuthor());
            HideSubMenu();
        }

        private void iconBtnSearchAuthor_Click(object sender, System.EventArgs e)
        {
            openChildForm(new SearchAuthor());
            HideSubMenu();
        }

        private void iconBtnAddPublisher_Click(object sender, System.EventArgs e)
        {
            openChildForm(new AddPublisher());
            HideSubMenu();
        }

        private void iconBtnUpdatePublisher_Click(object sender, System.EventArgs e)
        {
            openChildForm(new UpdatePublisher());
            HideSubMenu();
        }

        private void iconBtnDeletePublisher_Click(object sender, System.EventArgs e)
        {
            openChildForm(new DeletePublisher());
            HideSubMenu();
        }

        private void iconBtnSearckPublisher_Click(object sender, System.EventArgs e)
        {
            openChildForm(new SearchPublisher());
            HideSubMenu();
        }

        private void iconBtnAddBook_Click(object sender, System.EventArgs e)
        {
            openChildForm(new AddBook());
            HideSubMenu();
        }

        private void iconBtnUpdateBook_Click(object sender, System.EventArgs e)
        {
            openChildForm(new UpdateBook());
            HideSubMenu();
        }

        private void iconBtnSearchBook_Click(object sender, System.EventArgs e)
        {
            openChildForm(new SearchBook());
            HideSubMenu();
        }

        private void iconBtnDeleteBook_Click(object sender, System.EventArgs e)
        {
            openChildForm(new DeleteBook());
            HideSubMenu();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconPictureBox2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                ıconPictureBox2.IconChar = IconChar.WindowRestore;
                ıconPictureBox2.IconSize = 18;
                ıconPictureBox2.IconColor = Color.White;
                count++;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ıconPictureBox2.IconChar = IconChar.Square;
                ıconPictureBox2.IconSize = 18;
                ıconPictureBox2.IconColor = Color.White;
                count--;
            }

        }

        private void ıconPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LibrarySystemForm_Load(object sender, EventArgs e)
        {
            panelOperation.AutoScroll = false;
            panelOperation.Visible = true;
        }


    }
}
