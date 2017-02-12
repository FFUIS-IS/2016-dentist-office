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
    public partial class AddMedicalStaffForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public AddMedicalStaffForm()
        {
            InitializeComponent();
            loadcities();
        }
        
        private void loadcities()
        {
            SqlCeCommand cm = new SqlCeCommand("SELECT CityName FROM Cities ORDER BY CityName ASC", connection);

            try
            {
                SqlCeDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cityNameComboBox.Items.Add(dr["CityName"]);
                }
                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlCeCommand cmd = new SqlCeCommand("INSERT INTO MedicalStaff (FirstName, LastName, DateOfBirth, JBMG, Contact, Address, CitiesID) VALUES ('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + convert(dobTimePicker.Value.Date) + "','" + JMBGTextBox.Text + "','" + contactTextBox.Text + "','" + addressTextBox.Text + "','1')", connection);
            cmd.ExecuteReader();
            cmd.CommandText = "SELECT MAX(Id) FROM MedicalStaff";
            SqlCeDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmd.CommandText = "INSERT INTO LoginFormTable(username, password,MedicalStaffID) VALUES ('" + newUsernameTextBox.Text + "','" + HashPassword.HashNewPassword(newPasswordTextBox.Text) + "'," + reader.GetInt32(0) + ");";
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("New member succesfully added to Medical Staff!");
            this.Close();
        }
        private string convert(DateTime time)
        {
            string month = (time.Month < 10) ? ("0" + time.Month) : ("" + time.Month);
            string day = (time.Day < 10) ? ("0" + time.Day) : ("" + time.Day);
            return "" + time.Year + "-" + month + "-" + day;
        }
    }
}
