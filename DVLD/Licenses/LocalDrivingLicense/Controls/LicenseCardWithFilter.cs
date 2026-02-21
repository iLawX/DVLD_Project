using DVLD.Licenses.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD.Licenses.LocalDrivingLicense.Controls
{
    public partial class LicenseCardWithFilter : UserControl
    {
        public event Action<int> SearchClicked;
        public License License { get { return LicenseCard.License; } }
        public int LicenseID { get { return LicenseCard.LicenseID; } }
        public bool FilterEnabled
        {
            get { return FilterBox.Enabled; }
            set { FilterBox.Enabled = value; }
        }
        public LicenseCardWithFilter()
        {
            InitializeComponent();
        }
        private void Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)Keys.Enter)
            {
                Search.PerformClick();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Filter.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a License ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseID = Convert.ToInt32(Filter.Text.Trim());

            LicenseCard.LoadLicense(licenseID);

            SearchClicked?.Invoke(LicenseID);
        }
        public void LoadLicense(int licenseID)
        {
            LicenseCard.LoadLicense(licenseID);
            Filter.Text = licenseID.ToString();
            FilterBox.Enabled = false;
        }
    }
}
