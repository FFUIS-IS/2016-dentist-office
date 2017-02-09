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
using ZubarskaOrd.Models;

namespace ZubarskaOrd.Forms
{
    public partial class AdministratorManagingForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public AdministratorManagingForm()
        {
            InitializeComponent();
        }

       

        private void refreshAdminListViewButton_Click(object sender, EventArgs e)
        {
            administratorsListView.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM Administrator ORDER BY FirstName", connection);

            try
            {
                SqlCeDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["FirstName"].ToString());
                    item.SubItems.Add(dr["LastName"].ToString());

                    administratorsListView.Items.Add(item);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void newAdministratorButton_Click(object sender, EventArgs e)
        {

            SqlCeCommand command = new SqlCeCommand("INSERT INTO Administrator(FirstName, LastName) VALUES ('" + firstNameTextBox.Text +  "','" + lastNameTextBox.Text + "')", connection);
            command.ExecuteReader();
        }
    }
}
