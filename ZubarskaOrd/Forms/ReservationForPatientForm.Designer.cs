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
            this.zeroPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.ReservationDateTime = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.interventionDetails = new System.Windows.Forms.RichTextBox();
            this.reservateButton = new System.Windows.Forms.Button();
            this.toothOnFocusComboBox = new System.Windows.Forms.ComboBox();
            this.toothNameLabel = new System.Windows.Forms.Label();
            this.resDetailLabel = new System.Windows.Forms.Label();
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
            this.reservationDataGrid.Location = new System.Drawing.Point(31, 56);
            this.reservationDataGrid.Name = "reservationDataGrid";
            this.reservationDataGrid.ReadOnly = true;
            this.reservationDataGrid.Size = new System.Drawing.Size(384, 212);
            this.reservationDataGrid.TabIndex = 0;
            this.reservationDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationDataGrid_CellDoubleClick);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(1, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "08:00-09:00";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(1, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "09:00-10:00";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(1, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "10:00-11:00";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(1, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "11:00-12:00";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox5.Location = new System.Drawing.Point(0, 165);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(73, 23);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "12:00-13:00";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox6.Location = new System.Drawing.Point(0, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "13:00-14:00";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox7.Location = new System.Drawing.Point(1, 209);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(72, 23);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "14:00-15:00";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox8.Location = new System.Drawing.Point(2, 231);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(71, 23);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "15:00-16:00";
            // 
            // ReservationDateTime
            // 
            this.ReservationDateTime.Location = new System.Drawing.Point(31, 12);
            this.ReservationDateTime.Name = "ReservationDateTime";
            this.ReservationDateTime.Size = new System.Drawing.Size(200, 20);
            this.ReservationDateTime.TabIndex = 10;
            this.ReservationDateTime.ValueChanged += new System.EventHandler(this.ReservationDateTime_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(529, 256);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // interventionDetails
            // 
            this.interventionDetails.Enabled = false;
            this.interventionDetails.Location = new System.Drawing.Point(520, 60);
            this.interventionDetails.Name = "interventionDetails";
            this.interventionDetails.Size = new System.Drawing.Size(200, 194);
            this.interventionDetails.TabIndex = 12;
            this.interventionDetails.Text = "";
            this.interventionDetails.Visible = false;
            // 
            // reservateButton
            // 
            this.reservateButton.Location = new System.Drawing.Point(520, 279);
            this.reservateButton.Name = "reservateButton";
            this.reservateButton.Size = new System.Drawing.Size(200, 95);
            this.reservateButton.TabIndex = 13;
            this.reservateButton.Text = "Reservate";
            this.reservateButton.UseVisualStyleBackColor = true;
            // 
            // toothOnFocusComboBox
            // 
            this.toothOnFocusComboBox.FormattingEnabled = true;
            this.toothOnFocusComboBox.Items.AddRange(new object[] {
            "UL1",
            "UL2",
            "UL3",
            "UL4",
            "UL5",
            "UL6",
            "UL7",
            "UL8",
            "UR1",
            "UR2",
            "UR3",
            "UR4",
            "UR5",
            "UR6",
            "UR7",
            "UR8",
            "DL1",
            "DL2",
            "DL3",
            "DL4",
            "DL5",
            "DL6",
            "DL7",
            "DL8",
            "DR1",
            "DR2",
            "DR3",
            "DR4",
            "DR5",
            "DR6",
            "DR7",
            "DR8"});
            this.toothOnFocusComboBox.Location = new System.Drawing.Point(31, 318);
            this.toothOnFocusComboBox.Name = "toothOnFocusComboBox";
            this.toothOnFocusComboBox.Size = new System.Drawing.Size(121, 21);
            this.toothOnFocusComboBox.TabIndex = 14;
            // 
            // toothNameLabel
            // 
            this.toothNameLabel.AutoSize = true;
            this.toothNameLabel.Location = new System.Drawing.Point(28, 302);
            this.toothNameLabel.Name = "toothNameLabel";
            this.toothNameLabel.Size = new System.Drawing.Size(64, 13);
            this.toothNameLabel.TabIndex = 15;
            this.toothNameLabel.Text = "Tooth name";
            // 
            // resDetailLabel
            // 
            this.resDetailLabel.AutoSize = true;
            this.resDetailLabel.Location = new System.Drawing.Point(517, 44);
            this.resDetailLabel.Name = "resDetailLabel";
            this.resDetailLabel.Size = new System.Drawing.Size(97, 13);
            this.resDetailLabel.TabIndex = 16;
            this.resDetailLabel.Text = "Reservation details";
            // 
            // ReservationForPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 386);
            this.Controls.Add(this.resDetailLabel);
            this.Controls.Add(this.toothNameLabel);
            this.Controls.Add(this.toothOnFocusComboBox);
            this.Controls.Add(this.reservateButton);
            this.Controls.Add(this.interventionDetails);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ReservationDateTime);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reservationDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReservationForPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReservationForPatientForm";
            this.Load += new System.EventHandler(this.ReservationForPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeroPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdPart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker ReservationDateTime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox interventionDetails;
        private System.Windows.Forms.Button reservateButton;
        private System.Windows.Forms.ComboBox toothOnFocusComboBox;
        private System.Windows.Forms.Label toothNameLabel;
        private System.Windows.Forms.Label resDetailLabel;
    }
}