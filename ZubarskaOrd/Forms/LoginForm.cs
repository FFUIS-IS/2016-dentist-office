using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using ZubarskaOrd.Models;
using ZubarskaOrd.Repos;

namespace ZubarskaOrd
{
    public partial class LoginForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        private string username;
        private string password;
        private string officeName;
        public bool loginSucces;
        public static int userIdentity;

        public LoginForm()
        {
            InitializeComponent();
            loadOffices();
        }

        private string givingNameToOffice()
        {

            if (officeNameComboBox.SelectedItem != null)
            {
                return officeName = officeNameComboBox.SelectedItem.ToString();
            }
            else 
            {
                throw new Exception("You must select Dentist Office!");
            }
        }

        

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            User user = new User(username, password);

            try
            {
                Office office = new Office(givingNameToOffice());
                UserRepository.Login(user);
                loginSucces = true;
                DialogResult = DialogResult.OK;
                userIdentity = user.Identity;
                Office.Name = officeName;
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
                else if (officeNameComboBox.SelectedItem == null)
                {
                    MessageBox.Show(exception.Message);
                    officeNameComboBox.Focus();
                }
                else if (loginSucces != true)
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
        
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginButton_Click(sender, e);
        
        }

        private void loadOffices()
        {
            SqlCeCommand cm = new SqlCeCommand("SELECT * FROM DentistOffice ORDER BY OfficeName ASC", connection);

            try
            {
                SqlCeDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    officeNameComboBox.Items.Add(dr["OfficeName"]);
                }
                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
