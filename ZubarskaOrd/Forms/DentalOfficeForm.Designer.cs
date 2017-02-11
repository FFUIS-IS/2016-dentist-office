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
            this.administratorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.administratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllAdministratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllMStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.Button();
            this.regularUserMenuStrip = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorMenuStrip.SuspendLayout();
            this.regularUserMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // administratorMenuStrip
            // 
            this.administratorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorsToolStripMenuItem,
            this.medicalStuffToolStripMenuItem,
            this.citiesToolStripMenuItem});
            this.administratorMenuStrip.Location = new System.Drawing.Point(0, 24);
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
            this.listOfAllMStuffToolStripMenuItem.Click += new System.EventHandler(this.listOfAllMStuffToolStripMenuItem_Click);
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
            // regularUserMenuStrip
            // 
            this.regularUserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem});
            this.regularUserMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.regularUserMenuStrip.Name = "regularUserMenuStrip";
            this.regularUserMenuStrip.Size = new System.Drawing.Size(866, 24);
            this.regularUserMenuStrip.TabIndex = 3;
            this.regularUserMenuStrip.Text = "regularUserMenuStrip";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsFormToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // patientsFormToolStripMenuItem
            // 
            this.patientsFormToolStripMenuItem.Name = "patientsFormToolStripMenuItem";
            this.patientsFormToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.patientsFormToolStripMenuItem.Text = "PatientsForm";
            this.patientsFormToolStripMenuItem.Click += new System.EventHandler(this.patientsFormToolStripMenuItem_Click);
            // 
            // citiesToolStripMenuItem
            // 
            this.citiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCToolStripMenuItem});
            this.citiesToolStripMenuItem.Name = "citiesToolStripMenuItem";
            this.citiesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.citiesToolStripMenuItem.Text = "Cities";
            // 
            // addNewCToolStripMenuItem
            // 
            this.addNewCToolStripMenuItem.Name = "addNewCToolStripMenuItem";
            this.addNewCToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNewCToolStripMenuItem.Text = "List Of All Cities";
            this.addNewCToolStripMenuItem.Click += new System.EventHandler(this.addNewCToolStripMenuItem_Click);
            // 
            // DentalOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 494);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.administratorMenuStrip);
            this.Controls.Add(this.regularUserMenuStrip);
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
            this.regularUserMenuStrip.ResumeLayout(false);
            this.regularUserMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip administratorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem administratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllAdministratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalStuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllMStuffToolStripMenuItem;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.MenuStrip regularUserMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCToolStripMenuItem;
    }
}

