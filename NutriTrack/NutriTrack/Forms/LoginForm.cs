using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void picPasswordEye_Click(object sender, EventArgs e)
        {
            // Show / hide the password characters
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("A password reset link will be sent to your email address.", "Forgot Password",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // GUI stage: no authentication yet, just open the dashboard
            Navigator.Go(this, new DashboardForm());
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new RegisterForm());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UiHelper.ApplyRoundedCorners(this);
        }
    }
}
