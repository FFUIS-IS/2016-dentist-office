namespace ZubarskaOrd.Forms
{
    partial class InformationAboutDOfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationAboutDOfficeForm));
            this.informationListView = new System.Windows.Forms.ListView();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informationListView
            // 
            this.informationListView.Location = new System.Drawing.Point(13, 13);
            this.informationListView.Name = "informationListView";
            this.informationListView.Size = new System.Drawing.Size(197, 289);
            this.informationListView.TabIndex = 0;
            this.informationListView.UseCompatibleStateImageBehavior = false;
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.AutoSize = true;
            this.descriptionLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.Location = new System.Drawing.Point(217, 13);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(170, 19);
            this.descriptionLabel1.TabIndex = 1;
            this.descriptionLabel1.Text = "New Contact Information:";
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Location = new System.Drawing.Point(218, 48);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(38, 13);
            this.descriptionLabel2.TabIndex = 2;
            this.descriptionLabel2.Text = "Name:";
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.AutoSize = true;
            this.descriptionLabel3.Location = new System.Drawing.Point(218, 83);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(45, 13);
            this.descriptionLabel3.TabIndex = 3;
            this.descriptionLabel3.Text = "Address";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(287, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(156, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(287, 80);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(156, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(221, 146);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(367, 145);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // InformationAboutDOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 314);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionLabel3);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.informationListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationAboutDOfficeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dental Office Contact";
            this.Load += new System.EventHandler(this.InformationAboutDOfficeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView informationListView;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.Label descriptionLabel3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
    }
}