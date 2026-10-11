using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses.International_Licenses
{
    public partial class frmIssueInternationalLicense : Form
    {
        private int _LicenseID = -1;
        private int _InternationalLicenseID = -1;
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

            if (MessageBox.Show("Are you sure you want to issue the license!", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsInternationalLicense InternationalLicense = new clsInternationalLicense();
            InternationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees;

            InternationalLicense.DriverID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);

            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;


            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnIssueLicense.Enabled = false;
            llShowLicenseInfo.Enabled = true;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            lblApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            lblLocalLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            MessageBox.Show("International License Issue Successfully with ID=" + InternationalLicense.InternationalLicenseID,
                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnIssueLicense.Enabled = false;
            llShowLicenseInfo.Enabled = false;

            if (_LicenseID != -1)
            {
                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            }
            llShowLicensesHistory.Enabled = (_LicenseID != -1);

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            _LicenseID = obj;
            lblLocalLicenseID.Text = _LicenseID.ToString();

            if (_LicenseID == -1)
            {
                btnIssueLicense.Enabled = false;
                return;
            }

            if (clsLicense.FindByID(_LicenseID) == null)
            {
                btnIssueLicense.Enabled = false;
                return;
            }

            llShowLicensesHistory.Enabled = (_LicenseID != -1);

            //check the license class, person could not issue international license without having
            //normal license of class 3.
            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassID != 3)
            {
                MessageBox.Show("Selected license should be Class 3, select another one.", "Inactive License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueLicense.Enabled = false;
                return;
            }

            //check if person already have an active international license
            int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternaionalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueLicense.Enabled = false;
                llShowLicenseInfo.Enabled = false;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                return;
            }


            btnIssueLicense.Enabled = true;

        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLicenseHistory frm = new frmLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverInternationalLicenseInfo frm = new frmDriverInternationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();

        }


    }
}