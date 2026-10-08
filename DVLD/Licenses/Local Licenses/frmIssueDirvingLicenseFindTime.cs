using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmIssueDirvingLicenseForTheFirstTime : Form
    {

        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public frmIssueDirvingLicenseForTheFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmIssueDirvingLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            // minimal null checks
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Driving license application not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Notes = txtNotes.Text.Trim();
            int CreatedByUserID = clsGlobal.CurrentUser.UserID;
            int LicenseID = _LocalDrivingLicenseApplication.IssueLicenseForTheFirstTime(Notes, CreatedByUserID);

            if (LicenseID != -1)
            {
                MessageBox.Show(string.Format("Saved License ID = {0}", LicenseID));
                this.Close();
            }
            else
                MessageBox.Show("Erorr: donot Saved License");

        }

    }
}
