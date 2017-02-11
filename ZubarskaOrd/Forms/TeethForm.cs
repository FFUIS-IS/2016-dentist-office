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
    public partial class TeethForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        private static SqlCeCommand command = new SqlCeCommand("", connection);
        private static SqlCeDataReader reader;

        int patient;
        public TeethForm(string patientID)
        {
            Console.Out.WriteLine(patientID);
            patient = int.Parse(patientID);
            InitializeComponent();
        }

        private void TeethForm_Load(object sender, EventArgs e)
        {
            UpdateButtons();
            
         }

        private void UpdateButtons()
        {
            foreach (var tc in this.Controls)
            {
                if (tc is TabControl)
                {
                    foreach (TabPage tp in ((TabControl)tc).Controls)
                        foreach (Button b in ((TabPage)tp).Controls)
                            setButton(b);
                }
            }
        }
        private void setButton(Button button)
        {
            Console.Out.WriteLine("SELECT " + button.Name + " FROM Patients WHERE ID = "
                + patient + ";");
            try
            {
                command.CommandText = "SELECT " + button.Name + " FROM Patients WHERE ID = "
                + patient + ";";
                Console.Out.WriteLine("SELECT " + button.Name + " FROM Patients WHERE ID = "
                    + patient + ";");
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.GetInt32(0) == 0)
                    {
                        button.BackColor = Color.White;
                    }
                    else if (reader.GetSqlInt32(0) == 1)
                    {
                        button.BackColor = Color.Red;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }
            }
            catch(SqlCeException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

    }
}
