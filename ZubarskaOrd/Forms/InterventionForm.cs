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
    public partial class ReservationForPatientForm1 : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        private static SqlCeCommand command = new SqlCeCommand("", connection);
        private static SqlCeDataReader reader;

        public ReservationForPatientForm1()
        {
            InitializeComponent();
            FillDataGrid();
            ReservationDateTime.MinDate = DateTime.Today;
        }

        private void FillDataGrid()
        {

            DataGridViewRow row;
            reservationDataGrid.AllowUserToAddRows = true;
            reservationDataGrid.Rows.Clear();
            for (int rows = 0; rows < 8; rows++)
            {
                row = (DataGridViewRow)reservationDataGrid.Rows[0].Clone();
                row.Cells[0].Value = "";
                row.Cells[0].Style.BackColor = Color.Green;
                row.Cells[1].Value = "";
                row.Cells[1].Style.BackColor = Color.Green;
                row.Cells[2].Value = "";
                row.Cells[2].Style.BackColor = Color.Green;
                row.Cells[3].Value = "";
                row.Cells[3].Style.BackColor = Color.Green;
                reservationDataGrid.Rows.Add(row);

            }

            reservationDataGrid[0, 2].Style.BackColor = Color.Black;
            reservationDataGrid[1, 2].Style.BackColor = Color.Black;

            reservationDataGrid.AllowUserToAddRows = false;

        }

        private void ReservationForPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void ReservationDateTime_ValueChanged(object sender, EventArgs e)
        {
            FillDataGrid();
            command.CommandText = "SELECT StartTime, EndTime,  resDuration FROM Reservations WHERE StartTime >= '"
                + parse(ReservationDateTime.Value.Date) + "' AND "
                + " EndTime <= '" + parse(ReservationDateTime.Value.Date.AddDays(1)) + "';";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int reservationDuration = reader.GetInt32(2);
                int startTimeHour = reader.GetDateTime(0).Hour;
                int tempTimeHour = startTimeHour;

                int startTimeMinute = reader.GetDateTime(0).Minute;
                int tempTimeMinute = startTimeMinute;
                reservationDataGrid[tempTimeMinute / 15, tempTimeHour - 8].Style.BackColor = Color.Red;
                for (int count = 1; count < reservationDuration / 15; count++)
                {
                    while (tempTimeMinute + 15 > 59)
                    {
                        tempTimeMinute -= 60;
                        tempTimeHour++;
                    }
                    tempTimeMinute += 15;

                    if (tempTimeMinute / 15 < 4 && tempTimeHour < 16)
                        reservationDataGrid[tempTimeMinute / 15, tempTimeHour - 8].Style.BackColor = Color.Red;
                }
            }
        }

        private void reservationDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            interventionDetailsRichTextBox.Clear();
            if (reservationDataGrid[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.Red)
            {
                interventionDetailsRichTextBox.Visible = true;
                command.CommandText = "SELECT * FROM Reservations WHERE "
                    + " datediff(mi, StartTime, '" + parse(ReservationDateTime.Value.Date) + " " + convertTime(e.RowIndex + 8, e.ColumnIndex * 15) + "') >= 0;";
                try
                {
                    reader = command.ExecuteReader();
                    reader.Read();
                    command.CommandText = "SELECT FirstName, LastName FROM Patients WHERE Id = " + reader.GetInt32(2) + ";";
                    SqlCeDataReader reserveReader = command.ExecuteReader();
                    reserveReader.Read();
                    interventionDetailsRichTextBox.Text += "Patient Name: " + reserveReader.GetString(0) + " " + reserveReader.GetString(1) + "\n";

                }
                catch (SqlCeException ee)
                {
                    Console.Out.WriteLine(ee.ToString());
                }
            }
            else

                interventionDetailsRichTextBox.Visible = false;
        }
        private string parse(DateTime time)
        {
            string month = (time.Month < 10) ? ("0" + time.Month) : ("" + time.Month);
            string day = (time.Day < 10) ? ("0" + time.Day) : ("" + time.Day);
            return time.Year + "-" + month + "-" + day;
        }

        private string convertTime(int hour, int minute)
        {
            string hourTemp = (hour < 10) ? ("0" + hour) : ("" + hour);
            string minuteTemp = (minute < 10) ? ("0" + minute) : ("" + minute);

            return hourTemp + ":" + minuteTemp + ":00";
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                reservationButton.Enabled = true;
            else
                reservationButton.Enabled = false;
        }
    }
}
