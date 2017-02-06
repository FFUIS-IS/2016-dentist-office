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
    public partial class PatientWindowsForm : Form
    {

        public PatientWindowsForm()
        {
            InitializeComponent();
            loadpatients();
        }

        private void loadpatients()
        {
            fillingcombobox1();
        }
        
        private void fillingcombobox1()
        {

            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            comboBox1.Items.Clear();
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Patients";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["FirstName"].ToString() + " " + dr["LastName"].ToString());
                
            }
            connection.Close();
            
        }

        private void clearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
       
         

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            AddPatientForm AddPatientForm = new AddPatientForm();
            DialogResult addresult = AddPatientForm.ShowDialog();
        }

        

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Patients where FirstName + ' ' + LastName='" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
            fillingcombobox1();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Patients where FirstName + ' ' + LastName='" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["FirstName"].ToString();
                textBox2.Text = dr["LastName"].ToString();
                textBox3.Text = dr["DateOfBirth"].ToString();
                textBox4.Text = dr["JMBG"].ToString();
                textBox5.Text = dr["Contact"].ToString();
                textBox6.Text = dr["Address"].ToString();
                textBox7.Text = dr["CitiesID"].ToString();
            }
            connection.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Patients set FirstName = '" + textBox1.Text + "',LastName='" + textBox2.Text + "',DateOfBirth= '" + textBox3.Text + "', JMBG = '" + textBox4.Text + "', Contact = '" + textBox5.Text + "', Address = '" + textBox6.Text + "', CitiesID = '" + textBox7.Text + "' where FirstName='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
            fillingcombobox1();
            MessageBox.Show("Record is updated successfully!");
            clearTextBox();
        }
    }
}
    
