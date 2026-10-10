using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Renew_Local_License
{
    public partial class frmRenewLocalLicenseApplication : Form
    {
        private int _LicenseID = -1;
        private clsLicense _License;
        public frmRenewLocalLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {

            if (_License == null)
            {
                return;
            }


            if (MessageBox.Show("Are you sure you want to Renew the license!", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _License = _License.RenewLicense(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

            if (_License != null)
            {

                btnRenew.Enabled = false;
                llShowNewLicenseInfo.Enabled = true;
                lblRenewedLicenseID.Text = _License.LicenseID.ToString();
                lblRenewApplicationID.Text = _License.ApplicationID.ToString();
                MessageBox.Show("Renew License Successfully with ID = " + _License.LicenseID, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("License was not Renew!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _License = clsLicense.Find(_LicenseID);

            if (_License == null)
            {
                btnRenew.Enabled = false;
                llShowNewLicenseInfo.Enabled = false;
                llShowLicensesHistory.Enabled = false;
                return;
            }

            llShowLicensesHistory.Enabled = (_License != null);

            if (!_License.IsLicenseExpired())
            {
                MessageBox.Show("Selected license is not yet expiared, it will expire one: " + _License.ExpirationDate.ToShortDateString(),
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnRenew.Enabled = (_License != null);
            lblOldLicenseID.Text = _License.LicenseID.ToString();
            lblLicenseFees.Text = clsLicenseClass.Find(_License.LicenseClassID).ClassFees.ToString();
            lblTotalFees.Text = (int.Parse(lblApplicationFees.Text.Trim()) + int.Parse(lblLicenseFees.Text.Trim())).ToString();

        }

        private void frmRenewLocalLicenseApplication_Load(object sender, EventArgs e)
        {
            btnRenew.Enabled = false;
            llShowNewLicenseInfo.Enabled = false;
            llShowLicensesHistory.Enabled = false;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees.ToString();

            lblExpirationDate.Text = DateTime.Now.AddYears(10).ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName.ToString();

        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicense.Find(_LicenseID).DriverInfo.PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_License.LicenseID);
            frm.ShowDialog();

        }


    
    }
}