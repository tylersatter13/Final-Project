using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_Project
{
    public class TextControls:Form
    {
       private  void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(text.Text, "  ^ [0-9]"))
            {
                text.Text = "";
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

            private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextControls
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "TextControls";
            this.Load += new System.EventHandler(this.TextControls_Load);
            this.ResumeLayout(false);

        }

        private void TextControls_Load(object sender, EventArgs e)
        {

        }
    }
}
