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


namespace ZubarskaOrd
{
    public partial class AddPatientForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public AddPatientForm()
        {
            InitializeComponent();
        }

        

        private void AddPatientForm_Shown(object sender, EventArgs e)
        {
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
                    CityNameComboBox.Items.Add(dr["CityName"]);
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
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id from Cities where CityName ='" + CityNameComboBox.SelectedItem.ToString() + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cmd = new SqlCeCommand( "INSERT INTO Patients (FirstName, LastName, DateOfBirth, JMBG, Contact, Address, CitiesID) VALUES ('" + FirstNameBox.Text + "','" + LastNameBox.Text + "','" + convert(dobTimePicker.Value.Date) + "','" + JMBGBox.Text + "','" + ContactBox.Text + "','" + AddressBox.Text + "','" + reader.GetInt32(0) + "')", connection);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Insert is updated successfully!");
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