namespace ZubarskaOrd.Forms
{
    partial class ReservationForPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForPatientForm));
            this.reservationDataGrid = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.zeroPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationDataGrid
            // 
            this.reservationDataGrid.AllowUserToDeleteRows = false;
            this.reservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zeroPart,
            this.firstPart,
            this.secondPart,
            this.thirdPart});
            this.reservationDataGrid.Location = new System.Drawing.Point(12, 23);
            this.reservationDataGrid.Name = "reservationDataGrid";
            this.reservationDataGrid.ReadOnly = true;
            this.reservationDataGrid.Size = new System.Drawing.Size(482, 215);
            this.reservationDataGrid.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(40, 220);
            this.listBox1.TabIndex = 1;
            // 
            // zeroPart
            // 
            this.zeroPart.HeaderText = "00-15";
            this.zeroPart.Name = "zeroPart";
            this.zeroPart.ReadOnly = true;
            this.zeroPart.Width = 80;
            // 
            // firstPart
            // 
            this.firstPart.HeaderText = "15-30";
            this.firstPart.Name = "firstPart";
            this.firstPart.ReadOnly = true;
            this.firstPart.Width = 80;
            // 
            // secondPart
            // 
            this.secondPart.HeaderText = "30-45";
            this.secondPart.Name = "secondPart";
            this.secondPart.ReadOnly = true;
            this.secondPart.Width = 80;
            // 
            // thirdPart
            // 
            this.thirdPart.HeaderText = "45-60";
            this.thirdPart.Name = "thirdPart";
            this.thirdPart.ReadOnly = true;
            this.thirdPart.Width = 80;
            // 
            // ReservationForPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 386);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.reservationDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReservationForPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReservationForPatientForm";
            this.Load += new System.EventHandler(this.ReservationForPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationDataGrid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeroPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdPart;
    }
}