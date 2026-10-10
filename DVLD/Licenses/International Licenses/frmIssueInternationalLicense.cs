using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses.International_Licenses
{
    public partial class frmIssueInternationalLicense : Form
    {
        private int _LicenseID = -1;
        private clsInternationalLicense _InternationalLicense;
        public frmIssueInternationalLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;

        }

        public frmIssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseID(_LicenseID);

            if (InternationalLicenseID != -1)
            {
                MessageBox.Show("Person already has International License before with LicenseID=" + InternationalLicenseID,
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }


            if (MessageBox.Show("Are you sure you want to issue the license!", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            if (_InternationalLicense == null)
            {
                _InternationalLicense = new clsInternationalLicense();
            }

            _InternationalLicense.IssueInternationalLicense(_LicenseID, clsGlobal.CurrentUser.UserID);


            if (_InternationalLicense != null)
            {

                btnIssue.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
                lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
                lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();

                MessageBox.Show("International License Issue Successfully with ID=" + _InternationalLicense.InternationalLicenseID,
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("License was not Issued!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddInternationalLicense_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();

            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            btnIssue.Enabled = false;
            llShowLicenseInfo.Enabled = false;
            llShowLicensesHistory.Enabled = (_LicenseID != -1);

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            if (clsLicense.Find(obj) == null)
            {

                btnIssue.Enabled = false;
                llShowLicensesHistory.Enabled = false;
                return;
            }

            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("This driver license has expired.", "Expired License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("This driver license is not active.", "Inactive License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            if (obj != -1)
            {
                _LicenseID = obj;
                btnIssue.Enabled = true;
                llShowLicensesHistory.Enabled = true;
                lblLocalLicenseID.Text = obj.ToString();

            }


        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;

            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.ShowDialog();

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverInternationalLicenseInfo frm = new frmDriverInternationalLicenseInfo(_InternationalLicense.InternationalLicenseID);
            frm.ShowDialog();

        }


    }
}