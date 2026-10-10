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

namespace DVLD.Licenses.International_Licenses
{
    public partial class frmDriverInternationalLicenseInfo : Form
    {
        private int _InternationalLicenseID=-1;
        private clsInternationalLicense _InternationalLicense;

        public frmDriverInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
             _InternationalLicenseID = InternationalLicenseID;
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDriverInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

            ctrlDriverInternationalLicenseInfo1.LoadInternationalLicenseInfo(_InternationalLicenseID);

        }

    }
}
