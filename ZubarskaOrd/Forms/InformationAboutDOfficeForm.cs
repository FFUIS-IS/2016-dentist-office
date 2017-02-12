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
    public partial class InformationAboutDOfficeForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        ColumnHeader columnheader;


        public InformationAboutDOfficeForm()
        {
            InitializeComponent();
        }

        private void refreshingInfoList()
        {
            informationListView.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM DentistOffice ORDER BY Id", connection);

            try
            {
                SqlCeDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["OfficeName"].ToString());
                    item.SubItems.Add(dr["Address"].ToString());


                    informationListView.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void InformationAboutDOfficeForm_Load(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void loadInfo()
        {
            informationListView.View = View.Details;

            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            this.informationListView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = " Office Name";
            this.informationListView.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Address";
            this.informationListView.Columns.Add(columnheader);

            foreach (ColumnHeader ch in this.informationListView.Columns)
            {
                ch.Width = -2;
            }
            refreshingInfoList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCeCommand command = new SqlCeCommand("INSERT INTO DentistOffice(OfficeName, Address) VALUES ('" + nameTextBox.Text + "','" + addressTextBox.Text + "')", connection);
            command.ExecuteReader();
            MessageBox.Show("New Info about Dental Office successfully added to database!");
            refreshingInfoList();
            clearingTextBoxes();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete selected Info about Office?", "Delete?", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM DentistOffice where Id = " + int.Parse(informationListView.SelectedItems[0].Text) + ";";

                cmd.ExecuteNonQuery();
                refreshingInfoList();

            }
            else
            {

            }
        }

        private void clearingTextBoxes()
        {
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            nameTextBox.Focus();
        }
    }
}
