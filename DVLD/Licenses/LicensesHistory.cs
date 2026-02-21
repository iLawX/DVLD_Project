using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD.Licenses
{
    public partial class LicensesHistory : Form
    {
        private int _personID = -1;
        private string _nationalNo;
        public LicensesHistory(int personID)
        {
            InitializeComponent();
            _personID = personID;
        }
        public LicensesHistory(string nationalNo)
        {
            InitializeComponent();
            _nationalNo = nationalNo;
        }
        private void LicensesHistory_Load(object sender, EventArgs e)
        {
            if (_personID != -1)
            {
                PersonCard.LoadPerson(_personID);
            }
            else
            {
                PersonCard.LoadPerson(_nationalNo);
            }

            if (PersonCard.PersonID != -1)
            {
                DriverLicensedCard.LoadPersonLicenses(PersonCard.PersonID);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
