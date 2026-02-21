namespace DVLD.Licenses.DetainLicense
{
    partial class DetainLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.LicenseCardWithFilter = new DVLD.Licenses.LocalDrivingLicense.Controls.LicenseCardWithFilter();
            this.DetainedLicenseCard = new DVLD.Licenses.DetainLicense.Controls.DetainedLicenseCard();
            this.ShowLicensesHistory = new System.Windows.Forms.Button();
            this.ShowLicense = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Detain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain License";
            // 
            // LicenseCardWithFilter
            // 
            this.LicenseCardWithFilter.FilterEnabled = true;
            this.LicenseCardWithFilter.Location = new System.Drawing.Point(12, 57);
            this.LicenseCardWithFilter.Name = "LicenseCardWithFilter";
            this.LicenseCardWithFilter.Size = new System.Drawing.Size(688, 578);
            this.LicenseCardWithFilter.TabIndex = 0;
            this.LicenseCardWithFilter.SearchClicked += new System.Action<int>(this.LicenseCardWithFilter_SearchClicked);
            // 
            // DetainedLicenseCard
            // 
            this.DetainedLicenseCard.Location = new System.Drawing.Point(12, 641);
            this.DetainedLicenseCard.Name = "DetainedLicenseCard";
            this.DetainedLicenseCard.Size = new System.Drawing.Size(688, 222);
            this.DetainedLicenseCard.TabIndex = 1;
            // 
            // ShowLicensesHistory
            // 
            this.ShowLicensesHistory.Enabled = false;
            this.ShowLicensesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicensesHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicensesHistory.Location = new System.Drawing.Point(12, 869);
            this.ShowLicensesHistory.Name = "ShowLicensesHistory";
            this.ShowLicensesHistory.Size = new System.Drawing.Size(230, 37);
            this.ShowLicensesHistory.TabIndex = 5;
            this.ShowLicensesHistory.Text = "Show Licenses History";
            this.ShowLicensesHistory.UseVisualStyleBackColor = true;
            this.ShowLicensesHistory.Click += new System.EventHandler(this.ShowLicensesHistory_Click);
            // 
            // ShowLicense
            // 
            this.ShowLicense.Enabled = false;
            this.ShowLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicense.Location = new System.Drawing.Point(249, 869);
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(160, 37);
            this.ShowLicense.TabIndex = 4;
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.UseVisualStyleBackColor = true;
            this.ShowLicense.Click += new System.EventHandler(this.ShowLicense_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(476, 869);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(109, 37);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Detain
            // 
            this.Detain.Enabled = false;
            this.Detain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detain.Location = new System.Drawing.Point(591, 869);
            this.Detain.Name = "Detain";
            this.Detain.Size = new System.Drawing.Size(109, 37);
            this.Detain.TabIndex = 2;
            this.Detain.Text = "Detain";
            this.Detain.UseVisualStyleBackColor = true;
            this.Detain.Click += new System.EventHandler(this.Detain_Click);
            // 
            // DetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 920);
            this.Controls.Add(this.ShowLicensesHistory);
            this.Controls.Add(this.ShowLicense);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Detain);
            this.Controls.Add(this.DetainedLicenseCard);
            this.Controls.Add(this.LicenseCardWithFilter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detain License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LocalDrivingLicense.Controls.LicenseCardWithFilter LicenseCardWithFilter;
        private Controls.DetainedLicenseCard DetainedLicenseCard;
        private System.Windows.Forms.Button ShowLicensesHistory;
        private System.Windows.Forms.Button ShowLicense;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Detain;
    }
}