using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MegAsolutionsAssignment
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pAssword = txtPassword.Text;

            if (user.Contains("Admin") && pAssword.Contains("HR123"))
            {
                Hide();
                Form2 ss = new();
                ss.Show();
            }
            else
            {
                _ = MessageBox.Show("Please check your Username and Password");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
