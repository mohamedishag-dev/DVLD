using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmAddLocalDrivingLicenseApplication : Form
    {
        clsLocalDrivingLicenseApplication _LicenseApplication = new clsLocalDrivingLicenseApplication();
        public frmAddLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void _ResetDefualtValues()
        {
            _FillLeceseClassInComoboBox();

            _LicenseApplication.ApplicationInfo.ApplicationTypeID = 1;
            _LicenseApplication.ApplicationInfo.PaidFees = clsApplicationType.Find(_LicenseApplication.ApplicationInfo.ApplicationTypeID).Fees;
            _LicenseApplication.ApplicationInfo.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LicenseApplication.ApplicationInfo.Status = 1;


            btnSave.Enabled = false;
            lblFess.Text = ((int)_LicenseApplication.ApplicationInfo.PaidFees).ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblApplicationDate.Text = _LicenseApplication.ApplicationInfo.ApplicationDate.ToShortDateString();

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
                _LicenseApplication.ApplicationInfo.ApplicantPersonID = ctrlPersonWithFilter1.PersonID;
                btnSave.Enabled = true;

            }
            else
            {
                _LicenseApplication.ApplicationInfo.ApplicantPersonID = -1;
                btnSave.Enabled = false;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _LicenseApplication.LicenseClassID = clsLicenseClass.Find(cbLecenseClass.Text.Trim()).LecenseClassID;


            if (_LicenseApplication.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDL_ApplicationID.Text = _LicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Choose another license Class, the selected Person Already have an active application for the selected class with id=" +
                    clsLocalDrivingLicenseApplication.Find(_LicenseApplication.ApplicationInfo.ApplicantPersonID, _LicenseApplication.LicenseClassID).LocalDrivingLicenseApplicationID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbApplications.SelectedTab = tbApplications.TabPages["tpApplicatinInfo"];

        }

    }
}

