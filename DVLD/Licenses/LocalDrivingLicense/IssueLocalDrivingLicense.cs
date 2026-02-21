using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using DVLD.General;

namespace DVLD.Licenses
{
    public partial class IssueLocalDrivingLicense : Form
    {
        private int _locaApplicationID;

        public IssueLocalDrivingLicense(int localApplicationID)
        {
            InitializeComponent();
            _locaApplicationID = localApplicationID;
        }

        private void IssueLicense_Load(object sender, EventArgs e)
        {
            LocalApplicationCard.LoadLocalApplication(_locaApplicationID);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (LocalApplicationCard.LocalApplication.IssueLicense(Notes.Text.Trim(), Global.CurrentUser.UserID))
            {
                MessageBox.Show("License issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to issue license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
