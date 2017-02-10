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
       // private ListViewColumnSorter lvwColumnSorter;
        ColumnHeader columnheader;

        public AdministratorManagingForm()
        {
            InitializeComponent();
            AdministratorListViewLoad();
        }

        public void AdministratorListViewLoad()
        {
            administratorsListView.View = View.Details;

            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            this.administratorsListView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "First Name";
            this.administratorsListView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Last Name";
            this.administratorsListView.Columns.Add(columnheader);
            foreach (ColumnHeader ch in this.administratorsListView.Columns)
            {
                ch.Width = -2;
            }
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

                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["FirstName"].ToString());
                    item.SubItems.Add(dr["LastName"].ToString());

                    administratorsListView.Items.Add(item);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void saveAdministratorButton_Click(object sender, EventArgs e)
        {

            SqlCeCommand command = new SqlCeCommand("INSERT INTO Administrator(FirstName, LastName) VALUES ('" + firstNameTextBox.Text +  "','" + lastNameTextBox.Text + "')", connection);
            command.ExecuteReader();
        }

        private void addNewAdministratorButton_Click(object sender, EventArgs e)
        {
            descriptionLabel1.Visible = true;
            descriptionLabel2.Visible = true;
            descriptionLabel3.Visible = true;
            firstNameTextBox.Visible = true;
            lastNameTextBox.Visible = true;
            saveAdministratorButton.Visible = true;
        }

        private void deleteAdministratorButton_Click(object sender, EventArgs e)
        {

            // not working properly, nedd to be fixed :D 
            /*
            string full = administratorsListView.SelectedItems.ToString();
            DialogResult result = MessageBox.Show("Do you want to delete him?", "Delete?", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Administrator where Id = " + int.Parse(full.Substring(0, full.IndexOf(' '))) + ";";

                cmd.ExecuteNonQuery();
                

            }
            else
            {

            }*/
        }
    }
}
