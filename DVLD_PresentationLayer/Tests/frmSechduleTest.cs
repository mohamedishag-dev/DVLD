using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmSechduleTest : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _TestAppointmentID;
        clsTestAppointment _TestAppointment;
        private int _LocalDrivingLicenseApplicationID;

        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;

        public frmSechduleTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Mode = enMode.AddNew;
            _TestType = TestType;
        }

        public frmSechduleTest(int TestAppointmentID)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _Mode = enMode.Update;
        }

        private void frmSechduleTest_Load(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
                _LoadData();
            else
                _ResetDefualtValues();


            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    lblTitle.Text = "Scheduled Test";
                    gbTestInfo.Text = "Vision Test";
                    pbSechduleTestImage.Image = Properties.Resources.Vision_512;
                    break;

                case clsTestType.enTestType.WrittenTest:
                    lblTitle.Text = "Sechdule Test";
                    gbTestInfo.Text = "Written Test";
                    pbSechduleTestImage.Image = Properties.Resources.Written_Test_512;
                    break;

                case clsTestType.enTestType.StreetTest:
                    lblTitle.Text = "Sechdule Test";
                    gbTestInfo.Text = "Street Test";
                    pbSechduleTestImage.Image = Properties.Resources.driving_test_512;
                    break;

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestAppointment.AppointmentDate = dtpDate.Value;
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_TestAppointment.Save())
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefualtValues()
        {
            _TestAppointment = new clsTestAppointment();

            _TestAppointment.TestTypeID = _TestType;
            _TestAppointment.PaidFees = clsTestType.Find(_TestType).Fees;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            _TestAppointment.DrivingLicenseApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (clsTestAppointment.CountTackTest(_LocalDrivingLicenseApplicationID, (int)_TestType) > 0)
            {
                _TestAppointment.RetakeTestAppointmentID = clsTestAppointment.GetLestRetakeTest();
                _TestAppointment.PaidFees += clsApplicationType.Find(7).Fees;
                lblRTestAppID.Text = _TestAppointment.RetakeTestAppointmentID.ToString();
                lblRAppFess.Text = clsApplicationType.Find(7).Fees.ToString();
            }
            // Set the minimum and default date to today.
            dtpDate.MinDate = DateTime.Now;
            dtpDate.Value = dtpDate.MinDate;

            lblFess.Text = _TestAppointment.PaidFees.ToString();
            lblTotalFess.Text = _TestAppointment.PaidFees.ToString();
            lblD_Class.Text = _TestAppointment.DrivingLicenseApp.LicenseClassInfo.ClassName.ToString();
            lblName.Text = _TestAppointment.DrivingLicenseApp.ApplicationInfo.ApplicantName.ToString();
            lblAppID.Text = _TestAppointment.DrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            gbRetakeTest.Enabled = (_TestAppointment.RetakeTestAppointmentID != -1);

        }

        private void _LoadData()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            dtpDate.Value = _TestAppointment.AppointmentDate;
            if (!_TestAppointment.IsLocked)
                dtpDate.MinDate = DateTime.Today;


            lblFess.Text = _TestAppointment.PaidFees.ToString();
            lblTotalFess.Text = _TestAppointment.PaidFees.ToString();
            lblD_Class.Text = _TestAppointment.DrivingLicenseApp.LicenseClassInfo.ClassName.ToString();
            lblName.Text = _TestAppointment.DrivingLicenseApp.ApplicationInfo.ApplicantName.ToString();
            lblAppID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();

            if (_TestAppointment.RetakeTestAppointmentID != -1)
                lblRTestAppID.Text = _TestAppointment.RetakeTestAppointmentID.ToString();

            gbRetakeTest.Enabled = (_TestAppointment.RetakeTestAppointmentID != -1);

            dtpDate.Enabled = !_TestAppointment.IsLocked;
            btnSave.Enabled = !_TestAppointment.IsLocked;

        }

    }
}
