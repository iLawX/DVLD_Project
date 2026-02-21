namespace DVLD.Licenses
{
    partial class LicensesHistory
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
            this.PersonCard = new DVLD.People.Controls.PersonCard();
            this.DriverLicensedCard = new DVLD.Licenses.Controls.DriverLicensesCard();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(983, 828);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(105, 43);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PersonCard
            // 
            this.PersonCard.Location = new System.Drawing.Point(103, 0);
            this.PersonCard.Name = "PersonCard";
            this.PersonCard.Size = new System.Drawing.Size(914, 490);
            this.PersonCard.TabIndex = 0;
            // 
            // DriverLicensedCard
            // 
            this.DriverLicensedCard.Location = new System.Drawing.Point(12, 496);
            this.DriverLicensedCard.Name = "DriverLicensedCard";
            this.DriverLicensedCard.Size = new System.Drawing.Size(1076, 326);
            this.DriverLicensedCard.TabIndex = 4;
            // 
            // LicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 883);
            this.Controls.Add(this.DriverLicensedCard);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PersonCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Licenses History";
            this.Load += new System.EventHandler(this.LicensesHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.PersonCard PersonCard;
        private System.Windows.Forms.Button Close;
        private Controls.DriverLicensesCard DriverLicensedCard;
    }
}