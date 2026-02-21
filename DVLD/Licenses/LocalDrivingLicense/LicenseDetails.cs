using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class LicenseDetails : Form
    {
        private int _licenseID;
        public LicenseDetails(int licenseID)
        {
            InitializeComponent();
            _licenseID = licenseID;
        }

        private void LicenseDetails_Load(object sender, EventArgs e)
        {
            LicenseCard.LoadLicense(_licenseID);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
