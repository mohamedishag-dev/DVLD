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

namespace DVLD.Applications.Rlease_Detained_License.Controls
{
    public partial class ctrlDetianInfo : UserControl
    {
        private int _DetainedLicenseID;
        private clsDetainedLicense _DetainedLicense;
        public ctrlDetianInfo()
        {
            InitializeComponent();
        }

        public void LoadDetainCard(int DetainID)
        {

            _DetainedLicense = clsDetainedLicense.FindByID(DetainID);
            if (_DetainedLicense == null)
            {
                _DetainedLicenseID = -1;
                ResetDetainInfo();
                MessageBox.Show("No Detain with DetainID = " + DetainID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillDetainInfo();

        }

        private void _FillDetainInfo()
        {
            _DetainedLicenseID = _DetainedLicense.DetainID;
            lblDetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();
            
            lblLicenseID.Text = _DetainedLicense.LicenseID.ToString();
            lblCreatedBy.Text = _DetainedLicense.CreatedByUserID.ToString();
            lblFineFees.Text = _DetainedLicense.FineFees.ToString();
            lblTotalFees.Text = Convert.ToSingle(lblApplicationFees.Text.ToString()) + Convert.ToSingle(lblFineFees.Text.ToString()).ToString();

        }

        public void ResetDetainInfo()
        {

            _DetainedLicenseID = -1;
            lblDetainDate.Text = "[??/??/????]";
            lblApplicationFees.Text = "[???]";
            lblLicenseID.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            lblFineFees.Text = "[???]";
            lblTotalFees.Text = "[???]";

        }


    }
}