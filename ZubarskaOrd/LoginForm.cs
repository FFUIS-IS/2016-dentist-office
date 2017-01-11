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
            if (usernameTextBox.ToString() != "")
                usernameWarningLabel.Visible = false;
            if (passwordTextBox.ToString() != "")
                passwordWarningLabel.Visible = false;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(usernameTextBox.Text, passwordTextBox.Text);

                if (UserRepository.Login(user))
                    DialogResult = DialogResult.OK;
                Close();
            }
                
            catch (Exception)
            {

                MessageBox.Show("Pogrešno unijeto korisničko ime ili lozinka");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
