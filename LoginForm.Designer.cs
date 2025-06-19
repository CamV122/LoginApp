namespace LoginApp
{
    partial class LoginForm
    {
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;

        private void InitializeComponent()
        {
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // emailBox
            this.emailBox.PlaceholderText = "Email";
            this.emailBox.Location = new System.Drawing.Point(30, 30);
            this.emailBox.Width = 220;

            // passwordBox
            this.passwordBox.PlaceholderText = "Password";
            this.passwordBox.Location = new System.Drawing.Point(30, 70);
            this.passwordBox.Width = 220;
            this.passwordBox.UseSystemPasswordChar = true;

            // loginBtn
            this.loginBtn.Text = "Login";
            this.loginBtn.Location = new System.Drawing.Point(30, 110);
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);

            // registerBtn
            this.registerBtn.Text = "Register";
            this.registerBtn.Location = new System.Drawing.Point(120, 110);

            // LoginForm
            this.ClientSize = new System.Drawing.Size(280, 170);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                emailBox, passwordBox, loginBtn, registerBtn
            });
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
        }
    }
}
