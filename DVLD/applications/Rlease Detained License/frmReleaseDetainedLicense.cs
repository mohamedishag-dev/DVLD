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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            btnRelease.Enabled = false;
            llShowNewLicenseInfo.Enabled = false;
            llShowLicensesHistory.Enabled = false;

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _License = clsLicense.Find(_LicenseID);

            if (_License == null)
            {
                btnRelease.Enabled = false;
                llShowNewLicenseInfo.Enabled = false;
                llShowLicensesHistory.Enabled = false;
                return;
            }

            llShowLicensesHistory.Enabled = (_License != null);

            if (!_License.IsDetained)
            {
                MessageBox.Show("Selected license is not detained, Choose another one: ",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnRelease.Enabled = (_License != null);
           ctrlDetianInfo1.LoadDetainCard(_License.DetainedInfo.DetainID);
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

        private void btnRelease_Click(object sender, EventArgs e)
        {
            //if (_License == null)
            //{
            //    return;
            //}


            //if (MessageBox.Show("Are you sure you want to Renew the license!", "Confirm",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    return;

            //_License = _License.RenewLicense(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

            //if (_License != null)
            //{

            //    btnRenew.Enabled = false;
            //    llShowNewLicenseInfo.Enabled = true;
            //    lblRenewedLicenseID.Text = _License.LicenseID.ToString();
            //    lblRenewApplicationID.Text = _License.ApplicationID.ToString();
            //    MessageBox.Show("Renew License Successfully with ID = " + _License.LicenseID, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //else
            //    MessageBox.Show("License was not Renew!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
