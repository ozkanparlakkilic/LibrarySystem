using System.Windows.Forms;

namespace Library.Classes.ClearClass
{
    class ClearTxtAndCmb
    {
        public void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else
                    ClearAllText(c);

            }

        }
    }
}
