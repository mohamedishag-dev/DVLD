using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmSechduleTest : Form
    {
        private bool _RetakeTestEnabled = true;
        public bool RetakeTestEnabled
        {
            get
            {
                return _RetakeTestEnabled;
            }
            set
            {
                _RetakeTestEnabled = value;
                gbRetakeTest.Enabled = _RetakeTestEnabled;
            }
        }

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

        }

        private void _ResetDefualtValues()
        {
            _TestAppointment = new clsTestAppointment();

            _TestAppointment.TestTypeID = _TestType;
            _TestAppointment.PaidFees = clsTestType.Find(_TestType).Fees;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            _TestAppointment.DrivingLicenseApp = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseApplicationID);

            // Set the minimum and default date to today.
            dtpDate.MinDate = DateTime.Now;
            dtpDate.Value = dtpDate.MinDate;

            lblFess.Text = _TestAppointment.PaidFees.ToString();
            lblTotalFess.Text = _TestAppointment.PaidFees.ToString();
            lblD_Class.Text = _TestAppointment.DrivingLicenseApp.LecenseClassInfo.ClassName.ToString();
            lblName.Text = _TestAppointment.DrivingLicenseApp.ApplicationInfo.ApplicantName.ToString();
            lblAppID.Text = _TestAppointment.DrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            RetakeTestEnabled = false;

        }

        private void _LoadData()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = _TestAppointment.AppointmentDate;
            lblFess.Text = _TestAppointment.PaidFees.ToString();
            lblTotalFess.Text = _TestAppointment.PaidFees.ToString();
            lblD_Class.Text = _TestAppointment.DrivingLicenseApp.LecenseClassInfo.ClassName.ToString();
            lblName.Text = _TestAppointment.DrivingLicenseApp.ApplicationInfo.ApplicantName.ToString();
            lblAppID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();

            if (_TestAppointment.RetakeTestAppointmentID != -1)
            {
                lblRTestAppID.Text = _TestAppointment.RetakeTestAppointmentID.ToString();

            }
            RetakeTestEnabled = (_TestAppointment.RetakeTestAppointmentID != -1);
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

    }
}
