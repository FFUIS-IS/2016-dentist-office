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
                    comboBox1.Items.Add(dr["CityName"]);
                }
                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Patients values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'," + comboBox1.SelectedItem;
            cmd.ExecuteNonQuery();
            connection.Close();
        }*/
    }
}
