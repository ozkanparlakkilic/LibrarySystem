using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Classes
{
    class FormDesignControl
    {
        public void FormDesignSetControls(Control.ControlCollection Controls, Form form)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).BackColor = Color.Gainsboro;
                        (control as TextBox).BorderStyle = BorderStyle.None;
                        (control as TextBox).Font = new Font("Century Gothic", 12);
                    }

                    if (control is ComboBox)
                    {
                        (control as ComboBox).FlatStyle = FlatStyle.Flat;
                        (control as ComboBox).Font = new Font("Century Gothic", 12);
                    }

                    if (control is Label)
                    {
                        (control as Label).ForeColor = Color.White;
                        (control as Label).Font = new Font("Century Gothic", 12);
                    }

                    if (control is RadioButton)
                    {
                        (control as RadioButton).ForeColor = Color.White;
                        (control as RadioButton).Font = new Font("Century Gothic", 12);
                    }

                    if (control is GroupBox)
                    {
                        (control as GroupBox).ForeColor = Color.White;
                        (control as GroupBox).Font = new Font("Century Gothic", 12);
                    }

                    if (control is Button)
                    {
                        (control as Button).ForeColor = Color.White;
                        (control as Button).BackColor = Color.DarkRed;
                        (control as Button).FlatStyle = FlatStyle.Flat;
                        (control as Button).Font = new Font("Century Gothic", 12);
                    }

                    if (control is DataGridView)
                    {

                        (control as DataGridView).RowHeadersVisible = false;
                        (control as DataGridView).BackgroundColor = Color.White;
                        (control as DataGridView).RowTemplate.Height = 30;
                        (control as DataGridView).RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                        (control as DataGridView).DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
                        (control as DataGridView).AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                        (control as DataGridView).BorderStyle = BorderStyle.None;
                        (control as DataGridView).DefaultCellStyle.SelectionForeColor = Color.White;
                        (control as DataGridView).EnableHeadersVisualStyles = false;
                        (control as DataGridView).ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        (control as DataGridView).ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        (control as DataGridView).ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        (control as DataGridView).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        (control as DataGridView).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }

                form.BackColor = Color.FromArgb(32, 30, 45);
            };

            func(Controls);
        }
    }
}
