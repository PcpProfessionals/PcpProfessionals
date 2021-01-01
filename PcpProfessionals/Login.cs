using BL.Services;
using BL.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace PcpProfessionals
{
    public partial class Login : Form
    {
        private IAuthService _authService;

        public Login()
        {
            _authService = new AuthService();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool isValidUser = false;

            isValidUser = ValidateUsername(isValidUser);

            if (isValidUser)
            {
                var authenticatedUser = _authService.AuthenticateUser(UserNameTb.Text.Trim(), PasswordTb.Text.Trim());

                this.Hide();

                var homePage = new HomePage();

                homePage.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Provided User is invalid.");
            }
        }

        private bool ValidateUsername(bool isValidUser)
        {
            if (!string.IsNullOrEmpty(UserNameTb.Text) && !string.IsNullOrEmpty(PasswordTb.Text))
            {
                isValidUser = _authService.VerifyUsername(UserNameTb.Text.Trim());

            }

            return isValidUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
