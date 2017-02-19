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
        private enum toolUsed { serviceType, dateOfReservation, timeOfReservation, toothName};
        private string[] dataInRichText = {"Patient name: ",  "Service type: ", "Date of reservation: ",
            "Time of reservation: ", "Tooth name: "};

        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        private static SqlCeCommand command = new SqlCeCommand("", connection);
        private static SqlCeDataReader reader;

        int patient;
        public InterventionForm(int patientID)
        {
            patient = patientID;
            InitializeComponent();
            timeOfInterventionDatePicker.MinDate = DateTime.Today;
            command.CommandText = "SELECT FirstName, LastName FROM Patients WHERE id = " + patient + ";";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                dataInRichText[0] = "Patient Name: " + reader.GetString(0) + " " + reader.GetString(1);
                reservationDetails.Text = dataInRichText[0];
            }
            else
                MessageBox.Show("Error occured trying to choose patient!");
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
             refreshListOfAppointments();
             addToRichTextBox(serviceTypeComboBox.SelectedItem.ToString(), toolUsed.serviceType);
        }

        private void addToRichTextBox(string text, toolUsed tool)
        {
            reservationDetails.Clear();
            if (tool == toolUsed.serviceType)
                dataInRichText[1] = "Service Type: " + text;
            else if (tool == toolUsed.dateOfReservation)
                dataInRichText[2] = "Date of reservation: " + text;
            else if (tool == toolUsed.timeOfReservation)
                dataInRichText[3] = "Time of reservation: " + calculateTimeOfReservation(text.Substring(0, 5), serviceTypeComboBox.SelectedItem.ToString());
            else if (tool == toolUsed.toothName)
                dataInRichText[4] = "Tooth name: " + text + "\n";
            for (int i = 0; i < 5; i++)
                reservationDetails.Text += dataInRichText[i] + "\n";

        }

        private string calculateTimeOfReservation(string startTime, string serviceName)
        {
            command.CommandText = "SELECT ServiceDuration FROM Services WHERE ServiceName = '" +
                serviceName + "';";
            reader = command.ExecuteReader();
            int duration = -1;
            int hour = int.Parse(startTime.Substring(0, startTime.IndexOf(':')));
            int minute = int.Parse(startTime.Substring(startTime.IndexOf(':') + 1, 2));
            if (reader.Read())
                duration = reader.GetInt32(0);
            if(duration != -1)
            {
                if (duration + minute > 59)
                {
                    hour++;
                    minute -= 60;
                }
                minute += duration;
            }
            return (startTime.Substring(0, 5) + " - " + convertTime(hour, minute)).Substring(0, 13);
        }

        private void timeOfInterventionDatePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshListOfAppointments();
            addToRichTextBox(timeOfInterventionDatePicker.Value.ToShortDateString(), toolUsed.dateOfReservation);
        }

        private void refreshListOfAppointments()
        {
            listOfAppointment.Items.Clear();
            if (serviceTypeComboBox.SelectedIndex != -1)
            {
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
                        string startTime = reader.GetDateTime(0).ToShortTimeString();
                        int index = -1;

                        for (int counter = 0; counter < listOfAppointment.Items.Count; counter++)
                            if (listOfAppointment.Items[counter].ToString().Substring(0, 5).Equals(startTime))
                            {
                                index = counter;
                                break;
                            }
                        if (index != -1)
                            for (int counter = 0; counter < reservationDuration / 15; counter++)
                            {
                                listOfAppointment.Items.RemoveAt(index);
                            }
                    }
                }
                catch (SqlCeException ee)
                {
                    Console.Out.WriteLine(ee.ToString());
                }
            }
        }
        private string parse(DateTime time)
        {
            string month = (time.Month < 10) ? ("0" + time.Month) : ("" + time.Month);
            string day = (time.Day < 10) ? ("0" + time.Day) : ("" + time.Day);

            string output = time.Year + "-" + month + "-" + day;
            if(time.Hour < 16 && time.Hour >= 8)
            {
                output += " " + ((time.Hour < 10) ? ("0" + time.Hour) : ("" + time.Hour));
                output += ":" + ((time.Minute < 10) ? ("0" + time.Minute) : ("" + time.Minute));
                output += ":00";
            }

            return output;
        }
        private string convertTime(int hour,int  minute)
        {
            string hourTemp = "" + hour;
            string minuteTemp = (minute < 10) ? ("0" + minute) : ("" + minute);
            int minuteRight = (minute == 45) ? (0) : (minute + 15);
            int hourRight = (minuteRight == 0) ? (hour + 1) : (hour);
            string minuteString = (minuteRight < 10) ? ("0" + minuteRight) : ("" + minuteRight);
            string hourString = "" + hourRight;
            return hourTemp + ":" + minuteTemp + " - " + hourString + ":" + minuteString; 
        }

        private void listOfAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            addToRichTextBox(listOfAppointment.SelectedItem.ToString(), toolUsed.timeOfReservation);
        }

        private void confirmReservation_Click(object sender, EventArgs e)
        {
            if (listOfAppointment.SelectedIndex == -1)
            {
                MessageBox.Show("Error in choosing appointment!");
            }
            else if (serviceTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error in choosing service!");
            }
            else if (toothOnFocusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error in choosing tooth!");
            }
            else
            {
                command.CommandText = "SELECT ID, ServiceDuration FROM Services WHERE ServiceName = '" + serviceTypeComboBox.SelectedItem.ToString() + "';";
                reader = command.ExecuteReader();
                reader.Read();
                string dateOfReservation = parse(timeOfInterventionDatePicker.Value.Date);
                dateOfReservation += " " + listOfAppointment.SelectedItem.ToString().Substring(0, listOfAppointment.SelectedItem.ToString().IndexOf(' ')) + ":00";
                int hour = int.Parse(listOfAppointment.SelectedItem.ToString().Substring(0, listOfAppointment.SelectedItem.ToString().IndexOf(':')));
                int minute = int.Parse(listOfAppointment.SelectedItem.ToString().Substring(listOfAppointment.SelectedItem.ToString().IndexOf(':')+1, 2));
                DateTime tempTime = timeOfInterventionDatePicker.Value.Date;

                if(minute + reader.GetInt32(1) > 60)
                {
                    minute -= 60;
                    hour++;
                }
                minute += reader.GetInt32(1);
                DateTime endTime = new DateTime(tempTime.Year, tempTime.Month, tempTime.Day, hour, minute, 0);
                string endOfReservation = parse(endTime);

                string user = toothOnFocusComboBox.SelectedItem.ToString() + patient;
                command.CommandText = "INSERT INTO Reservations(MedicalStaffID, PatientsID, StartTime, resDuration, ServicesID, endTime) VALUES "
                    + "(" + LoginForm.userIdentity + ", '" + user + "', '" + dateOfReservation + "', " + reader.GetInt32(1) + ", " + reader.GetInt32(0) + ", '" + endOfReservation + "');";
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Reservation is succesfully added!");
                }
                catch (SqlCeException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

        }
        private void toothOnFocusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addToRichTextBox(toothOnFocusComboBox.SelectedItem.ToString(), toolUsed.toothName);
        }
    }
}
