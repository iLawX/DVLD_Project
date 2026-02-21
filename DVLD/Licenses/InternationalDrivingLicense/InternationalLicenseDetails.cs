using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.InternationalDrivingLicense
{
    public partial class InternationalLicenseDetails : Form
    {
        private int _internationalLicenseID;
        public InternationalLicenseDetails(int internationalLicenseID)
        {
            InitializeComponent();
            _internationalLicenseID = internationalLicenseID;
        }

        private void InternationalLicenseDetails_Load(object sender, EventArgs e)
        {
            InternationalLicenseCard.LoadInternationalLicense(_internationalLicenseID);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
