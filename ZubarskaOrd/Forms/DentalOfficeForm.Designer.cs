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
            this.PatientButton = new System.Windows.Forms.Button();
            this.administratorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.administratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllAdministratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllMStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.Button();
            this.administratorMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientButton
            // 
            this.PatientButton.Location = new System.Drawing.Point(12, 28);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(75, 51);
            this.PatientButton.TabIndex = 0;
            this.PatientButton.Text = "Patient";
            this.PatientButton.UseVisualStyleBackColor = true;
            this.PatientButton.Click += new System.EventHandler(this.Patient_Click);
            // 
            // administratorMenuStrip
            // 
            this.administratorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorsToolStripMenuItem,
            this.medicalStuffToolStripMenuItem});
            this.administratorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.administratorMenuStrip.Name = "administratorMenuStrip";
            this.administratorMenuStrip.Size = new System.Drawing.Size(866, 24);
            this.administratorMenuStrip.TabIndex = 1;
            this.administratorMenuStrip.Text = "menuStrip1";
            // 
            // administratorsToolStripMenuItem
            // 
            this.administratorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAllAdministratorsToolStripMenuItem});
            this.administratorsToolStripMenuItem.Name = "administratorsToolStripMenuItem";
            this.administratorsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.administratorsToolStripMenuItem.Text = "Administrators";
            // 
            // listOfAllAdministratorsToolStripMenuItem
            // 
            this.listOfAllAdministratorsToolStripMenuItem.Name = "listOfAllAdministratorsToolStripMenuItem";
            this.listOfAllAdministratorsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.listOfAllAdministratorsToolStripMenuItem.Text = "List Of All Administrators";
            this.listOfAllAdministratorsToolStripMenuItem.Click += new System.EventHandler(this.listOfAllAdministratorsToolStripMenuItem_Click);
            // 
            // medicalStuffToolStripMenuItem
            // 
            this.medicalStuffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAllMStuffToolStripMenuItem});
            this.medicalStuffToolStripMenuItem.Name = "medicalStuffToolStripMenuItem";
            this.medicalStuffToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.medicalStuffToolStripMenuItem.Text = "MedicalStuff";
            // 
            // listOfAllMStuffToolStripMenuItem
            // 
            this.listOfAllMStuffToolStripMenuItem.Name = "listOfAllMStuffToolStripMenuItem";
            this.listOfAllMStuffToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listOfAllMStuffToolStripMenuItem.Text = "List Of All M.Stuff";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(779, 444);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 38);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // DentalOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 494);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.PatientButton);
            this.Controls.Add(this.administratorMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.administratorMenuStrip;
            this.MaximizeBox = false;
            this.Name = "DentalOfficeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Office";
            this.Load += new System.EventHandler(this.DentalOfficeForm_Load);
            this.administratorMenuStrip.ResumeLayout(false);
            this.administratorMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PatientButton;
        private System.Windows.Forms.MenuStrip administratorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem administratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllAdministratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalStuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllMStuffToolStripMenuItem;
        private System.Windows.Forms.Button logoutButton;
    }
}

