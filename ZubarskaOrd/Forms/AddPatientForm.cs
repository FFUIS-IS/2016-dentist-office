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
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Patients (FirstName, LastName, DateOfBirth, JMBG, Contact, Address, CitiesID) VALUES ('" + FirstNameBox.Text + "','" + LastNameBox.Text + "','" + DateOfBirthBox.Text + "','" + JMBGBox.Text + "','" + ContactBox.Text + "','" + AddressBox.Text + "','1')";
            cmd.ExecuteNonQuery();
            connection.Close();
            
            MessageBox.Show("Insert is updated successfully!");
           

        }


    }
}
