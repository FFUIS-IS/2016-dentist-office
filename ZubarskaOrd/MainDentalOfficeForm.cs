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
            /*this.IsMdiContainer = true;
            Form Form2 = new Form();
            Form2.MdiParent = this;
            Form2.Show();*/

            this.IsMdiContainer = true;
            PatientWindowsForm patientForm = new PatientWindowsForm();
            patientForm.MdiParent = this;
            patientForm.Show();
            //DialogResult presult = patientForm.ShowDialog();
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
