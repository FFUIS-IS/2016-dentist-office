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
using ZubarskaOrd.Forms;

namespace ZubarskaOrd
{
    public partial class DentalOfficeForm : Form
    {
        public DentalOfficeForm()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;


        }

        private void DentalOfficeForm_Load(object sender, EventArgs e)
        {
            funkcija();
        }

        private void funkcija()
        {
            Opacity = 0;
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();
            Opacity = 1;
            if (User.IsAdminUser)
            {
                 administratorMenuStrip.Visible = true;
                 regularUserMenuStrip.Visible = false;

            }
            else if (!User.IsAdminUser)
            {
                administratorMenuStrip.Visible = false;
                regularUserMenuStrip.Visible = true;
            }

            if (result == DialogResult.Cancel)
                this.Close();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            funkcija();
        }

        private void listOfAllAdministratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministratorManagingForm adminNewForm = new AdministratorManagingForm();
            adminNewForm.ShowDialog();
        }

        private void patientsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientWindowsForm patientForm = new PatientWindowsForm();
            patientForm.ShowDialog();
        }
        
    }
}
