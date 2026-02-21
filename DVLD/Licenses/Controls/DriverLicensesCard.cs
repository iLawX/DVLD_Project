using DVLD.Licenses.InternationalDrivingLicense;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Controls
{
    public partial class DriverLicensesCard : UserControl
    {
        private Driver _driver;
        public Driver Driver { get { return _driver; } }
        public DriverLicensesCard()
        {
            InitializeComponent();
        }
        private void LoadLocalLicenes()
        {
            DataView localLicsnes = _driver.GetAllLocalLicenses().DefaultView;
            LocalLicensesList.DataSource = localLicsnes;

            LocalLicensesList.Columns["ClassName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LocalLicensesList.Columns["IssueDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LocalLicensesList.Columns["ExpirationDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            LocalLicensesCount.Text = localLicsnes.Count.ToString();

        }
        private void LoadInternationalLicenes()
        {
            DataView internationalLicsnes = _driver.GetAllInternationalLicenses().DefaultView;
            InternationalLicensesList.DataSource = internationalLicsnes;

            InternationalLicensesList.Columns["IssueDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            InternationalLicensesList.Columns["ExpirationDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            InternationalLicensesCount.Text = internationalLicsnes.Count.ToString();
        }
        private void LoadLicensesData()
        {
            if (_driver == null)
            {
                MessageBox.Show("Driver not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadLocalLicenes();
            LoadInternationalLicenes();
        }
        public void LoadDriverLicenses(int driverID)
        {
            _driver = Driver.GetByID(driverID);

            LoadLicensesData();
        }
        public void LoadPersonLicenses(int personID)
        {
            _driver = Driver.GetByPersonID(personID);

            LoadLicensesData();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Local)
            {
                if (LocalLicensesList.SelectedRows.Count == 0)
                {
                    MessageBox.Show($"Please select an application to show license details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int licenseID = (int)LocalLicensesList.SelectedRows[0].Cells["ID"].Value;
                LicenseDetails license = new LicenseDetails(licenseID);
                license.Show();
            }
            else
            {
                if (InternationalLicensesList.SelectedRows.Count == 0)
                {
                    MessageBox.Show($"Please select an application to show international license details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int licenseID = (int)InternationalLicensesList.SelectedRows[0].Cells["ID"].Value;
                InternationalLicenseDetails form = new InternationalLicenseDetails(licenseID);
                form.ShowDialog();
            }
        }
    }
}
