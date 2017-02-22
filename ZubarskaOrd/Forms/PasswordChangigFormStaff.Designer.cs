namespace ZubarskaOrd.Forms
{
    partial class PasswordChangigFormStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangigFormStaff));
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(283, 146);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(164, 146);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click_1);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(12, 67);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(100, 18);
            this.newPasswordLabel.TabIndex = 15;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(12, 108);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(146, 18);
            this.confirmLabel.TabIndex = 14;
            this.confirmLabel.Text = "Repeat New Password:";
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.Location = new System.Drawing.Point(12, 26);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(95, 18);
            this.oldPasswordLabel.TabIndex = 10;
            this.oldPasswordLabel.Text = "Old Password:";
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Location = new System.Drawing.Point(164, 108);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Size = new System.Drawing.Size(194, 20);
            this.confirmTextBox.TabIndex = 11;
            this.confirmTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(164, 67);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(194, 20);
            this.newPasswordTextBox.TabIndex = 9;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(164, 26);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(194, 20);
            this.oldPasswordTextBox.TabIndex = 8;
            this.oldPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordChangigFormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 193);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.oldPasswordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordChangigFormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasswordChangigFormStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
    }
}