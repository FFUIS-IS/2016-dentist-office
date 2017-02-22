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
using System.Data.SqlServerCe;

namespace ZubarskaOrd
{
    public partial class DentalOfficeForm : Form
    {
        private string ooo;
        public static int userIdentity;
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public DentalOfficeForm()
        {
            InitializeComponent();

            timer1.Start();

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.dateTimeLabel.Text = dateTime.ToString();
        }

        private void fillingFormLabels()
        {
            officeNameLabel.Text = ooo;
        }

        private void DentalOfficeForm_Load(object sender, EventArgs e)
        {
            loginLogoutFunction();
            fillingFormLabels();
        }

        private void loginLogoutFunction()
        {
            Opacity = 0;
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();
            ooo = Office.Name;
            userIdentity = LoginForm.userIdentity;
            Opacity = 1;
            if (User.IsAdminUser)
            {
                administratorMenuStrip.Visible = true;
                regularUserMenuStrip.Visible = false;
                SqlCeCommand cm = new SqlCeCommand("SELECT FirstName, LastName FROM Administrator WHERE Id = '" + userIdentity + "'", connection);

                try
                {
                    SqlCeDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        nameLabel.Text = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
                    }
                    dr.Close();
                    dr.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!User.IsAdminUser)
            {
                administratorMenuStrip.Visible = false;
                regularUserMenuStrip.Visible = true; SqlCeCommand cm = new SqlCeCommand("SELECT FirstName, LastName FROM MedicalStaff WHERE Id = '" + userIdentity + "'", connection);

                try
                {
                    SqlCeDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        nameLabel.Text = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
                    }
                    dr.Close();
                    dr.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginLogoutFunction();
            fillingFormLabels();
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

        private void listOfAllMStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicalStuffForm medicalSForm = new MedicalStuffForm();
            medicalSForm.ShowDialog();
        }

        private void addNewCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitiesForm cform = new CitiesForm();
            cform.ShowDialog();
        }
        
        private void listOfAllServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();
            addServiceForm.ShowDialog();
        }

        private void listOfAllDOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationAboutDOfficeForm infoForm = new InformationAboutDOfficeForm();
            infoForm.ShowDialog();
        }

        private void listOfDailyReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ReservationForPatientForm1 interventionForm = new ReservationForPatientForm1();
            interventionForm.ShowDialog();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientForm AddPatientForm = new AddPatientForm();
            DialogResult addresult = AddPatientForm.ShowDialog();
        }

        private void addMedicalStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicalStaffForm addMSForm = new AddMedicalStaffForm();
            addMSForm.ShowDialog();
        }

        private void DentalOfficeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbConnection.Instance.Connection.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChangingForm passForm = new PasswordChangingForm();
            passForm.ShowDialog();
        }

        private void managePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChangigFormStaff passStaffForm = new PasswordChangigFormStaff();
            passStaffForm.ShowDialog();
        }
    }
}
