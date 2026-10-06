using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID;
        private clsTest _Test = new clsTest();
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
        }

        private void _LoadData()
        {

            lblFess.Text = _Test.TestAppointmentInfo.PaidFees.ToString();
            lblDate.Text = _Test.TestAppointmentInfo.AppointmentDate.ToShortDateString();
            lblD_Class.Text = _Test.TestAppointmentInfo.DrivingLicenseApp.LicenseClassInfo.ClassName.ToString();
            lblName.Text = _Test.TestAppointmentInfo.DrivingLicenseApp.ApplicationInfo.ApplicantName.ToString();
            lblAppID.Text = _Test.TestAppointmentInfo.DrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _Test.TestAppointmentInfo = clsTestAppointment.Find(_TestAppointmentID);
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Test.TestAppointmentID = _Test.TestAppointmentInfo.TestAppointmentID;
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();


            if (MessageBox.Show("Are you sure you want to Save? Atter that you cannot chanbe the Pass/Fail result you save?.",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (_Test.Save())
                {
                    _Test.TestAppointmentInfo.IsLocked = true;
                    if (_Test.TestAppointmentInfo.Save())
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
