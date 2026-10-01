using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Tests;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmTestAppoinments : Form
    {

        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;

        public frmTestAppoinments(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
        }

        private void _ResetDefualtValues()
        {

            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    lblTitle.Text = "Vision Test Appoinments";
                    this.Text = "Vision Test Appoinments";
                    break;

                case clsTestType.enTestType.WrittenTest:
                    lblTitle.Text = "Written Test Appoinments";
                    this.Text = "Written Test Appoinments";
                    break;

                case clsTestType.enTestType.StreetTest:
                    lblTitle.Text = "Street Test Appoinments";
                    this.Text = "Street Test Appoinments";
                    break;

            }

            _dtLicenseTestAppointments = clsTestAppointment.GetAllTestAppointments(_LocalDrivingLicenseApplicationID, (int)_TestType);

        }

        private void frmSechduleTest_Load(object sender, EventArgs e)
        {

            ctrlAppointmentCard1.LoadAppointmentCard(_LocalDrivingLicenseApplicationID);

            _ResetDefualtValues();

            dgvAppoinments.DataSource = _dtLicenseTestAppointments;
            lblRecordsCount.Text = dgvAppoinments.RowCount.ToString();

            if (dgvAppoinments.Rows.Count > 0)
            {
                dgvAppoinments.Columns[0].HeaderText = "Appointment ID";
                dgvAppoinments.Columns[0].Width = 120;

                dgvAppoinments.Columns[1].HeaderText = "Appointment Date";
                dgvAppoinments.Columns[1].Width = 120;

                dgvAppoinments.Columns[2].HeaderText = "Paid Fees";
                dgvAppoinments.Columns[2].Width = 90;

                dgvAppoinments.Columns[3].HeaderText = "Is Locked";
                dgvAppoinments.Columns[3].Width = 90;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAppoiment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.IsActiveAppointment(_LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("Person Already have an active appiontment for this test, You cannot add new appiontment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsTestAppointment.IsTackTest(_LocalDrivingLicenseApplicationID, (int)_TestType))
            {
                MessageBox.Show("You cannot add new appiontment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmSechduleTest fem = new frmSechduleTest(_LocalDrivingLicenseApplicationID, _TestType);
            fem.ShowDialog();
            frmSechduleTest_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSechduleTest SechduleTest = new frmSechduleTest((int)dgvAppoinments.CurrentRow.Cells[0].Value);
            SechduleTest.ShowDialog();
            frmSechduleTest_Load(null, null);
        }

        private void TakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest((int)dgvAppoinments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmSechduleTest_Load(null, null);
        }

    }
}
