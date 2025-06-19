using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (emailBox.Text == "Cam" && passwordBox.Text == "1234")
            {
                MessageBox.Show("Welcome, Cam!");
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }
    }
}
