using DVLD.Properties;
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

namespace DVLD.Licenses.InternationalDrivingLicense.Controls
{
    public partial class InternationalLicenseCard : UserControl
    {
        private InternationalLicense _internationalLicense;
        public InternationalLicenseCard()
        {
            InitializeComponent();
        }
        public void ResetCard()
        {
            Avatar.Image = null;
            FullName.Text = "";
            InternationalLicenseID.Text = "";
            ApplicationID.Text = "";
            LicenseID.Text = "";
            IsActive.Text = "";
            NationalNo.Text = "";
            DateOfBirth.Text = "";
            Gender.Text = "";
            DriverID.Text = "";
            IssueDate.Text = "";
            ExpirationDate.Text = "";
        }
        private void LoadPersonImage()
        {
            if (_internationalLicense.LocalLicense.Driver.Person.ImagePath == "")
            {
                if (_internationalLicense.LocalLicense.Driver.Person.Gender == Person.GenderType.Male)
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
                Avatar.ImageLocation = _internationalLicense.LocalLicense.Driver.Person.ImagePath;
            }
        }
        private void LoadInternationalData()
        {
            if (_internationalLicense == null)
            {
                MessageBox.Show("International License not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetCard();
                return;
            }

            LoadPersonImage();
            FullName.Text = _internationalLicense.Application.ApplicantName;
            InternationalLicenseID.Text = _internationalLicense.ID.ToString();
            ApplicationID.Text = _internationalLicense.Application.ID.ToString();
            LicenseID.Text = _internationalLicense.LocalDrivingLicenseID.ToString();
            IsActive.Text = _internationalLicense.IsActive ? "Yes" : "No";
            NationalNo.Text = _internationalLicense.LocalLicense.Driver.Person.NationalNo;
            DateOfBirth.Text = _internationalLicense.LocalLicense.Driver.Person.NationalNo;
            Gender.Text = _internationalLicense.LocalLicense.Driver.Person.Gender == Person.GenderType.Male ? "Male" : "Female";
            DriverID.Text = _internationalLicense.DriverID.ToString();
            IssueDate.Text = _internationalLicense.IssueDate.ToShortDateString();
            ExpirationDate.Text = _internationalLicense.ExpirationDate.ToShortDateString();
        }
        public void LoadInternationalLicense(int internationalLicenseID)
        {
            _internationalLicense = InternationalLicense.GetByID(internationalLicenseID);

            LoadInternationalData();
        }
    }
}
