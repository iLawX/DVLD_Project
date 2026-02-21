namespace DVLD.Licenses
{
    partial class LicenseDetails
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
            this.Close = new System.Windows.Forms.Button();
            this.LicenseCard = new DVLD.Licenses.Controls.LicenseCard();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(588, 504);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(112, 35);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LicenseCard
            // 
            this.LicenseCard.Location = new System.Drawing.Point(12, 12);
            this.LicenseCard.Name = "LicenseCard";
            this.LicenseCard.Size = new System.Drawing.Size(688, 486);
            this.LicenseCard.TabIndex = 0;
            // 
            // LicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 549);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.LicenseCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LicenseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Details";
            this.Load += new System.EventHandler(this.LicenseDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.LicenseCard LicenseCard;
        private System.Windows.Forms.Button Close;
    }
}