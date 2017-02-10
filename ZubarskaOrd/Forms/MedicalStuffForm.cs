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
    public partial class MedicalStuffForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public MedicalStuffForm()
        {
            InitializeComponent();
            fillinMedicalStaffComboBox();
            fillingCityComboBox();

        }



        private void clearTextBox()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            dobTextBox.Clear();
            JMBGTextBox.Clear();
            addressTextBox.Clear();
            contactTextBox.Clear();
            cityComboBox.ResetText();

        }
        
        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            string full = medicalStuffComboBox.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Do you want to delete him?", "Delete?", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM MedicalStaff where Id =" + Int32.Parse(full.Substring(0, full.IndexOf(' '))) + ";";

                cmd.ExecuteNonQuery();
                
                fillinMedicalStaffComboBox();
                clearTextBox();

            }
            else { }

        }



        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Id FROM Cities WHERE CityName ='" + cityComboBox.SelectedItem.ToString() + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cmd.CommandText = "UPDATE MedicalStaff SET FirstName = '" + firstNameTextBox.Text + "',LastName='" + lastNameTextBox.Text + "',DateOfBirth= '" + dobTextBox.Text + "', JMBG = '" + JMBGTextBox.Text + "', Contact = '" + contactTextBox.Text + "', Address = '" + addressTextBox.Text + "', CitiesID = " + reader.GetInt32(0) + " where FirstName='" + firstNameTextBox.Text + "'";
            cmd.ExecuteNonQuery();

            fillinMedicalStaffComboBox();
            MessageBox.Show("Record is updated successfully!");
            clearTextBox();



        }
        

        private void fillingCityComboBox()
        {
            cityComboBox.Items.Clear();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Cities";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cityComboBox.Items.Add(dr["CityName"].ToString());

            }

        }

        private void fillinMedicalStaffComboBox()
        {
            medicalStuffComboBox.Items.Clear();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM MedicalStaff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                medicalStuffComboBox.Items.Add(dr["Id"].ToString() + " " + dr["FirstName"].ToString() + " " + dr["LastName"].ToString());

            }

        }

        private void medicalStuffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string full = medicalStuffComboBox.SelectedItem.ToString();
            cmd.CommandText = "select * from MedicalStaff where Id='" + full.Substring(0, full.IndexOf(' ')) + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                firstNameTextBox.Text = dr["FirstName"].ToString();
                lastNameTextBox.Text = dr["LastName"].ToString();
                dobTextBox.Text = dr["DateOfBirth"].ToString();
                JMBGTextBox.Text = dr["JMBG"].ToString();
                contactTextBox.Text = dr["Contact"].ToString();
                addressTextBox.Text = dr["Address"].ToString();
                cmd.CommandText = "SELECT CityName FROM Cities WHERE Id = " + dr["CitiesID"] + ";";

                SqlCeDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    cityComboBox.Text = reader.GetString(0);


            }


        }
        

        private void addMStuffButton_Click(object sender, EventArgs e)
        {
            AddMedicalStaffForm addMSForm = new AddMedicalStaffForm();
            addMSForm.ShowDialog();
        }

        private void MedicalStuffForm_Activated(object sender, EventArgs e)
        {

            fillinMedicalStaffComboBox();
            fillingCityComboBox();
        }
    }
}

