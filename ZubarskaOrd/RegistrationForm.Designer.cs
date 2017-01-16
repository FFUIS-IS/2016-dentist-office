namespace ZubarskaOrd
{
    partial class RegistrationForm
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
            this.usernameRegLabel = new System.Windows.Forms.Label();
            this.usernameRegTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegLabel = new System.Windows.Forms.Label();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.CancelRegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameRegLabel
            // 
            this.usernameRegLabel.AutoSize = true;
            this.usernameRegLabel.Location = new System.Drawing.Point(10, 36);
            this.usernameRegLabel.Name = "usernameRegLabel";
            this.usernameRegLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameRegLabel.TabIndex = 0;
            this.usernameRegLabel.Text = "Username";
            // 
            // usernameRegTextBox
            // 
            this.usernameRegTextBox.Location = new System.Drawing.Point(119, 36);
            this.usernameRegTextBox.Name = "usernameRegTextBox";
            this.usernameRegTextBox.Size = new System.Drawing.Size(134, 20);
            this.usernameRegTextBox.TabIndex = 1;
            // 
            // passwordRegLabel
            // 
            this.passwordRegLabel.AutoSize = true;
            this.passwordRegLabel.Location = new System.Drawing.Point(12, 109);
            this.passwordRegLabel.Name = "passwordRegLabel";
            this.passwordRegLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordRegLabel.TabIndex = 2;
            this.passwordRegLabel.Text = "Password";
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Location = new System.Drawing.Point(119, 101);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.Size = new System.Drawing.Size(134, 20);
            this.passwordRegTextBox.TabIndex = 3;
            this.passwordRegTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(32, 215);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // CancelRegButton
            // 
            this.CancelRegButton.Location = new System.Drawing.Point(178, 215);
            this.CancelRegButton.Name = "CancelRegButton";
            this.CancelRegButton.Size = new System.Drawing.Size(75, 23);
            this.CancelRegButton.TabIndex = 5;
            this.CancelRegButton.Text = "Cancel";
            this.CancelRegButton.UseVisualStyleBackColor = true;
            this.CancelRegButton.Click += new System.EventHandler(this.CancelRegButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancelRegButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordRegTextBox);
            this.Controls.Add(this.passwordRegLabel);
            this.Controls.Add(this.usernameRegTextBox);
            this.Controls.Add(this.usernameRegLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameRegLabel;
        private System.Windows.Forms.TextBox usernameRegTextBox;
        private System.Windows.Forms.Label passwordRegLabel;
        private System.Windows.Forms.TextBox passwordRegTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button CancelRegButton;
    }
}