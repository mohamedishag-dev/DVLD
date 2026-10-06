using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsLicense;

namespace DVLD_PresentationLayer
{
    public partial class frmIssueDirvingLicenseForTheFirstTime : Form
    {
        private clsDriver DriverInfo;
        private clsLicense LicenseInfo;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _DrivingLicenseApp;

        public frmIssueDirvingLicenseForTheFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmIssueDirvingLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadLocalDrivingLicenseApplicationInfo(_LocalDrivingLicenseApplicationID);
            _DrivingLicenseApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            // minimal null checks
            if (_DrivingLicenseApp == null || _DrivingLicenseApp.ApplicationInfo == null)
            {
                MessageBox.Show("Driving license application not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DriverInfo = clsDriver.FindForPersonID(_DrivingLicenseApp.ApplicationInfo.ApplicantPersonID);
            if (DriverInfo == null)
            {
                // create new DriverInfo instance before populating
                DriverInfo = new clsDriver();
                DriverInfo.PersonID = _DrivingLicenseApp.ApplicationInfo.ApplicantPersonID;
                DriverInfo.CreatedByUserID = clsGlobal.CurrentUser?.UserID ?? -1;
                DriverInfo.CreatedDate = DateTime.Now;

                if (!DriverInfo.Save())
                {
                    return;
                }
            }

            LicenseInfo = new clsLicense();
            LicenseInfo.ApplicationID = _DrivingLicenseApp.ApplicationID;
            LicenseInfo.DriverID = DriverInfo.DriverID;
            LicenseInfo.LicenseClassID = _DrivingLicenseApp.LicenseClassID;
            LicenseInfo.IssueDate = DateTime.Now;
            LicenseInfo.ExpirationDate = DateTime.Now.AddYears(_DrivingLicenseApp.LicenseClassInfo.DefaultValidityLength);
            LicenseInfo.Notes = txtNotes.Text.Trim();
            LicenseInfo.PaidFees = _DrivingLicenseApp.LicenseClassInfo.ClassFees;
            LicenseInfo.IsActive = true;
            LicenseInfo.IssueReason = enIssueReason.FirstTime;
            LicenseInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (LicenseInfo.Save())
            {
                MessageBox.Show(string.Format("Saved License ID = {0}", LicenseInfo.LicenseID));
                this.Close();
            }


        }

    }
}
