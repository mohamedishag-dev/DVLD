using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Rlease_Detained_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private int _LicenseID = -1;
        private clsLicense _License;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            btnRelease.Enabled = false;
            llShowReleasedLicenseInfo.Enabled = false;
            llShowLicensesHistory.Enabled = (_LicenseID != -1);

            if (_LicenseID != -1)
            {
                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
                ctrlDriverLicenseInfoWithFilter1.Enabled = false;
            }

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _License = clsLicense.FindByID(_LicenseID);

            if (_License == null)
            {
                ResetDetainInfo();
                btnRelease.Enabled = false;
                llShowReleasedLicenseInfo.Enabled = false;
                llShowLicensesHistory.Enabled = false;
                return;
            }

            llShowLicensesHistory.Enabled = (_License != null);

            if (!_License.IsDetained)
            {
                ResetDetainInfo();
                MessageBox.Show("Selected license is not detained, Choose another one: ",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillDetainInfo();
            btnRelease.Enabled = (_License != null);
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicense.FindByID(_LicenseID).DriverInfo.PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.ShowDialog();

        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_License.LicenseID);
            frm.ShowDialog();

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (_License == null)
            {
                return;
            }


            if (MessageBox.Show("Are you sure you want to release this detained license?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            if (_License.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID))
            {

                btnRelease.Enabled = false;
                llShowReleasedLicenseInfo.Enabled = true;
                lblApplicationID.Text = clsDetainedLicense.FindByID(_License.DetainedInfo.DetainID).ReleaseApplicationID.ToString();
                MessageBox.Show("Renew License Successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("License was not Renew!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillDetainInfo()
        {
            lblDetnainID.Text = _License.DetainedInfo.DetainID.ToString();
            lblDetainDate.Text = _License.DetainedInfo.DetainDate.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();

            lblLicenseID.Text = _License.DetainedInfo.LicenseID.ToString();
            lblCreatedBy.Text = _License.DetainedInfo.CreatedByUserID.ToString();
            lblFineFees.Text = _License.DetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text.ToString()) + Convert.ToSingle(lblFineFees.Text.ToString())).ToString();

        }

        public void ResetDetainInfo()
        {

            lblDetnainID.Text = "[???]";
            lblDetainDate.Text = "[??/??/????]";
            lblApplicationFees.Text = "[???]";
            lblLicenseID.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            lblFineFees.Text = "[???]";
            lblTotalFees.Text = "[???]";
            lblApplicationID.Text = "[???]";

        }


    }
}