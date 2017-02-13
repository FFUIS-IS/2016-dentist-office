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
            this.SuspendLayout();
            // 
            // serviceTypeComboBox
            // 
            this.serviceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceTypeComboBox.FormattingEnabled = true;
            this.serviceTypeComboBox.Location = new System.Drawing.Point(60, 12);
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
            this.timeOfInterventionDatePicker.Location = new System.Drawing.Point(60, 58);
            this.timeOfInterventionDatePicker.Name = "timeOfInterventionDatePicker";
            this.timeOfInterventionDatePicker.Size = new System.Drawing.Size(182, 20);
            this.timeOfInterventionDatePicker.TabIndex = 4;
            this.timeOfInterventionDatePicker.ValueChanged += new System.EventHandler(this.timeOfInterventionDatePicker_ValueChanged);
            // 
            // InterventionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 360);
            this.Controls.Add(this.timeOfInterventionDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfAppointment);
            this.Controls.Add(this.serviceTypeComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterventionForm";
            this.Text = "InterventionFormcs";
            this.Load += new System.EventHandler(this.InterventionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox serviceTypeComboBox;
        private System.Windows.Forms.ListBox listOfAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timeOfInterventionDatePicker;
    }
}