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
/*Reyervacija Zaric >D 
nova forma, datagrid, bojenje celija u yavisnosti od dostupnosti termina*/


namespace ZubarskaOrd.Forms
{
    public partial class TeethForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        private static SqlCeCommand command = new SqlCeCommand("", connection);
        private static SqlCeDataReader reader;

        int patient;
        public TeethForm(string patientID)
        {
            patient = int.Parse(patientID);
            InitializeComponent();
        }

        private void TeethForm_Load(object sender, EventArgs e)
        {
            UpdateButtons();

        }

        private void UpdateButtons()
        {
            foreach (var tc in this.Controls)
            {
                if (tc is TabControl)
                {
                    foreach (TabPage tp in ((TabControl)tc).Controls)
                        foreach (Button b in ((TabPage)tp).Controls)
                            setButton(b);
                }
            }
        }
        private void setButton(Button button)
        {
            try
            {
                command.CommandText = "SELECT " + button.Name + " FROM Patients WHERE ID = "
                + patient + ";";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.GetInt32(0) == 0)
                    {
                        button.BackColor = Color.White;
                    }
                    else if (reader.GetSqlInt32(0) == 1)
                    {
                        button.BackColor = Color.Red;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }
            }
            catch (SqlCeException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {


            teethInfoDataGrid.Rows.Clear();
            SqlCeCommand ReserveCommand = new SqlCeCommand("", connection);
            SqlCeDataReader ReserveReader;
            string teethName = ((Button)sender).Name + patient;
            command.CommandText = "SELECT * FROM Interventions_Teeth WHERE TeethID = '" + teethName + "';";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReserveCommand.CommandText = "SELECT * FROM Intervetions WHERE Id = " + reader.GetInt32(1) + ";";
                ReserveReader = ReserveCommand.ExecuteReader();
                ReserveReader.Read();
                DateTime dateOfIntervention = ReserveReader.GetDateTime(1);
                ReserveCommand.CommandText = "SELECT * FROM MedicalStaff WHERE Id = " + ReserveReader.GetInt32(2) + ";";
                ReserveReader = ReserveCommand.ExecuteReader();
                ReserveReader.Read();
                string medicalStaffName = ReserveReader.GetString(1) + " " + ReserveReader.GetString(2);
                ReserveCommand.CommandText = "SELECT * FROM Items WHERE InterventionsID = " + reader.GetInt32(1) + ";";
                ReserveReader = ReserveCommand.ExecuteReader();
                ReserveReader.Read();

                ReserveCommand.CommandText = "SELECT * FROM Services WHERE Id = " + ReserveReader.GetInt32(3) + ";";
                ReserveReader = ReserveCommand.ExecuteReader();
                ReserveReader.Read();
                string serviceName = ReserveReader.GetString(1);
                int serviceDuration = ReserveReader.GetInt32(2);
                DataGridViewRow row;
                teethInfoDataGrid.AllowUserToAddRows = true;
                row = (DataGridViewRow)teethInfoDataGrid.Rows[0].Clone();
                    row = (DataGridViewRow)teethInfoDataGrid.Rows[0].Clone();
                row.Cells[0].Value = "" + dateOfIntervention.ToShortDateString();
                row.Cells[1].Value = medicalStaffName ;
                row.Cells[2].Value = serviceName;
                row.Cells[3].Value = serviceDuration;
               // teethInfoDataGrid.Rows.Add(row);
              
                teethInfoDataGrid.AllowUserToAddRows = false;
                
            }
        }

        private void makeReservationButton_Click(object sender, EventArgs e)
        {
            ReservationForPatientForm reservationForm = new ReservationForPatientForm();
            reservationForm.ShowDialog();
        }
    }
}
