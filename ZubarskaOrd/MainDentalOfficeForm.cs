using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZubarskaOrd
{
    public partial class DentalOfficeForm : Form
    {
        public DentalOfficeForm()
        {
            InitializeComponent();
            

        }

        private void Patient_Click(object sender, EventArgs e)
        {
            PatientWindowsForm patientForm = new PatientWindowsForm();
            DialogResult presult = patientForm.ShowDialog();
        }

        private void DentalOfficeForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.Cancel)
                this.Close();
            
        }
    }
}
