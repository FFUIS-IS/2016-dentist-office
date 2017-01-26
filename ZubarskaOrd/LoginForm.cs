using System;
using System.Windows.Forms;
using ZubarskaOrd.Models;
using ZubarskaOrd.Repos;

namespace ZubarskaOrd
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
                User user = new User(usernameTextBox.Text, passwordTextBox.Text);

            if (UserRepository.Login(user))
            {
                MessageBox.Show("Uspijesno logovanje!");
                DialogResult = DialogResult.OK;
                Close();
            }

            else if (usernameTextBox.Text.Length == 0)
                    MessageBox.Show("Username must be filled!");
            else if (passwordTextBox.Text.Length == 0)
                    MessageBox.Show("Password must be filled!");
            else
                    MessageBox.Show("Please insert correct username and password!");
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
