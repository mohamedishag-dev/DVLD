using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Rlease_Detained_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private int _SelectedLicenseID = -1;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            llShowLicensesHistory.Enabled = (_SelectedLicenseID != -1);
        }

        private void _FillDetainInfo()
        {
            lblDetnainID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lblDetainDate.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();

            lblLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.LicenseID.ToString();
            lblCreatedBy.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.CreatedByUserID.ToString();
            lblFineFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {

            if (_SelectedLicenseID != -1)
            {
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
                _FillDetainInfo();
            }

            llShowReleasedLicenseInfo.Enabled = false;
            btnRelease.Enabled = (_SelectedLicenseID != -1); ;
            llShowLicensesHistory.Enabled = (_SelectedLicenseID != -1);
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            if (_SelectedLicenseID == -1)
            {
                ResetDetainInfo();
                btnRelease.Enabled = false;
                llShowLicensesHistory.Enabled = false;
                llShowReleasedLicenseInfo.Enabled = false;
                return;
            }

            llShowLicensesHistory.Enabled = (_SelectedLicenseID != -1);

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                ResetDetainInfo();
                MessageBox.Show("Selected license is not detained, Choose another one: ",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillDetainInfo();
            btnRelease.Enabled = (_SelectedLicenseID != -1);
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicense.FindByID(_SelectedLicenseID).DriverInfo.PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.ShowDialog();

        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to release this detained license?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int ApplicationID = -1;
            bool IsReleased = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, ref ApplicationID);
            lblApplicationID.Text = ApplicationID.ToString();

            if (!IsReleased)
            {
                MessageBox.Show("Faild to release the Detain License", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            btnRelease.Enabled = false;
            llShowReleasedLicenseInfo.Enabled = true;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            MessageBox.Show("Detained License release Successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}