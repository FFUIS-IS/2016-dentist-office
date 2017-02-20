namespace ZubarskaOrd.Forms
{
    partial class MedicalStuffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalStuffForm));
            this.medicalStuffComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.addMStuffButton = new System.Windows.Forms.Button();
            this.deleteMStuffButton = new System.Windows.Forms.Button();
            this.descriptionLabel8 = new System.Windows.Forms.Label();
            this.descriptionLabel7 = new System.Windows.Forms.Label();
            this.descriptionLabel6 = new System.Windows.Forms.Label();
            this.descriptionLabel5 = new System.Windows.Forms.Label();
            this.descriptionLabel4 = new System.Windows.Forms.Label();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.JMBGTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dobTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // medicalStuffComboBox
            // 
            this.medicalStuffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicalStuffComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalStuffComboBox.FormattingEnabled = true;
            this.medicalStuffComboBox.Location = new System.Drawing.Point(12, 39);
            this.medicalStuffComboBox.Name = "medicalStuffComboBox";
            this.medicalStuffComboBox.Size = new System.Drawing.Size(268, 27);
            this.medicalStuffComboBox.TabIndex = 1;
            this.medicalStuffComboBox.SelectedIndexChanged += new System.EventHandler(this.medicalStuffComboBox_SelectedIndexChanged_1);
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.AutoSize = true;
            this.descriptionLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.Location = new System.Drawing.Point(12, 13);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(136, 19);
            this.descriptionLabel1.TabIndex = 1;
            this.descriptionLabel1.Text = "Select Medical Stuff:";
            // 
            // addMStuffButton
            // 
            this.addMStuffButton.Location = new System.Drawing.Point(12, 72);
            this.addMStuffButton.Name = "addMStuffButton";
            this.addMStuffButton.Size = new System.Drawing.Size(136, 23);
            this.addMStuffButton.TabIndex = 2;
            this.addMStuffButton.Text = "Add";
            this.addMStuffButton.UseVisualStyleBackColor = true;
            this.addMStuffButton.Click += new System.EventHandler(this.addMStuffButton_Click);
            // 
            // deleteMStuffButton
            // 
            this.deleteMStuffButton.Location = new System.Drawing.Point(146, 72);
            this.deleteMStuffButton.Name = "deleteMStuffButton";
            this.deleteMStuffButton.Size = new System.Drawing.Size(134, 23);
            this.deleteMStuffButton.TabIndex = 3;
            this.deleteMStuffButton.Text = "Delete";
            this.deleteMStuffButton.UseVisualStyleBackColor = true;
            this.deleteMStuffButton.Click += new System.EventHandler(this.deleteMStuffButton_Click);
            // 
            // descriptionLabel8
            // 
            this.descriptionLabel8.AutoSize = true;
            this.descriptionLabel8.Location = new System.Drawing.Point(13, 266);
            this.descriptionLabel8.Name = "descriptionLabel8";
            this.descriptionLabel8.Size = new System.Drawing.Size(27, 13);
            this.descriptionLabel8.TabIndex = 14;
            this.descriptionLabel8.Text = "City:";
            // 
            // descriptionLabel7
            // 
            this.descriptionLabel7.AutoSize = true;
            this.descriptionLabel7.Location = new System.Drawing.Point(13, 239);
            this.descriptionLabel7.Name = "descriptionLabel7";
            this.descriptionLabel7.Size = new System.Drawing.Size(48, 13);
            this.descriptionLabel7.TabIndex = 13;
            this.descriptionLabel7.Text = "Address:";
            // 
            // descriptionLabel6
            // 
            this.descriptionLabel6.AutoSize = true;
            this.descriptionLabel6.Location = new System.Drawing.Point(13, 212);
            this.descriptionLabel6.Name = "descriptionLabel6";
            this.descriptionLabel6.Size = new System.Drawing.Size(47, 13);
            this.descriptionLabel6.TabIndex = 12;
            this.descriptionLabel6.Text = "Contact:";
            // 
            // descriptionLabel5
            // 
            this.descriptionLabel5.AutoSize = true;
            this.descriptionLabel5.Location = new System.Drawing.Point(13, 185);
            this.descriptionLabel5.Name = "descriptionLabel5";
            this.descriptionLabel5.Size = new System.Drawing.Size(39, 13);
            this.descriptionLabel5.TabIndex = 11;
            this.descriptionLabel5.Text = "JMBG:";
            // 
            // descriptionLabel4
            // 
            this.descriptionLabel4.AutoSize = true;
            this.descriptionLabel4.Location = new System.Drawing.Point(13, 164);
            this.descriptionLabel4.Name = "descriptionLabel4";
            this.descriptionLabel4.Size = new System.Drawing.Size(68, 13);
            this.descriptionLabel4.TabIndex = 10;
            this.descriptionLabel4.Text = "Date of birth:";
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.AutoSize = true;
            this.descriptionLabel3.Location = new System.Drawing.Point(13, 137);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(59, 13);
            this.descriptionLabel3.TabIndex = 9;
            this.descriptionLabel3.Text = "Last name:";
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Location = new System.Drawing.Point(13, 110);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(58, 13);
            this.descriptionLabel2.TabIndex = 8;
            this.descriptionLabel2.Text = "First name:";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(93, 263);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(164, 21);
            this.cityComboBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(93, 236);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(164, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(93, 209);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(164, 20);
            this.contactTextBox.TabIndex = 8;
            // 
            // JMBGTextBox
            // 
            this.JMBGTextBox.Location = new System.Drawing.Point(93, 182);
            this.JMBGTextBox.Name = "JMBGTextBox";
            this.JMBGTextBox.Size = new System.Drawing.Size(164, 20);
            this.JMBGTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(93, 134);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(93, 107);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(93, 290);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(164, 32);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // dobTimePicker
            // 
            this.dobTimePicker.Location = new System.Drawing.Point(93, 156);
            this.dobTimePicker.Name = "dobTimePicker";
            this.dobTimePicker.Size = new System.Drawing.Size(164, 20);
            this.dobTimePicker.TabIndex = 6;
            // 
            // MedicalStuffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 343);
            this.Controls.Add(this.dobTimePicker);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.JMBGTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.descriptionLabel8);
            this.Controls.Add(this.descriptionLabel7);
            this.Controls.Add(this.descriptionLabel6);
            this.Controls.Add(this.descriptionLabel5);
            this.Controls.Add(this.descriptionLabel4);
            this.Controls.Add(this.descriptionLabel3);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.deleteMStuffButton);
            this.Controls.Add(this.addMStuffButton);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.medicalStuffComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicalStuffForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medical Stuff";
            this.Activated += new System.EventHandler(this.MedicalStuffForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox medicalStuffComboBox;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Button addMStuffButton;
        private System.Windows.Forms.Button deleteMStuffButton;
        private System.Windows.Forms.Label descriptionLabel8;
        private System.Windows.Forms.Label descriptionLabel7;
        private System.Windows.Forms.Label descriptionLabel6;
        private System.Windows.Forms.Label descriptionLabel5;
        private System.Windows.Forms.Label descriptionLabel4;
        private System.Windows.Forms.Label descriptionLabel3;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox JMBGTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DateTimePicker dobTimePicker;
    }
}