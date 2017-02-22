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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentalOfficeForm));
            this.administratorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.administratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllAdministratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllMStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicalStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDailyReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dOfficeInfoToolStripMenuItem,
            this.passwordToolStripMenuItem});
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
            // addMedicalStaffToolStripMenuItem
            // 
            this.addMedicalStaffToolStripMenuItem.Name = "addMedicalStaffToolStripMenuItem";
            this.addMedicalStaffToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addMedicalStaffToolStripMenuItem.Text = "Add MedicalStaff";
            this.addMedicalStaffToolStripMenuItem.Click += new System.EventHandler(this.addMedicalStaffToolStripMenuItem_Click);
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
            this.logoutButton.Location = new System.Drawing.Point(1271, 24);
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
            this.interventionsToolStripMenuItem,
            this.passwordToolStripMenuItem1});
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
            this.patientsFormToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.patientsFormToolStripMenuItem.Text = "PatientsForm";
            this.patientsFormToolStripMenuItem.Click += new System.EventHandler(this.patientsFormToolStripMenuItem_Click);
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addPatientToolStripMenuItem.Text = "Add Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
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
            // officeNameLabel
            // 
            this.officeNameLabel.AutoSize = true;
            this.officeNameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.officeNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.officeNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeNameLabel.Location = new System.Drawing.Point(13, 101);
            this.officeNameLabel.Name = "officeNameLabel";
            this.officeNameLabel.Size = new System.Drawing.Size(46, 20);
            this.officeNameLabel.TabIndex = 4;
            this.officeNameLabel.Text = "label1";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(13, 70);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(197, 20);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Welcome to the Dentist Office:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(276, 101);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(39, 20);
            this.dateTimeLabel.TabIndex = 8;
            this.dateTimeLabel.Text = "Time";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 161);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 20);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "label1";
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.descriptionLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel2.Location = new System.Drawing.Point(12, 135);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(146, 20);
            this.descriptionLabel2.TabIndex = 10;
            this.descriptionLabel2.Text = "Currently logged user:";
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.AutoSize = true;
            this.descriptionLabel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.descriptionLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel3.Location = new System.Drawing.Point(276, 70);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(90, 20);
            this.descriptionLabel3.TabIndex = 11;
            this.descriptionLabel3.Text = "Date:    Time:";
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // passwordToolStripMenuItem1
            // 
            this.passwordToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePasswordToolStripMenuItem});
            this.passwordToolStripMenuItem1.Name = "passwordToolStripMenuItem1";
            this.passwordToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.passwordToolStripMenuItem1.Text = "Password";
            // 
            // managePasswordToolStripMenuItem
            // 
            this.managePasswordToolStripMenuItem.Name = "managePasswordToolStripMenuItem";
            this.managePasswordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.managePasswordToolStripMenuItem.Text = "Manage Password";
            this.managePasswordToolStripMenuItem.Click += new System.EventHandler(this.managePasswordToolStripMenuItem_Click);
            // 
            // DentalOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 378);
            this.Controls.Add(this.descriptionLabel3);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.officeNameLabel);
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
        private System.Windows.Forms.Label officeNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.Label descriptionLabel3;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managePasswordToolStripMenuItem;
    }
}

