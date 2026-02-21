namespace DVLD.Licenses.LocalDrivingLicense.Controls
{
    partial class LicenseCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilterBox = new System.Windows.Forms.GroupBox();
            this.Filter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LicenseCard = new DVLD.Licenses.Controls.LicenseCard();
            this.Search = new System.Windows.Forms.Button();
            this.FilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterBox
            // 
            this.FilterBox.BackColor = System.Drawing.SystemColors.Control;
            this.FilterBox.Controls.Add(this.Search);
            this.FilterBox.Controls.Add(this.Filter);
            this.FilterBox.Controls.Add(this.label2);
            this.FilterBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.FilterBox.Location = new System.Drawing.Point(0, 3);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(688, 86);
            this.FilterBox.TabIndex = 1;
            this.FilterBox.TabStop = false;
            this.FilterBox.Text = "Filter:";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Filter.Location = new System.Drawing.Point(288, 28);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(173, 33);
            this.Filter.TabIndex = 0;
            this.Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Filter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(158, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "License ID:";
            // 
            // LicenseCard
            // 
            this.LicenseCard.Location = new System.Drawing.Point(0, 92);
            this.LicenseCard.Name = "LicenseCard";
            this.LicenseCard.Size = new System.Drawing.Size(688, 486);
            this.LicenseCard.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Image = global::DVLD.Properties.Resources.Search;
            this.Search.Location = new System.Drawing.Point(467, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(50, 50);
            this.Search.TabIndex = 1;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.LicenseCard);
            this.Name = "LicenseCardWithFilter";
            this.Size = new System.Drawing.Size(688, 578);
            this.FilterBox.ResumeLayout(false);
            this.FilterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Licenses.Controls.LicenseCard LicenseCard;
        private System.Windows.Forms.GroupBox FilterBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.Label label2;
    }
}
