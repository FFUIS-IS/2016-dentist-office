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
    public partial class AddServiceForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        ColumnHeader columnheader;

        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void refreshingServiceList()
        {
            servicesListView.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM Services ORDER BY Id", connection);

            try
            {
                SqlCeDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["ServiceName"].ToString());
                    item.SubItems.Add(dr["ServiceDuration"].ToString());


                    servicesListView.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            loadServices();
        }

        private void loadServices()
        {
            servicesListView.View = View.Details;

            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            this.servicesListView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = " Service Name";
            this.servicesListView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Duration";
            this.servicesListView.Columns.Add(columnheader);

            foreach (ColumnHeader ch in this.servicesListView.Columns)
            {
                ch.Width = -2;
            }
            refreshingServiceList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCeCommand command = new SqlCeCommand("INSERT INTO Services(ServiceName, ServiceDuration) VALUES ('" + serviceNameTextBox.Text + "','" + Int32.Parse(serviceDurationComboBox.SelectedItem.ToString()) +  "')", connection);
            command.ExecuteReader();
            MessageBox.Show("New Service successfully added to database!");
            refreshingServiceList();
            clearingInput();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete service?", "Delete?", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Services where Id = " + int.Parse(servicesListView.SelectedItems[0].Text) + ";";

                cmd.ExecuteNonQuery();
                refreshingServiceList();


            }
            else
            {

            }
        }

        private void clearingInput()
        {
            serviceNameTextBox.Text = "";
            serviceDurationComboBox.ResetText();
            serviceNameTextBox.Focus();
        }
    }
}
