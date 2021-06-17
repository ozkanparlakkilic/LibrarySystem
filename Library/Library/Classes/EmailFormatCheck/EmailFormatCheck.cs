using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library.Classes.EmailFormatCheck
{
    class EmailFormatCheck
    {
        public bool txtEmail_Leave(TextBox textBox)
        {
            Regex mRegxExpression;
            if (textBox.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(textBox.Text.Trim()))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
