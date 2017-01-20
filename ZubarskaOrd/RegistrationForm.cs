using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZubarskaOrd.Models;
using ZubarskaOrd.Repos;

namespace ZubarskaOrd
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }


        private void CancelRegButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            
                User user = new User(usernameRegTextBox.Text, passwordRegTextBox.Text);

                UserRepository.Register(user);
                DialogResult = DialogResult.OK;
                Close();
               
        }
    }
}
