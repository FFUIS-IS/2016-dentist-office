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
            // has an error, we need to fix it :D 
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO MedicalStaff (FirstName, LastName, DateOfBirth, JMBG, Contact, Address, CitiesID) VALUES ('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + dobTextBox.Text + "','" + JMBGTextBox.Text + "','" + contactTextBox.Text + "','" + addressTextBox.Text + "','1')";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Insert is updated successfully!");
        }
    }
}
