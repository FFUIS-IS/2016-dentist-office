namespace ZubarskaOrd.Forms
{
    partial class AdministratorManagingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorManagingForm));
            this.administratorsListView = new System.Windows.Forms.ListView();
            this.refreshAdminListViewButton = new System.Windows.Forms.Button();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.saveAdministratorButton = new System.Windows.Forms.Button();
            this.addNewAdministratorButton = new System.Windows.Forms.Button();
            this.deleteAdministratorButton = new System.Windows.Forms.Button();
            this.newUsernameTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel5 = new System.Windows.Forms.Label();
            this.descriptionLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // administratorsListView
            // 
            this.administratorsListView.Location = new System.Drawing.Point(12, 12);
            this.administratorsListView.Name = "administratorsListView";
            this.administratorsListView.Size = new System.Drawing.Size(189, 258);
            this.administratorsListView.TabIndex = 0;
            this.administratorsListView.UseCompatibleStateImageBehavior = false;
            // 
            // refreshAdminListViewButton
            // 
            this.refreshAdminListViewButton.Location = new System.Drawing.Point(12, 291);
            this.refreshAdminListViewButton.Name = "refreshAdminListViewButton";
            this.refreshAdminListViewButton.Size = new System.Drawing.Size(92, 23);
            this.refreshAdminListViewButton.TabIndex = 4;
            this.refreshAdminListViewButton.Text = "Refresh List";
            this.refreshAdminListViewButton.UseVisualStyleBackColor = true;
            this.refreshAdminListViewButton.Click += new System.EventHandler(this.refreshAdminListViewButton_Click);
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.AutoSize = true;
            this.descriptionLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.Location = new System.Drawing.Point(208, 13);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(128, 19);
            this.descriptionLabel1.TabIndex = 2;
            this.descriptionLabel1.Text = "New Administrator:";
            this.descriptionLabel1.Visible = false;
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel2.Location = new System.Drawing.Point(208, 53);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(72, 19);
            this.descriptionLabel2.TabIndex = 3;
            this.descriptionLabel2.Text = "FirstName";
            this.descriptionLabel2.Visible = false;
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.AutoSize = true;
            this.descriptionLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel3.Location = new System.Drawing.Point(208, 90);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(71, 19);
            this.descriptionLabel3.TabIndex = 4;
            this.descriptionLabel3.Text = "LastName";
            this.descriptionLabel3.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(305, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(305, 91);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Visible = false;
            // 
            // saveAdministratorButton
            // 
            this.saveAdministratorButton.Location = new System.Drawing.Point(412, 232);
            this.saveAdministratorButton.Name = "saveAdministratorButton";
            this.saveAdministratorButton.Size = new System.Drawing.Size(91, 23);
            this.saveAdministratorButton.TabIndex = 3;
            this.saveAdministratorButton.Text = "Save";
            this.saveAdministratorButton.UseVisualStyleBackColor = true;
            this.saveAdministratorButton.Visible = false;
            this.saveAdministratorButton.Click += new System.EventHandler(this.saveAdministratorButton_Click);
            // 
            // addNewAdministratorButton
            // 
            this.addNewAdministratorButton.Location = new System.Drawing.Point(111, 291);
            this.addNewAdministratorButton.Name = "addNewAdministratorButton";
            this.addNewAdministratorButton.Size = new System.Drawing.Size(90, 23);
            this.addNewAdministratorButton.TabIndex = 5;
            this.addNewAdministratorButton.Text = "Add";
            this.addNewAdministratorButton.UseVisualStyleBackColor = true;
            this.addNewAdministratorButton.Click += new System.EventHandler(this.addNewAdministratorButton_Click);
            // 
            // deleteAdministratorButton
            // 
            this.deleteAdministratorButton.Location = new System.Drawing.Point(428, 297);
            this.deleteAdministratorButton.Name = "deleteAdministratorButton";
            this.deleteAdministratorButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAdministratorButton.TabIndex = 6;
            this.deleteAdministratorButton.Text = "Delete";
            this.deleteAdministratorButton.UseVisualStyleBackColor = true;
            this.deleteAdministratorButton.Click += new System.EventHandler(this.deleteAdministratorButton_Click);
            // 
            // newUsernameTextBox
            // 
            this.newUsernameTextBox.Location = new System.Drawing.Point(305, 135);
            this.newUsernameTextBox.Name = "newUsernameTextBox";
            this.newUsernameTextBox.Size = new System.Drawing.Size(198, 20);
            this.newUsernameTextBox.TabIndex = 3;
            this.newUsernameTextBox.Visible = false;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(305, 174);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(198, 20);
            this.newPasswordTextBox.TabIndex = 4;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            this.newPasswordTextBox.Visible = false;
            // 
            // descriptionLabel5
            // 
            this.descriptionLabel5.AutoSize = true;
            this.descriptionLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel5.Location = new System.Drawing.Point(208, 173);
            this.descriptionLabel5.Name = "descriptionLabel5";
            this.descriptionLabel5.Size = new System.Drawing.Size(67, 19);
            this.descriptionLabel5.TabIndex = 8;
            this.descriptionLabel5.Text = "Password";
            this.descriptionLabel5.Visible = false;
            // 
            // descriptionLabel4
            // 
            this.descriptionLabel4.AutoSize = true;
            this.descriptionLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel4.Location = new System.Drawing.Point(208, 134);
            this.descriptionLabel4.Name = "descriptionLabel4";
            this.descriptionLabel4.Size = new System.Drawing.Size(71, 19);
            this.descriptionLabel4.TabIndex = 7;
            this.descriptionLabel4.Text = "Username";
            this.descriptionLabel4.Visible = false;
            // 
            // AdministratorManagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 332);
            this.Controls.Add(this.descriptionLabel5);
            this.Controls.Add(this.descriptionLabel4);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newUsernameTextBox);
            this.Controls.Add(this.deleteAdministratorButton);
            this.Controls.Add(this.addNewAdministratorButton);
            this.Controls.Add(this.saveAdministratorButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.descriptionLabel3);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.refreshAdminListViewButton);
            this.Controls.Add(this.administratorsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorManagingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrator Managing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView administratorsListView;
        private System.Windows.Forms.Button refreshAdminListViewButton;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.Label descriptionLabel3;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button saveAdministratorButton;
        private System.Windows.Forms.Button addNewAdministratorButton;
        private System.Windows.Forms.Button deleteAdministratorButton;
        private System.Windows.Forms.TextBox newUsernameTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label descriptionLabel5;
        private System.Windows.Forms.Label descriptionLabel4;
    }
}