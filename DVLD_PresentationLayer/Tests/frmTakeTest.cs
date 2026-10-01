using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID;
        private clsTestAppointment _TestAppointment;
        private clsTest _Test = new clsTest();
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {

            lblFess.Text = _TestAppointment.PaidFees.ToString();
            lblDate.Text = _TestAppointment.AppointmentDate.ToShortDateString();
            lblD_Class.Text = _TestAppointment.DrivingLicenseApp.LecenseClassInfo.ClassName.ToString();
            lblName.Text = _TestAppointment.DrivingLicenseApp.ApplicationInfo.ApplicantName.ToString();
            lblAppID.Text = _TestAppointment.DrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Test.TestAppointmentID = _TestAppointment.TestAppointmentID;
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();


            if (MessageBox.Show("Are you sure you want to Save? Atter that you cannot chanbe the Pass/Fail result you save?.",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (_Test.Save())
                {
                    _TestAppointment.IsLocked = _Test.TestResult;
                    if (_TestAppointment.Save())
                    {

                        MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
