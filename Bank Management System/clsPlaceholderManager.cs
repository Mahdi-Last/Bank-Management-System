using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public static class clsPlaceholderManager
    {
        public static void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Tag = placeholder;
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            

            textBox.GotFocus -= Txt_GotFocus;
            textBox.LostFocus -= Txt_LostFocus;

            textBox.GotFocus += Txt_GotFocus;
            textBox.LostFocus += Txt_LostFocus;
        }

        private static void Txt_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string placeholder = textBox.Tag as string;

            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private static void Txt_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string placeholder = textBox.Tag as string;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        public static string GetText(TextBox textBox)
        {
            string placeholder = textBox.Tag as string;
            return textBox.Text == placeholder ? string.Empty : textBox.Text;
        }
    }
}
