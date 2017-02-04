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
         SqlCeConnection cn = new SqlCeConnection("Data Source=" + Program.path + "Database.sdf; Password=database32");

        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPatientForm_Shown(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

            }
            catch ( SqlCeException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            loadcities();

        }

       

        private void loadcities()
        {
            SqlCeCommand cm = new SqlCeCommand("SELECT CityName FROM Cities ORDER BY CityName ASC", cn);

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

        
    }
}
