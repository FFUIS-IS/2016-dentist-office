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
           
        }

        

        private void clearTextBox()
        {
            FirstNameBox.Clear();
            LastNameBox.Clear();
            DateOfBirthBox.Clear();
            JMBGBox.Clear();
            AddressBox.Clear();
            ContactBox.Clear();
            CityComboBox.ResetText();
           

        }



        private void AddButton_Click_1(object sender, EventArgs e)
        {
            AddPatientForm AddPatientForm = new AddPatientForm();
            DialogResult addresult = AddPatientForm.ShowDialog();
        }

        

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
             string full = PatientComboBox.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Do you want to delete him?", "Delete?", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
                connection.Open();
                SqlCeCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Patients where Id =" + Int32.Parse(full.Substring(0, full.IndexOf(' '))) + ";";

                cmd.ExecuteNonQuery();

                connection.Close();
                fillingPatientsComboBox();
                clearTextBox();

           }
            else
            {
                
            }



        }



        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id from Cities where CityName ='" + CityComboBox.SelectedItem.ToString() + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cmd.CommandText = "update Patients set FirstName = '" + FirstNameBox.Text + "',LastName='" + LastNameBox.Text + "',DateOfBirth= '" + DateOfBirthBox.Text + "', JMBG = '" + JMBGBox.Text + "', Contact = '" + ContactBox.Text + "', Address = '" + AddressBox.Text + "', CitiesID = " + reader.GetInt32(0) + " where FirstName='" + FirstNameBox.Text + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
            fillingPatientsComboBox();
            MessageBox.Show("Record is updated successfully!");
            clearTextBox();



        }

        private void PatientWindowsForm_Load(object sender, EventArgs e)
        {
        }

        private void fillingCityComboBox()
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            CityComboBox.Items.Clear();
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Cities";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CityComboBox.Items.Add(dr["CityName"].ToString());

            }
            connection.Close();

        }

        private void fillingPatientsComboBox()
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            PatientComboBox.Items.Clear();
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
                PatientComboBox.Items.Add(dr["Id"].ToString()+ " " + dr["FirstName"].ToString() + " " + dr["LastName"].ToString());

            }
            connection.Close();

        }

        private void PatientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string full = PatientComboBox.SelectedItem.ToString();
            cmd.CommandText = "select * from Patients where Id='" + full.Substring(0, full.IndexOf(' ')) + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FirstNameBox.Text = dr["FirstName"].ToString();
                LastNameBox.Text = dr["LastName"].ToString();
                DateOfBirthBox.Text = dr["DateOfBirth"].ToString();
                JMBGBox.Text = dr["JMBG"].ToString();
                ContactBox.Text = dr["Contact"].ToString();
                AddressBox.Text = dr["Address"].ToString();
                cmd.CommandText = "SELECT CityName FROM Cities WHERE Id = " + dr["CitiesID"] + ";";

                SqlCeDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    CityComboBox.Text = reader.GetString(0);


            }

            connection.Close();

        }

        private void PatientWindowsForm_Activated(object sender, EventArgs e)
        {

            fillingPatientsComboBox();
            fillingCityComboBox();
        }
    }
}

    
