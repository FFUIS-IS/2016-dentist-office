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
        ColumnHeader columnheader;

        public AdministratorManagingForm()
        {
            InitializeComponent();
            AdministratorListViewLoad();
            refreshingListView();
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

        private void refreshingListView()
        {
            administratorsListView.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM Administrator ORDER BY Id", connection);

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

        private void refreshAdminListViewButton_Click(object sender, EventArgs e)
        {
            refreshingListView();
        }

        private void saveAdministratorButton_Click(object sender, EventArgs e)
        {

            SqlCeCommand command = new SqlCeCommand("INSERT INTO Administrator(FirstName, LastName) VALUES ('" + firstNameTextBox.Text +  "','" + lastNameTextBox.Text + "')", connection);
            command.ExecuteReader();
            command.CommandText = "SELECT MAX(Id) FROM Administrator;";
            SqlCeDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                command.CommandText = "INSERT INTO LoginFormTable(username, password,AdministratorID) VALUES ('" + newUsernameTextBox.Text + "','" + newPasswordTextBox.Text + "'," + reader.GetInt32(0) + ");";
                command.ExecuteNonQuery();
            }
            MessageBox.Show("New Admin successfully added to database!");
            resetingTextBoxes();
            hidingAddAdminOptions();
            refreshingListView();
        }

        private void resetingTextBoxes()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            firstNameTextBox.Focus();
        }

        private void showingAddAdminOptions()
        {
            descriptionLabel1.Visible = true;
            descriptionLabel2.Visible = true;
            descriptionLabel3.Visible = true;
            firstNameTextBox.Visible = true;
            lastNameTextBox.Visible = true;
            saveAdministratorButton.Visible = true;
        }
        
        private void hidingAddAdminOptions()
        {
            descriptionLabel1.Visible = false;
            descriptionLabel2.Visible = false;
            descriptionLabel3.Visible = false;
            firstNameTextBox.Visible = false;
            lastNameTextBox.Visible = false;
            saveAdministratorButton.Visible = false;
        }

        private void addNewAdministratorButton_Click(object sender, EventArgs e)
        {
            showingAddAdminOptions();
        }

        private void deleteAdministratorButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to delete him?", "Delete?", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Administrator where Id = " + int.Parse(administratorsListView.SelectedItems[0].Text) + ";";

                cmd.ExecuteNonQuery();
                refreshingListView();



            }
            else
            {

            }
        }
    }
}
