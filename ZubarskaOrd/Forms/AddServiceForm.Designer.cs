namespace ZubarskaOrd.Forms
{
    partial class AddServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServiceForm));
            this.servicesListView = new System.Windows.Forms.ListView();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.serviceDurationComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servicesListView
            // 
            this.servicesListView.Location = new System.Drawing.Point(13, 13);
            this.servicesListView.Name = "servicesListView";
            this.servicesListView.Size = new System.Drawing.Size(138, 230);
            this.servicesListView.TabIndex = 0;
            this.servicesListView.UseCompatibleStateImageBehavior = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(158, 13);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(92, 19);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "New Service: ";
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Location = new System.Drawing.Point(159, 47);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(41, 13);
            this.descriptionLabel2.TabIndex = 2;
            this.descriptionLabel2.Text = "Name: ";
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.AutoSize = true;
            this.descriptionLabel3.Location = new System.Drawing.Point(159, 77);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(50, 13);
            this.descriptionLabel3.TabIndex = 3;
            this.descriptionLabel3.Text = "Duration:";
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Location = new System.Drawing.Point(221, 44);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.serviceNameTextBox.TabIndex = 1;
            // 
            // serviceDurationComboBox
            // 
            this.serviceDurationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceDurationComboBox.FormattingEnabled = true;
            this.serviceDurationComboBox.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60"});
            this.serviceDurationComboBox.Location = new System.Drawing.Point(221, 74);
            this.serviceDurationComboBox.Name = "serviceDurationComboBox";
            this.serviceDurationComboBox.Size = new System.Drawing.Size(145, 21);
            this.serviceDurationComboBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(162, 127);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(290, 126);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 263);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.serviceDurationComboBox);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.descriptionLabel3);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.servicesListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Service ";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView servicesListView;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.Label descriptionLabel3;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.ComboBox serviceDurationComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
    }
}