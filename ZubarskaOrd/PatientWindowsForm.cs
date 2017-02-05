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
        

        private void button3_Click(object sender, EventArgs e)
        {

            PatientList.Items.Clear();

            SqlCeCommand cm = new SqlCeCommand("SELECT * FROM Patients ORDER BY FirstName", connection);
            try
            {
                SqlCeDataReader dr = cm.ExecuteReader();

                while(dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["FirstName"].ToString());
                    item.SubItems.Add(dr["LastName"].ToString());
                    item.SubItems.Add(dr["DateOfBirth"].ToString());
                    item.SubItems.Add(dr["JMBG"].ToString());
                    item.SubItems.Add(dr["Contact"].ToString());
                    item.SubItems.Add(dr["Address"].ToString());
                    item.SubItems.Add(dr["CitiesID"].ToString());

                    PatientList.Items.Add(item);


                }
                 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPatientForm AddPatientForm = new AddPatientForm();
            DialogResult addresult = AddPatientForm.ShowDialog();
        }
    }
    }
