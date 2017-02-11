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
using System.Data.SqlClient;

namespace ZubarskaOrd.Forms
{
    public partial class CitiesForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
        ColumnHeader columnheader;

        public CitiesForm()
        {
            InitializeComponent();
        }

        private void refreshingCityList()
        {
            CitiesList.Items.Clear();
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM cities ORDER BY Id", connection);

            try
            {
                SqlCeDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["CityName"].ToString());
                    

                    CitiesList.Items.Add(item);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CitiesForm_Load(object sender, EventArgs e)
        {
            loadCities();
        }

        private void loadCities()
        {
            CitiesList.View = View.Details;

            columnheader = new ColumnHeader();
            columnheader.Text = "ID";
            this.CitiesList.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "City";
            this.CitiesList.Columns.Add(columnheader);

            foreach (ColumnHeader ch in this.CitiesList.Columns)
            {
                ch.Width = -2;
            }
            refreshingCityList();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            SqlCeCommand command = new SqlCeCommand("INSERT INTO Cities(CityName) VALUES ('" + citytextbox.Text +  "')", connection);
            command.ExecuteReader();
            MessageBox.Show("New City successfully added to database!");
            refreshingCityList();
            citytextbox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete city?", "Delete?", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                SqlCeCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Cities where Id = " + int.Parse(CitiesList.SelectedItems[0].Text) + ";";

                cmd.ExecuteNonQuery();
                refreshingCityList();



            }
            else
            {

            }
        }
    }
}
