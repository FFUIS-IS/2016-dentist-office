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
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOfficeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllDOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.Button();
            this.regularUserMenuStrip = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDailyReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicalStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorMenuStrip.SuspendLayout();
            this.regularUserMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // administratorMenuStrip
            // 
            this.administratorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorsToolStripMenuItem,
            this.medicalStuffToolStripMenuItem,
            this.citiesToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.dOfficeInfoToolStripMenuItem});
            this.administratorMenuStrip.Location = new System.Drawing.Point(0, 24);
            this.administratorMenuStrip.Name = "administratorMenuStrip";
            this.administratorMenuStrip.Size = new System.Drawing.Size(715, 24);
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
            this.listOfAllMStuffToolStripMenuItem,
            this.addMedicalStaffToolStripMenuItem});
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
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAllServicesToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // listOfAllServicesToolStripMenuItem
            // 
            this.listOfAllServicesToolStripMenuItem.Name = "listOfAllServicesToolStripMenuItem";
            this.listOfAllServicesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listOfAllServicesToolStripMenuItem.Text = "List Of All Services";
            this.listOfAllServicesToolStripMenuItem.Click += new System.EventHandler(this.listOfAllServicesToolStripMenuItem_Click);
            // 
            // dOfficeInfoToolStripMenuItem
            // 
            this.dOfficeInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAllDOfficeToolStripMenuItem});
            this.dOfficeInfoToolStripMenuItem.Name = "dOfficeInfoToolStripMenuItem";
            this.dOfficeInfoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.dOfficeInfoToolStripMenuItem.Text = "D.Office Info";
            // 
            // listOfAllDOfficeToolStripMenuItem
            // 
            this.listOfAllDOfficeToolStripMenuItem.Name = "listOfAllDOfficeToolStripMenuItem";
            this.listOfAllDOfficeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listOfAllDOfficeToolStripMenuItem.Text = "List of All D.Office";
            this.listOfAllDOfficeToolStripMenuItem.Click += new System.EventHandler(this.listOfAllDOfficeToolStripMenuItem_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutButton.Location = new System.Drawing.Point(640, 0);
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
            this.patientsToolStripMenuItem,
            this.interventionsToolStripMenuItem});
            this.regularUserMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.regularUserMenuStrip.Name = "regularUserMenuStrip";
            this.regularUserMenuStrip.Size = new System.Drawing.Size(715, 24);
            this.regularUserMenuStrip.TabIndex = 3;
            this.regularUserMenuStrip.Text = "regularUserMenuStrip";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsFormToolStripMenuItem,
            this.addPatientToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // patientsFormToolStripMenuItem
            // 
            this.patientsFormToolStripMenuItem.Name = "patientsFormToolStripMenuItem";
            this.patientsFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patientsFormToolStripMenuItem.Text = "PatientsForm";
            this.patientsFormToolStripMenuItem.Click += new System.EventHandler(this.patientsFormToolStripMenuItem_Click);
            // 
            // interventionsToolStripMenuItem
            // 
            this.interventionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfDailyReservationsToolStripMenuItem});
            this.interventionsToolStripMenuItem.Name = "interventionsToolStripMenuItem";
            this.interventionsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.interventionsToolStripMenuItem.Text = "Interventions";
            // 
            // listOfDailyReservationsToolStripMenuItem
            // 
            this.listOfDailyReservationsToolStripMenuItem.Name = "listOfDailyReservationsToolStripMenuItem";
            this.listOfDailyReservationsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.listOfDailyReservationsToolStripMenuItem.Text = "List Of Daily Reservations";
            this.listOfDailyReservationsToolStripMenuItem.Click += new System.EventHandler(this.listOfDailyReservationsToolStripMenuItem_Click);
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPatientToolStripMenuItem.Text = "Add Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
            // 
            // addMedicalStaffToolStripMenuItem
            // 
            this.addMedicalStaffToolStripMenuItem.Name = "addMedicalStaffToolStripMenuItem";
            this.addMedicalStaffToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addMedicalStaffToolStripMenuItem.Text = "Add MedicalStaff";
            this.addMedicalStaffToolStripMenuItem.Click += new System.EventHandler(this.addMedicalStaffToolStripMenuItem_Click);
            // 
            // DentalOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 378);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.administratorMenuStrip);
            this.Controls.Add(this.regularUserMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.administratorMenuStrip;
            this.MaximizeBox = false;
            this.Name = "DentalOfficeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Office";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DentalOfficeForm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOfficeInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllDOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfDailyReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMedicalStaffToolStripMenuItem;
    }
}

