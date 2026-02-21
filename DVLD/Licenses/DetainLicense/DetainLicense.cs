using DVLD.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.DetainLicense
{
    public partial class DetainLicense : Form
    {
        public DetainLicense()
        {
            InitializeComponent();
        }

        private void LicenseCardWithFilter_SearchClicked(int licenseID)
        {
            Detain.Enabled = false;
            ShowLicensesHistory.Enabled = licenseID != -1;
            DetainedLicenseCard.ResetCard();

            if (licenseID == -1) return;

            if (LicenseCardWithFilter.License.IsDetained())
            {
                MessageBox.Show("The selected license is already detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DetainedLicenseCard.LoadDetainedLicense(LicenseCardWithFilter.LicenseID);
                ShowLicense.Enabled = true;
                return;
            }

            if (!LicenseCardWithFilter.License.IsActive)
            {
                MessageBox.Show("The selected license is not active and cannot be detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Detain.Enabled = true;
        }
        private void Detain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain the selected license?", "Confirm Detention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            if (LicenseCardWithFilter.License.Detain(DetainedLicenseCard.FineFeesValue, Global.CurrentUser.UserID))
            {
                MessageBox.Show("License detained successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LicenseCardWithFilter.FilterEnabled = false;
                DetainedLicenseCard.LoadDetainedLicense(LicenseCardWithFilter.LicenseID);
                Detain.Enabled = false;
                ShowLicense.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to detain the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowLicense_Click(object sender, EventArgs e)
        {
            LicenseDetails form = new LicenseDetails(LicenseCardWithFilter.LicenseID);
            form.ShowDialog();
        }
        private void ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistory form = new LicensesHistory(LicenseCardWithFilter.License.Driver.PersonID);
            form.ShowDialog();
        }
    }
}
