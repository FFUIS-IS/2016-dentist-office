using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace ZubarskaOrd.Forms
{
    public partial class InterventionForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        private static SqlCeCommand command = new SqlCeCommand("", connection);
        private static SqlCeDataReader reader;

        int patient;
        public InterventionForm(int patientID)
        {
            patient = patientID;
            InitializeComponent();
        }

        private void InterventionForm_Load(object sender, EventArgs e)
        {
            command.CommandText = "SELECT * FROM Services;";
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                serviceTypeComboBox.Items.Add(reader.GetString(1));
            }
        }

        private void serviceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            listOfAppointment.Visible = true;
            timeOfInterventionDatePicker.Visible = true;
         //   refreshListOfAppointments();
        }

        private void timeOfInterventionDatePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshListOfAppointments();
        }
        private void refreshListOfAppointments()
        {
            listOfAppointment.Items.Clear();
            command.CommandText = "SELECT * FROM Services WHERE ServiceName = '" 
                + serviceTypeComboBox.SelectedItem.ToString() + "';";
            reader = command.ExecuteReader();
            reader.Read();
            int duration = reader.GetInt32(2);
            for (int i = 8; i < 16; i++)
                for (int minute = 0; minute < 60; minute += 15) 
                listOfAppointment.Items.Add(convertTime(i, minute));

            command.CommandText = "SELECT StartTime, EndTime,  resDuration FROM Reservations WHERE StartTime >= '"
                  + parse(timeOfInterventionDatePicker.Value.Date) + "' AND "
                  + " EndTime <= '" + parse(timeOfInterventionDatePicker.Value.Date.AddDays(1)) + "';";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int reservationDuration = reader.GetInt32(2);
                    string startTime = reader.GetDateTime(0).Hour + ":" + ((reader.GetDateTime(0).Minute < 10) ? ("0" + reader.GetDateTime(0).Minute) : ("" + reader.GetDateTime(0).Minute));
                     int index = -1;
                    for (int counter  = 0; counter < listOfAppointment.Items.Count; counter++)
                        if(listOfAppointment.Items[counter].ToString().Substring(0, 5).Equals(startTime))
                        {
                            index = counter;
                            break;
                        }
                    
                    if(index != -1)
                        for (int counter = 0; counter < reservationDuration/15; counter++)
                        {
                            listOfAppointment.Items.RemoveAt(index);
                        }
                }
            }
            catch(SqlCeException ee)
            {
                Console.Out.WriteLine(ee.ToString());
            }    
        }
        private string parse(DateTime time)
        {
            string month = (time.Month < 10) ? ("0" + time.Month) : ("" + time.Month);
            string day = (time.Day < 10) ? ("0" + time.Day) : ("" + time.Day);
            return "" + time.Year + "-" + month + "-" + day;
        }
        private string convertTime(int hour,int  minute)
        {
            string hourTemp = (hour < 10) ? ("0" + hour) : ("" + hour);
            string minuteTemp = (minute < 10) ? ("0" + minute) : ("" + minute);
            int minuteRight = (minute == 45) ? (0) : (minute + 15);
            int hourRight = (minuteRight == 0) ? (hour + 1) : (hour);
            string minuteString = (minuteRight < 10) ? ("0" + minuteRight) : ("" + minuteRight);
            string hourString = (hourRight < 10) ? ("0" + hourRight) : ("" + hourRight);
            return hourTemp + ":" + minuteTemp + " - " + hourString + ":" + minuteString; 
        }
    }
}
