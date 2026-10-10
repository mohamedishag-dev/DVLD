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
    public partial class frmDetainedLicense : Form
    {
        private int _LicenseID = -1;
        private clsLicense _License;
        public frmDetainedLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we don't continue becuase the from is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon");
                return;
            }


            if (_License == null)
            {
                return;
            }


            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            float FineFees = Convert.ToSingle(txtFineFees.Text.Trim());
            int DetainID = _License.Detain(FineFees, clsGlobal.CurrentUser.UserID);

            if (DetainID != -1)
            {

                btnDetain.Enabled = false;
                llShowNewLicenseInfo.Enabled = true;
                lblDetainID.Text = _License.ApplicationID.ToString();
                MessageBox.Show("Licensed Detaied Successfully with ID = " + DetainID, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("License was not Replaced!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void frmDetainedLicense_Load(object sender, EventArgs e)
        {
            btnDetain.Enabled = false;
            llShowNewLicenseInfo.Enabled = false;
            llShowLicensesHistory.Enabled = false;

            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName.ToString();

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _License = clsLicense.Find(_LicenseID);

            if (_License == null)
            {
                btnDetain.Enabled = false;
                llShowNewLicenseInfo.Enabled = false;
                llShowLicensesHistory.Enabled = false;
                return;
            }

            llShowLicensesHistory.Enabled = (_License != null);

            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not Active, Choose another noe.",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("The selected license is already detained, Choose another noe.",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnDetain.Enabled = (_License != null);
            lblLicenseID.Text = _License.LicenseID.ToString();

        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }
        }
    }
}
