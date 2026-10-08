using DVLD_Business;
using DVLD.Applications.Local_License;
using DVLD.Tests;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class frmListTestAppointments : Form
    {

        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;

        public frmListTestAppointments(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            InitializeComponent();

            _TestType = TestType;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void cmsAppoinments_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            editToolStripMenuItem.Enabled = (dgvLicenseTestAppointments.Rows.Count > 0);
            tackTestToolStripMenuItem.Enabled = (dgvLicenseTestAppointments.Rows.Count > 0);

            if (clsTestAppointment.Find((int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value).IsLocked)
                tackTestToolStripMenuItem.Enabled = false;


        }

        private void TakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;
            frmTakeTest frm = new frmTakeTest(TestAppointmentID, _TestType);
            frm.ShowDialog();

            frmSechduleTest_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;


            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType, TestAppointmentID);
            frm.ShowDialog();
            frmSechduleTest_Load(null, null);

        }

        private void btnAddAppoiment_Click(object sender, EventArgs e)
        {

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID
                (_LocalDrivingLicenseApplicationID);


            if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsTest LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

            if (LastTest == null)
            {
                frmScheduleTest frm1 = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
                frm1.ShowDialog();
                frmSechduleTest_Load(null, null);
                return;
            }

            //if person already passed the test s/he cannot retak it.
            if (LastTest.TestResult == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest frm2 = new frmScheduleTest(LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
            frm2.ShowDialog();
            frmSechduleTest_Load(null, null);

        }

        private void frmSechduleTest_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();

            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
            _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, _TestType);

            dgvLicenseTestAppointments.DataSource = _dtLicenseTestAppointments;
            lblRecordsCount.Text = dgvLicenseTestAppointments.RowCount.ToString();

            if (dgvLicenseTestAppointments.Rows.Count > 0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 120;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 120;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 90;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 90;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadTestTypeImageAndTitle()
        {

            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    lblTitle.Text = "Vision Test Appoinments";
                    this.Text = "Vision Test Appoinments";
                    pbTestTypeImage.Image = Properties.Resources.Vision_512;
                    break;

                case clsTestType.enTestType.WrittenTest:
                    lblTitle.Text = "Written Test Appoinments";
                    this.Text = "Written Test Appoinments";
                    pbTestTypeImage.Image = Properties.Resources.Written_Test_512;
                    break;

                case clsTestType.enTestType.StreetTest:
                    lblTitle.Text = "Street Test Appoinments";
                    this.Text = "Street Test Appoinments";
                    pbTestTypeImage.Image = Properties.Resources.driving_test_512;
                    break;

            }

        }

    }
}
