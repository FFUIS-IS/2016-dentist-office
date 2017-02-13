using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZubarskaOrd.Forms
{
    public partial class ReservationForPatientForm : Form
    {
        public ReservationForPatientForm()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {

            DataGridViewRow row;
            reservationDataGrid.AllowUserToAddRows = true;
            for (int rows = 0; rows < 8; rows++)
            {
                row = (DataGridViewRow)reservationDataGrid.Rows[0].Clone();
                row.Cells[0].Value = "";
                row.Cells[0].Style.BackColor = Color.Green;
                row.Cells[1].Value = "";
                row.Cells[1].Style.BackColor = Color.Green;
                row.Cells[2].Value = "";
                row.Cells[2].Style.BackColor = Color.Green;
                row.Cells[3].Value = "";
                row.Cells[3].Style.BackColor = Color.Green;
                Console.Out.WriteLine(rows);
                reservationDataGrid.Rows.Add(row);

            }

            reservationDataGrid[0, 2].Style.BackColor = Color.Black;
            reservationDataGrid[1, 2].Style.BackColor = Color.Black;

            reservationDataGrid.AllowUserToAddRows = false;

        }

        private void ReservationForPatientForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
