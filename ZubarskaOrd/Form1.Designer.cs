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
            this.LoginMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginMainButton
            // 
            this.LoginMainButton.Location = new System.Drawing.Point(247, 13);
            this.LoginMainButton.Name = "LoginMainButton";
            this.LoginMainButton.Size = new System.Drawing.Size(75, 23);
            this.LoginMainButton.TabIndex = 0;
            this.LoginMainButton.Text = "Login!";
            this.LoginMainButton.UseVisualStyleBackColor = true;
            this.LoginMainButton.Click += new System.EventHandler(this.LoginMainButton_Click);
            // 
            // DentalOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 296);
            this.Controls.Add(this.LoginMainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DentalOfficeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Office";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginMainButton;
    }
}

