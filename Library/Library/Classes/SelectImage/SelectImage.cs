using System.Drawing;
using System.Windows.Forms;

namespace Library.Classes.SelectImage
{
    class SelectImage
    {
        public string GetImage(PictureBox pictureBox, string imageLocationString)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox.Image = new Bitmap(open.FileName);

                // image file path  
                imageLocationString = open.FileName;
            }

            return imageLocationString;
        }
    }
}
