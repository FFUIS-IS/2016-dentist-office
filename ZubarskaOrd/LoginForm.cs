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

        public bool loginSucces = false;

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            
            User user = new User(usernameTextBox.Text, passwordTextBox.Text);

            try
            {
                UserRepository.Login(user);
                DialogResult = DialogResult.OK;
                loginSucces = true;
                DentalOfficeForm dentalOfficeForm = new DentalOfficeForm();
                dentalOfficeForm.ShowDialog();
                Close();
                
            }

            catch (Exception)
            { 

                if (usernameTextBox.Text.Length == 0)
                        MessageBox.Show("Username must be filled!");
                else if (passwordTextBox.Text.Length == 0)
                        MessageBox.Show("Password must be filled!");
                else
                        MessageBox.Show("Please insert correct username and password!");
            
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
