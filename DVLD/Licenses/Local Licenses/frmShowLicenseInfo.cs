using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmShowLicenseInfo : Form
    {
        private int _LicenseID = -1;

        public frmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.LoadInfo(_LicenseID);

        }

    }
}
