using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using DVLD_Business;

namespace DVLD.Licenses.Controls
{
    public partial class LicenseCard : UserControl
    {
        private License _license;
        public License License { get { return _license; } }
        private int _licenseID = -1;
        public int LicenseID { get { return _licenseID; } }
        public LicenseCard()
        {
            InitializeComponent();
        }
        private void ResetCard()
        {
            _licenseID = -1;
            Avatar.Image = null;
            Class.Text = "";
            FullName.Text = "";
            ID.Text = "";
            NationalNo.Text = "";
            Gender.Text = "";
            IssueDate.Text = "";
            IssueReason.Text = "";
            Notes.Text = "";
            IsActive.Text = "";
            DateOfBirth.Text = "";
            DriverID.Text = "";
            ExpirationDate.Text = "";
            IsDetained.Text = "";
        }
        private void LoadPersonImage()
        {
            if (_license.Driver.Person.ImagePath == "")
            {
                if (_license.Driver.Person.Gender == Person.GenderType.Male)
                {
                    Avatar.Image = Resources.Male_Avatar;
                }
                else
                {
                    Avatar.Image = Resources.Female_Avatar;
                }
            }
            else
            {
                Avatar.ImageLocation = _license.Driver.Person.ImagePath;
            }
        }
        private void LoadLicenseData()
        {
            if (_license == null)
            {
                MessageBox.Show("License not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetCard();
                return;
            }

            _licenseID = _license.ID;
            LoadPersonImage();
            Class.Text = _license.LicenseClass.Name;
            FullName.Text = _license.Driver.Person.FullName;
            ID.Text = _license.ID.ToString();
            NationalNo.Text = _license.Driver.Person.NationalNo;
            Gender.Text = _license.Driver.Person.Gender == Person.GenderType.Male ? "Male" : "Female"; 
            IssueDate.Text = _license.IssueDate.ToShortDateString();
            IssueReason.Text = _license.GetIssueReasonText();
            Notes.Text = _license.Notes == "" ? "N/A" : _license.Notes;
            IsActive.Text = _license.IsActive ? "Yes" : "No";
            DateOfBirth.Text = _license.Driver.Person.DateOfBirth.ToShortDateString();
            DriverID.Text = _license.DriverID.ToString();
            ExpirationDate.Text = _license.ExpirationDate.ToShortDateString();
            IsDetained.Text = _license.IsDetained() ? "Yes" : "No";
        }
        public void LoadLicense(int licenseID)
        {
            _license = License.GetByID(licenseID);

            LoadLicenseData();
        }
    }
}
