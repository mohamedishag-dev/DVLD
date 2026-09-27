using DVLD_BusinessLayer;
using DVLD_PresentationLayer.People;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Controls
{
    public partial class ctrlAppointmentCard : UserControl
    {
        clsLocalDrivingLicenseApplication _LicenseApp;
        private int _LocalDrivingLicenseApplicationID = -1;
        public int LocalDrivingLicenseApplicationID
        {
            get { return _LocalDrivingLicenseApplicationID; }
        }

        public ctrlAppointmentCard()
        {
            InitializeComponent();
        }

        public void LoadAppointmentCard(int LocalDrivingLicenseApplicationID)
        {

            _LicenseApp = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            llViewPersonInfo.Enabled = (_LicenseApp != null);

            if (_LicenseApp == null)
            {
                _LocalDrivingLicenseApplicationID = -1;
                ResetLicenseApplicationnfo();
                MessageBox.Show("No License Application with LicenseApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillDrivingLicenseApplicationInfo();

        }

        public void ResetLicenseApplicationnfo()
        {
            _LocalDrivingLicenseApplicationID = -1;
            //Reset Driving License Application Info
            lblAppID.Text = "N/A";
            lblAppliedForLicense.Text = "[????]";
            lblPassedTests.Text = "[????]";

            //Reset Application Basic Info
            lbID.Text = "N/A";
            lblStatus.Text = "[????]";
            lblFess.Text = "0";
            lblType.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreatedBy.Text = "[????]";
            llViewPersonInfo.Enabled = false;
            llShowLicenseInfo.Enabled = false;
        }

        private void _FillDrivingLicenseApplicationInfo()
        {
            _LocalDrivingLicenseApplicationID = _LicenseApp.LocalDrivingLicenseApplicationID;
            //Fill Driving License Application Info
            lblAppID.Text = _LicenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = _LicenseApp.LecenseClassInfo.ClassName.ToString();
            //   lblPassedTests.Text = _LicenseApp.LocalDrivingLicenseApplicationID.ToString();
            
            //Fill Application Basic Info
            lbID.Text = _LicenseApp.ApplicationID.ToString();
            lblStatus.Text = _LicenseApp.ApplicationInfo.Status == 1 ? "New" : _LicenseApp.ApplicationInfo.Status == 2 ? "Canceled" : "Completed";
            lblFess.Text = _LicenseApp.ApplicationInfo.PaidFees.ToString();
            lblType.Text = _LicenseApp.ApplicationInfo.ApplicationTypeID.ToString();
            lblApplicant.Text = _LicenseApp.ApplicationInfo.PersonInfo.FullName.ToString();
            lblDate.Text = _LicenseApp.ApplicationInfo.ApplicationDate.ToShortDateString();
            lblStatusDate.Text = _LicenseApp.ApplicationInfo.LastStatusDate.ToShortDateString();
            lblCreatedBy.Text = _LicenseApp.ApplicationInfo.CreatedByUser.UserName.ToString();
            llViewPersonInfo.Enabled = true;
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_LicenseApp.ApplicationInfo.ApplicantPersonID);
            frm.ShowDialog();

            LoadAppointmentCard(LocalDrivingLicenseApplicationID);
        }

        private void ctrlLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            llViewPersonInfo.Enabled = (_LicenseApp != null);
            llShowLicenseInfo.Enabled = false;
        }

    }
}
