namespace ZubarskaOrd.Forms
{
    partial class InterventionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterventionForm));
            this.serviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.listOfAppointment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeOfInterventionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toothNameLabel = new System.Windows.Forms.Label();
            this.toothOnFocusComboBox = new System.Windows.Forms.ComboBox();
            this.reservationDetails = new System.Windows.Forms.RichTextBox();
            this.confirmReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serviceTypeComboBox
            // 
            this.serviceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceTypeComboBox.FormattingEnabled = true;
            this.serviceTypeComboBox.Location = new System.Drawing.Point(60, 17);
            this.serviceTypeComboBox.Name = "serviceTypeComboBox";
            this.serviceTypeComboBox.Size = new System.Drawing.Size(182, 21);
            this.serviceTypeComboBox.TabIndex = 1;
            this.serviceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceTypeComboBox_SelectedIndexChanged);
            // 
            // listOfAppointment
            // 
            this.listOfAppointment.FormattingEnabled = true;
            this.listOfAppointment.Location = new System.Drawing.Point(60, 110);
            this.listOfAppointment.Name = "listOfAppointment";
            this.listOfAppointment.Size = new System.Drawing.Size(182, 238);
            this.listOfAppointment.TabIndex = 2;
            this.listOfAppointment.SelectedIndexChanged += new System.EventHandler(this.listOfAppointment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Free appointment";
            // 
            // timeOfInterventionDatePicker
            // 
            this.timeOfInterventionDatePicker.Location = new System.Drawing.Point(60, 56);
            this.timeOfInterventionDatePicker.Name = "timeOfInterventionDatePicker";
            this.timeOfInterventionDatePicker.Size = new System.Drawing.Size(182, 20);
            this.timeOfInterventionDatePicker.TabIndex = 4;
            this.timeOfInterventionDatePicker.ValueChanged += new System.EventHandler(this.timeOfInterventionDatePicker_ValueChanged);
            // 
            // toothNameLabel
            // 
            this.toothNameLabel.AutoSize = true;
            this.toothNameLabel.Location = new System.Drawing.Point(332, 20);
            this.toothNameLabel.Name = "toothNameLabel";
            this.toothNameLabel.Size = new System.Drawing.Size(64, 13);
            this.toothNameLabel.TabIndex = 21;
            this.toothNameLabel.Text = "Tooth name";
            // 
            // toothOnFocusComboBox
            // 
            this.toothOnFocusComboBox.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.toothOnFocusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toothOnFocusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.toothOnFocusComboBox.Location = new System.Drawing.Point(334, 36);
            this.toothOnFocusComboBox.Name = "toothOnFocusComboBox";
            this.toothOnFocusComboBox.Size = new System.Drawing.Size(121, 21);
            this.toothOnFocusComboBox.TabIndex = 20;
            // 
            // reservationDetails
            // 
            this.reservationDetails.Enabled = false;
            this.reservationDetails.Location = new System.Drawing.Point(293, 110);
            this.reservationDetails.Name = "reservationDetails";
            this.reservationDetails.Size = new System.Drawing.Size(262, 184);
            this.reservationDetails.TabIndex = 19;
            this.reservationDetails.Text = "";
            // 
            // confirmReservation
            // 
            this.confirmReservation.Location = new System.Drawing.Point(462, 314);
            this.confirmReservation.Name = "confirmReservation";
            this.confirmReservation.Size = new System.Drawing.Size(93, 44);
            this.confirmReservation.TabIndex = 22;
            this.confirmReservation.Text = "Confirm Reservation";
            this.confirmReservation.UseVisualStyleBackColor = true;
            this.confirmReservation.Click += new System.EventHandler(this.confirmReservation_Click);
            // 
            // InterventionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 373);
            this.Controls.Add(this.confirmReservation);
            this.Controls.Add(this.toothNameLabel);
            this.Controls.Add(this.toothOnFocusComboBox);
            this.Controls.Add(this.reservationDetails);
            this.Controls.Add(this.timeOfInterventionDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfAppointment);
            this.Controls.Add(this.serviceTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterventionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form for Reservation";
            this.Load += new System.EventHandler(this.InterventionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox serviceTypeComboBox;
        private System.Windows.Forms.ListBox listOfAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timeOfInterventionDatePicker;
        private System.Windows.Forms.Label toothNameLabel;
        private System.Windows.Forms.ComboBox toothOnFocusComboBox;
        private System.Windows.Forms.RichTextBox reservationDetails;
        private System.Windows.Forms.Button confirmReservation;
    }
}