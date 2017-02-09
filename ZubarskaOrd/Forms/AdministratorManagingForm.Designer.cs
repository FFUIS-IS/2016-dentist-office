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
            this.administratorsListView = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshAdminListViewButton = new System.Windows.Forms.Button();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.newAdministratorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // administratorsListView
            // 
            this.administratorsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName});
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
            this.refreshAdminListViewButton.TabIndex = 1;
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
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel2.Location = new System.Drawing.Point(209, 54);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(72, 19);
            this.descriptionLabel2.TabIndex = 3;
            this.descriptionLabel2.Text = "FirstName";
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.AutoSize = true;
            this.descriptionLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel3.Location = new System.Drawing.Point(210, 90);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(71, 19);
            this.descriptionLabel3.TabIndex = 4;
            this.descriptionLabel3.Text = "LastName";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(305, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(305, 91);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // newAdministratorButton
            // 
            this.newAdministratorButton.Location = new System.Drawing.Point(110, 291);
            this.newAdministratorButton.Name = "newAdministratorButton";
            this.newAdministratorButton.Size = new System.Drawing.Size(91, 23);
            this.newAdministratorButton.TabIndex = 5;
            this.newAdministratorButton.Text = "New Administrator";
            this.newAdministratorButton.UseVisualStyleBackColor = true;
            this.newAdministratorButton.Click += new System.EventHandler(this.newAdministratorButton_Click);
            // 
            // AdministratorManagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 332);
            this.Controls.Add(this.newAdministratorButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.descriptionLabel3);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.refreshAdminListViewButton);
            this.Controls.Add(this.administratorsListView);
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
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.Button newAdministratorButton;
    }
}