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
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

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
            
            comboBox1.Items.Clear();
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
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Patients WHERE FirstName + ' ' + LastName='" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            
            fillingcombobox1();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Patients WHERE FirstName + ' ' + LastName='" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            /*
            var innerGroupJoinQuery =
                from category in categories
                join prod in products on category.ID equals prod.CategoryID into prodGroup
                select new { CategoryName = category.Name, Products = prodGroup };*/

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
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Patients SET FirstName = '" + textBox1.Text + "',LastName='" + textBox2.Text + "',DateOfBirth= '" + textBox3.Text + "', JMBG = '" + textBox4.Text + "', Contact = '" + textBox5.Text + "', Address = '" + textBox6.Text + "', CitiesID = '" + textBox7.Text + "' where FirstName='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            
            fillingcombobox1();
            MessageBox.Show("Record is updated successfully!");
            clearTextBox();
        }

        
    }
}
    
