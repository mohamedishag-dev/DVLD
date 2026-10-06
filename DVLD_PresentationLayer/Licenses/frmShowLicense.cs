using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses
{
    public partial class frmShowLicense : Form
    {
        private int _LicenseID = -1;
        private int _LicenseClass = -1;
        private clsLicense LicenseInfo;
        private string _NationalNo = "";

        public frmShowLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        public frmShowLicense(string NationalNo, int LicenseClass)
        {
            InitializeComponent();
            _NationalNo = NationalNo;
            _LicenseClass = LicenseClass;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowLicense_Load(object sender, EventArgs e)
        {
            if (_LicenseID != -1)
                ctrlLicenseCard1.LoadLicenseCard(_LicenseID);
            else
                ctrlLicenseCard1.LoadLicenseCard(_NationalNo, _LicenseClass);

        }

    }
}
