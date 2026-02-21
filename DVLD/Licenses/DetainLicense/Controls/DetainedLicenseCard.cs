using DVLD.General;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.DetainLicense.Controls
{
    public partial class DetainedLicenseCard : UserControl
    {
        private DetainedLicense _detainedLicense;
        public DetainedLicense DetainedLicense { get { return _detainedLicense; } }
        public Decimal FineFeesValue { get { return FineFees.Value; } }
        public DetainedLicenseCard()
        {
            InitializeComponent();
        }
        public void ResetCard()
        {
            DetainID.Text = "";
            LicenseID.Text = "";
            DetainDate.Text = "";
            CreatedBy.Text = "";
            FineFees.Value = 0m;
            FineFees.Enabled = true;
        }
        private void LoadDetainedLicenseData()
        {
            if (_detainedLicense == null)
            {
                MessageBox.Show("Detained license not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetCard();
                return;
            }

            DetainID.Text = _detainedLicense.ID.ToString();
            LicenseID.Text = _detainedLicense.LicenseID.ToString();
            DetainDate.Text = _detainedLicense.DetentionDate.ToShortDateString();
            CreatedBy.Text = _detainedLicense.DetainedByUser.Username;
            FineFees.Value = _detainedLicense.FineFees;
            FineFees.Enabled = false;
        }
        public void LoadDetainedLicense(int licenseID)
        {
            _detainedLicense = DetainedLicense.GetByLicenseID(licenseID);

            LoadDetainedLicenseData();
        }

        private void DetainedLicenseCard_Load(object sender, EventArgs e)
        {
            CreatedBy.Text = Global.CurrentUser.Username;
        }
    }
}
