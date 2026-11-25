using System;
using System.Drawing;
using System.Windows.Forms;

namespace NutriTrack
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void picRegPasswordEye_Click(object sender, EventArgs e)
        {
            // Show / hide the password characters
            txtRegPassword.UseSystemPasswordChar = !txtRegPassword.UseSystemPasswordChar;
        }

        private void picConfirmPasswordEye_Click(object sender, EventArgs e)
        {
            // Show / hide the password characters
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // GUI stage: no database yet, just go back to the login screen
            MessageBox.Show("Your account has been created successfully!", "Register",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Navigator.Go(this, new LoginForm());
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navigator.Go(this, new LoginForm());
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            UiHelper.ApplyRoundedCorners(this);
        }
    }
}
