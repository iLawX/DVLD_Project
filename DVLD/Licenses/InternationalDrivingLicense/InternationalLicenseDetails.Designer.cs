namespace DVLD.Licenses.InternationalDrivingLicense
{
    partial class InternationalLicenseDetails
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
            this.InternationalLicenseCard = new DVLD.Licenses.InternationalDrivingLicense.Controls.InternationalLicenseCard();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InternationalLicenseCard
            // 
            this.InternationalLicenseCard.Location = new System.Drawing.Point(12, 12);
            this.InternationalLicenseCard.Name = "InternationalLicenseCard";
            this.InternationalLicenseCard.Size = new System.Drawing.Size(611, 408);
            this.InternationalLicenseCard.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(516, 435);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(106, 37);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // InternationalLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 484);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.InternationalLicenseCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InternationalLicenseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "International License Details";
            this.Load += new System.EventHandler(this.InternationalLicenseDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.InternationalLicenseCard InternationalLicenseCard;
        private System.Windows.Forms.Button Close;
    }
}