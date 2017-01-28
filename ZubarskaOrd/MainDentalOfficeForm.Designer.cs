namespace ZubarskaOrd
{
    partial class DentalOfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentalOfficeForm));
            this.Patient = new System.Windows.Forms.Button();
            this.PatientPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Patient
            // 
            this.Patient.Location = new System.Drawing.Point(12, 12);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(75, 51);
            this.Patient.TabIndex = 0;
            this.Patient.Text = "Patient";
            this.Patient.UseVisualStyleBackColor = true;
            this.Patient.Click += new System.EventHandler(this.Patient_Click);
            // 
            // PatientPanel
            // 
            this.PatientPanel.Enabled = false;
            this.PatientPanel.Location = new System.Drawing.Point(12, 69);
            this.PatientPanel.Name = "PatientPanel";
            this.PatientPanel.Size = new System.Drawing.Size(656, 394);
            this.PatientPanel.TabIndex = 1;
            // 
            // DentalOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 475);
            this.Controls.Add(this.PatientPanel);
            this.Controls.Add(this.Patient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DentalOfficeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Office";
            this.Load += new System.EventHandler(this.DentalOfficeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Patient;
        private System.Windows.Forms.Panel PatientPanel;
    }
}

