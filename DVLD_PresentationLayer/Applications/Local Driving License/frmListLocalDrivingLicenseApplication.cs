using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications;
using DVLD_PresentationLayer.Licenses;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmListLocalDrivingLicenseApplication : Form
    {

        private DataTable _GetAllLocalDrivingLicenseApplications;

        public frmListLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            _GetAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplication();
            LocalDrivingLicenseApplications.DataSource = _GetAllLocalDrivingLicenseApplications;
            cbFilterBy.SelectedIndex = 0;

            lblRecordsCount.Text = LocalDrivingLicenseApplications.RowCount.ToString();
            if (LocalDrivingLicenseApplications.RowCount > 0)
            {
                LocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                LocalDrivingLicenseApplications.Columns[0].Width = 100;

                LocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                LocalDrivingLicenseApplications.Columns[1].Width = 190;

                LocalDrivingLicenseApplications.Columns[2].HeaderText = "National No.";
                LocalDrivingLicenseApplications.Columns[2].Width = 100;

                LocalDrivingLicenseApplications.Columns[3].HeaderText = "FullName";
                LocalDrivingLicenseApplications.Columns[3].Width = 300;

                LocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date Name";
                LocalDrivingLicenseApplications.Columns[4].Width = 140;

                LocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Test";
                LocalDrivingLicenseApplications.Columns[5].Width = 90;

                LocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                LocalDrivingLicenseApplications.Columns[6].Width = 90;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            lblRecordsCount.Text = LocalDrivingLicenseApplications.RowCount.ToString();

            if (cbFilterBy.Text == "Status")
            {
                txtFilterValue.Visible = false;
                cbStatus.Visible = true;
                cbStatus.SelectedIndex = 0;
                cbStatus.Focus();
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbStatus.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "Status";
            string FilterValue = cbStatus.Text;

            switch (FilterValue)
            {
                case "All":
                    break;

                case "New":
                    FilterValue = "New";
                    break;

                case "Canceled":
                    FilterValue = "Canceled";
                    break;

                case "Completed":
                    FilterValue = "Completed";
                    break;

                default:
                    break;
            }
            if (FilterValue == "All")
                _GetAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            else
                _GetAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);

            lblRecordsCount.Text = LocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _GetAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsCount.Text = LocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.

                _GetAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _GetAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = LocalDrivingLicenseApplications.Rows.Count.ToString();

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();

            //refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure do want to Cancel Application ",
                  "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.No)
                return;


            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                 clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID((int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            if (LocalDrivingLicenseApplication.Cancel())
            {
                MessageBox.Show("Application Canceled Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //refresh the from again
                frmListLocalDrivingLicenseApplication_Load(null, null);
            }
            else
                MessageBox.Show("Application was not Canceled because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Application [" + (int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value + "]",
              "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.No)
                return;


            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID((int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            if (LocalDrivingLicenseApplication.Delete())
            {
                MessageBox.Show("Application Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //refresh the from again
                frmListLocalDrivingLicenseApplication_Load(null, null);
            }
            else
                MessageBox.Show("Application was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmListTestAppoinments frm = new frmListTestAppoinments((int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value, clsTestType.enTestType.VisionTest);
            frm.ShowDialog();

            //refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestAppoinments frm = new frmListTestAppoinments((int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value, clsTestType.enTestType.WrittenTest);
            frm.ShowDialog();

            //refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestAppoinments frm = new frmListTestAppoinments((int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value, clsTestType.enTestType.StreetTest);
            frm.ShowDialog();

            //refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);

        }

        private void issueDirvingLicenseFindTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDirvingLicenseForTheFirstTime frm = new frmIssueDirvingLicenseForTheFirstTime((int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            //refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication((int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            //refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);
        }

        private void cmsApplication_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            bool IsNew = clsLocalDrivingLicenseApplication.IsNew(LocalDrivingLicenseApplicationID);
            int PassedTests = clsTestAppointment.GetPassedTestCount(LocalDrivingLicenseApplicationID);

            scheduleVisionTestToolStripMenuItem.Enabled = !(PassedTests >= (int)clsTestType.enTestType.VisionTest);
            scheduleWrittenTestToolStripMenuItem.Enabled = (PassedTests == (int)clsTestType.enTestType.VisionTest);
            scheduleStreetTestToolStripMenuItem.Enabled = (PassedTests == (int)clsTestType.enTestType.WrittenTest);

            editToolStripMenuItem.Enabled = IsNew;
            cancelToolStripMenuItem.Enabled = IsNew;
            deleteToolStripMenuItem.Enabled = IsNew;
            schduletestsToolStripMenuItem.Enabled = !(PassedTests == (int)clsTestType.enTestType.StreetTest || !IsNew);

            issueDirvingLicenseForFirstTimeToolStripMenuItem.Enabled = (PassedTests == (int)clsTestType.enTestType.StreetTest && IsNew);
            showLicenseToolStripMenuItem.Enabled = clsLocalDrivingLicenseApplication.IsCompleted(LocalDrivingLicenseApplicationID);

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = (string)LocalDrivingLicenseApplications.CurrentRow.Cells[2].Value;
            int LicenseClassID = clsLicenseClass.Find((string)LocalDrivingLicenseApplications.CurrentRow.Cells[1].Value).LecenseClassID;

            frmShowLicense frm = new frmShowLicense(NationalNo, LicenseClassID);
            frm.ShowDialog();

        }

        private void showhistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPerson.Find((string)LocalDrivingLicenseApplications.CurrentRow.Cells[2].Value).PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void showDitelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowApplicationDitels frm = new frmShowApplicationDitels((int)LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

    }
}
