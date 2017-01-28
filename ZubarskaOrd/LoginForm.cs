using System;
using System.Windows.Forms;
using ZubarskaOrd.Models;
using ZubarskaOrd.Repos;

namespace ZubarskaOrd
{
    public partial class LoginForm : Form
    {
        private string username;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
        }

        public bool loginSucces = false;

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            User user = new User(usernameTextBox.Text, passwordTextBox.Text);

            try
            {
                UserRepository.Login(user);
                DialogResult = DialogResult.OK;
                Close();
                
            }

            catch (Exception exception)
            {

                if (usernameTextBox.Text.Length == 0)
                {
                    MessageBox.Show(exception.Message);
                    usernameTextBox.Text = "";
                    usernameTextBox.Focus();
                }
                else if (passwordTextBox.Text.Length == 0)
                {
                    MessageBox.Show(exception.Message);
                    passwordTextBox.Text = "";
                    passwordTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(exception.Message);
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    usernameTextBox.Focus();
                }

                }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
