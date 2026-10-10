using DVLD.Licenses;
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

namespace DVLD.Applications.Replace_Lost_Or_Demaged_License
{
    public partial class frmReplacementforDamagedDrivingLicense : Form
    {
        private int _LicenseID = -1;
        private clsLicense _License;

        public frmReplacementforDamagedDrivingLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueRepacement_Click(object sender, EventArgs e)
        {
            if (_License == null)
            {
                return;
            }


            if (MessageBox.Show("Are you sure you want to Renew the license!", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLicense.enIssueReason IssueReason;

            if (rbDamagedLicense.Checked)
                IssueReason = clsLicense.enIssueReason.ReplacementforDamaged;
            else
                 IssueReason = clsLicense.enIssueReason.ReplacementforLost;


            _License = _License.Replace(IssueReason, clsGlobal.CurrentUser.UserID);

            if (_License != null)
            {

                gbReplacement.Enabled = false;
                btnIssueRepacement.Enabled = false;
                llShowNewLicenseInfo.Enabled = true;
                lblReplacedLicenseID.Text = _License.LicenseID.ToString();
                lblReplacedApplicationID.Text = _License.ApplicationID.ToString();
                MessageBox.Show("Licensed Replaced Successfully with ID = " + _License.LicenseID, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("License was not Replaced!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _License = clsLicense.Find(_LicenseID);

            if (_License == null)
            {
                btnIssueRepacement.Enabled = false;
                llShowNewLicenseInfo.Enabled = false;
                llShowLicensesHistory.Enabled = false;
                return;
            }

            llShowLicensesHistory.Enabled = (_License != null);

            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not Active, Choose an active license." ,
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("The selected license is detained. Only released licenses are allowed.",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnIssueRepacement.Enabled = (_License != null);
            lblOldLicenseID.Text = _License.LicenseID.ToString();

        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicense.Find(_LicenseID).DriverInfo.PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_License.LicenseID);
            frm.ShowDialog();
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblAppicationFees.Text= clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).Fees.ToString();

        }

        private void frmReplacementforDamagedDrivingLicense_Load(object sender, EventArgs e)
        {
            btnIssueRepacement.Enabled = false;
            llShowNewLicenseInfo.Enabled = false;
            llShowLicensesHistory.Enabled = false;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblAppicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName.ToString();

        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblAppicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceLostDrivingLicense).Fees.ToString();

        }


    }
}
