using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZubarskaOrd.Forms
{
    public partial class PasswordChangigFormStaff : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        private static string oldPassword;
        private static string newPassword;
        private static string confirmPassword;
        private static string password;
        public PasswordChangigFormStaff()
        {
            InitializeComponent();
        }

        private void changingPassword()
        {
            oldPassword = HashPassword.HashNewPassword(oldPasswordTextBox.Text);
            newPassword = newPasswordTextBox.Text;
            confirmPassword = confirmTextBox.Text;

            SqlCeCommand cm = new SqlCeCommand("SELECT password FROM LoginFormTable WHERE MedicalStaffId = '" + LoginForm.userIdentity + "'", connection);
            try
            {
                SqlCeDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    password = (string)dr["password"];

                    if (password == oldPassword)
                    {
                        if (newPasswordTextBox.Text == "" || confirmTextBox.Text == "")
                        {
                            MessageBox.Show("Password fields must be filled!");
                            newPasswordTextBox.Text = "";
                            newPasswordTextBox.Focus();
                            confirmTextBox.Text = "";
                        }
                        else if (newPassword == confirmPassword)
                        {
                            SqlCeCommand command = new SqlCeCommand("UPDATE LoginFormTable SET Password = '" + HashPassword.HashNewPassword(newPassword) + "' WHERE MedicalStaffId = '" + LoginForm.userIdentity + "'", connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Password updated succesfully!");
                            this.Close();
                        }
                        else if (newPassword != confirmPassword)
                        {
                            MessageBox.Show("New and Confirmation Password must match!");
                            newPasswordTextBox.Text = "";
                            newPasswordTextBox.Focus();
                            confirmTextBox.Text = "";
                        }
                    }
                    else if (password != oldPassword)
                        MessageBox.Show("Old Password and database password must match!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            changingPassword();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
