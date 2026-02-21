namespace DVLD.Licenses.Controls
{
    partial class DriverLicensesCard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Local = new System.Windows.Forms.TabPage();
            this.LocalLicensesCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalLicensesList = new System.Windows.Forms.DataGridView();
            this.International = new System.Windows.Forms.TabPage();
            this.InternationalLicensesCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InternationalLicensesList = new System.Windows.Forms.DataGridView();
            this.ActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalLicensesList)).BeginInit();
            this.International.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternationalLicensesList)).BeginInit();
            this.ActionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 326);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Local);
            this.tabControl1.Controls.Add(this.International);
            this.tabControl1.Location = new System.Drawing.Point(3, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 291);
            this.tabControl1.TabIndex = 1;
            // 
            // Local
            // 
            this.Local.Controls.Add(this.LocalLicensesCount);
            this.Local.Controls.Add(this.label3);
            this.Local.Controls.Add(this.LocalLicensesList);
            this.Local.Location = new System.Drawing.Point(4, 34);
            this.Local.Name = "Local";
            this.Local.Padding = new System.Windows.Forms.Padding(3);
            this.Local.Size = new System.Drawing.Size(1059, 253);
            this.Local.TabIndex = 0;
            this.Local.Text = "Local";
            this.Local.UseVisualStyleBackColor = true;
            // 
            // LocalLicensesCount
            // 
            this.LocalLicensesCount.AutoSize = true;
            this.LocalLicensesCount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalLicensesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.LocalLicensesCount.Location = new System.Drawing.Point(124, 222);
            this.LocalLicensesCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocalLicensesCount.Name = "LocalLicensesCount";
            this.LocalLicensesCount.Size = new System.Drawing.Size(25, 28);
            this.LocalLicensesCount.TabIndex = 28;
            this.LocalLicensesCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(5, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "# Records: ";
            // 
            // LocalLicensesList
            // 
            this.LocalLicensesList.AllowUserToAddRows = false;
            this.LocalLicensesList.AllowUserToDeleteRows = false;
            this.LocalLicensesList.AllowUserToResizeColumns = false;
            this.LocalLicensesList.AllowUserToResizeRows = false;
            this.LocalLicensesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalLicensesList.BackgroundColor = System.Drawing.Color.White;
            this.LocalLicensesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalLicensesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LocalLicensesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalLicensesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LocalLicensesList.ColumnHeadersHeight = 50;
            this.LocalLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LocalLicensesList.ContextMenuStrip = this.ActionsMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalLicensesList.DefaultCellStyle = dataGridViewCellStyle2;
            this.LocalLicensesList.EnableHeadersVisualStyles = false;
            this.LocalLicensesList.Location = new System.Drawing.Point(5, 6);
            this.LocalLicensesList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LocalLicensesList.MultiSelect = false;
            this.LocalLicensesList.Name = "LocalLicensesList";
            this.LocalLicensesList.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalLicensesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LocalLicensesList.RowHeadersVisible = false;
            this.LocalLicensesList.RowHeadersWidth = 25;
            this.LocalLicensesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LocalLicensesList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalLicensesList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.LocalLicensesList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalLicensesList.RowTemplate.DividerHeight = 2;
            this.LocalLicensesList.RowTemplate.Height = 40;
            this.LocalLicensesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalLicensesList.Size = new System.Drawing.Size(1049, 204);
            this.LocalLicensesList.TabIndex = 0;
            // 
            // International
            // 
            this.International.Controls.Add(this.InternationalLicensesCount);
            this.International.Controls.Add(this.label2);
            this.International.Controls.Add(this.InternationalLicensesList);
            this.International.Location = new System.Drawing.Point(4, 34);
            this.International.Name = "International";
            this.International.Padding = new System.Windows.Forms.Padding(3);
            this.International.Size = new System.Drawing.Size(1059, 253);
            this.International.TabIndex = 1;
            this.International.Text = "International";
            this.International.UseVisualStyleBackColor = true;
            // 
            // InternationalLicensesCount
            // 
            this.InternationalLicensesCount.AutoSize = true;
            this.InternationalLicensesCount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternationalLicensesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.InternationalLicensesCount.Location = new System.Drawing.Point(124, 222);
            this.InternationalLicensesCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InternationalLicensesCount.Name = "InternationalLicensesCount";
            this.InternationalLicensesCount.Size = new System.Drawing.Size(25, 28);
            this.InternationalLicensesCount.TabIndex = 31;
            this.InternationalLicensesCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(5, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "# Records: ";
            // 
            // InternationalLicensesList
            // 
            this.InternationalLicensesList.AllowUserToAddRows = false;
            this.InternationalLicensesList.AllowUserToDeleteRows = false;
            this.InternationalLicensesList.AllowUserToResizeColumns = false;
            this.InternationalLicensesList.AllowUserToResizeRows = false;
            this.InternationalLicensesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InternationalLicensesList.BackgroundColor = System.Drawing.Color.White;
            this.InternationalLicensesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InternationalLicensesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InternationalLicensesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InternationalLicensesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InternationalLicensesList.ColumnHeadersHeight = 50;
            this.InternationalLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InternationalLicensesList.ContextMenuStrip = this.ActionsMenu;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InternationalLicensesList.DefaultCellStyle = dataGridViewCellStyle5;
            this.InternationalLicensesList.EnableHeadersVisualStyles = false;
            this.InternationalLicensesList.Location = new System.Drawing.Point(5, 7);
            this.InternationalLicensesList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InternationalLicensesList.MultiSelect = false;
            this.InternationalLicensesList.Name = "InternationalLicensesList";
            this.InternationalLicensesList.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InternationalLicensesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.InternationalLicensesList.RowHeadersVisible = false;
            this.InternationalLicensesList.RowHeadersWidth = 25;
            this.InternationalLicensesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InternationalLicensesList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternationalLicensesList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.InternationalLicensesList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InternationalLicensesList.RowTemplate.DividerHeight = 2;
            this.InternationalLicensesList.RowTemplate.Height = 40;
            this.InternationalLicensesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InternationalLicensesList.Size = new System.Drawing.Size(1049, 204);
            this.InternationalLicensesList.TabIndex = 0;
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem});
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(183, 30);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.showPersonDetailsToolStripMenuItem.Text = "Show License";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // DriverLicensesCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "DriverLicensesCard";
            this.Size = new System.Drawing.Size(1076, 326);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Local.ResumeLayout(false);
            this.Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalLicensesList)).EndInit();
            this.International.ResumeLayout(false);
            this.International.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternationalLicensesList)).EndInit();
            this.ActionsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Local;
        private System.Windows.Forms.Label LocalLicensesCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LocalLicensesList;
        private System.Windows.Forms.TabPage International;
        private System.Windows.Forms.Label InternationalLicensesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView InternationalLicensesList;
        private System.Windows.Forms.ContextMenuStrip ActionsMenu;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
    }
}
