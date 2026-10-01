using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmAddLocalDrivingLicenseApplication : Form
    {
        private clsLocalDrivingLicenseApplication _DrivingLicenseApp = new clsLocalDrivingLicenseApplication();
        public frmAddLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void _ResetDefualtValues()
        {
            _FillLeceseClassInComoboBox();

            _DrivingLicenseApp.ApplicationInfo.ApplicationTypeID = 1;
            _DrivingLicenseApp.ApplicationInfo.PaidFees = clsApplicationType.Find(_DrivingLicenseApp.ApplicationInfo.ApplicationTypeID).Fees;
            _DrivingLicenseApp.ApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _DrivingLicenseApp.ApplicationInfo.ApplicationStatus = clsApplication.enApplicationStatus.New;


            btnSave.Enabled = false;
            lblFess.Text = ((int)_DrivingLicenseApp.ApplicationInfo.PaidFees).ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblApplicationDate.Text = _DrivingLicenseApp.ApplicationInfo.ApplicationDate.ToShortDateString();

        }

        private void _FillLeceseClassInComoboBox()
        {

            cbLecenseClass.DataSource = clsLicenseClass.GetAllLecenseClasss();
            cbLecenseClass.DisplayMember = "ClassName";
            cbLecenseClass.SelectedIndex = 2;
        }

        private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonWithFilter1_OnPersonSelected(int obj)
        {
            if (obj != -1)
            {
                _DrivingLicenseApp.ApplicationInfo.ApplicantPersonID = ctrlPersonWithFilter1.PersonID;
                btnSave.Enabled = true;

            }
            else
            {
                _DrivingLicenseApp.ApplicationInfo.ApplicantPersonID = -1;
                btnSave.Enabled = false;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _DrivingLicenseApp.LicenseClassID = clsLicenseClass.Find(cbLecenseClass.Text.Trim()).LecenseClassID;

            int ActiveAppID = clsApplication.GetActiveApplicationIDForLicenseClass(_DrivingLicenseApp.ApplicationInfo.ApplicantPersonID,
                (clsApplication.enApplicationType)_DrivingLicenseApp.ApplicationInfo.ApplicationTypeID, _DrivingLicenseApp.LicenseClassID);

            if (ActiveAppID != -1)
            {
                MessageBox.Show("Choose another license Class, the selected Person Already have an active application for the selected class with id=" +
                    ActiveAppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_DrivingLicenseApp.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDL_ApplicationID.Text = _DrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbApplications.SelectedTab = tbApplications.TabPages["tpApplicatinInfo"];

        }

    }
}

