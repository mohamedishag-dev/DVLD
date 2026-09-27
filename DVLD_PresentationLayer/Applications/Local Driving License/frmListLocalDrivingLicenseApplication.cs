using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmListLocalDrivingLicenseApplication : Form
    {

        private DataTable _GetAllLocalDrivingLicenseApp;

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

            _GetAllLocalDrivingLicenseApp = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplication();
            dgvLDL_App.DataSource = _GetAllLocalDrivingLicenseApp;
            cbFilterBy.SelectedIndex = 0;

            lblRecordsCount.Text = dgvLDL_App.RowCount.ToString();
            if (dgvLDL_App.RowCount > 0)
            {
                dgvLDL_App.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLDL_App.Columns[0].Width = 100;

                dgvLDL_App.Columns[1].HeaderText = "Driving Class";
                dgvLDL_App.Columns[1].Width = 190;

                dgvLDL_App.Columns[2].HeaderText = "National No.";
                dgvLDL_App.Columns[2].Width = 100;

                dgvLDL_App.Columns[3].HeaderText = "FullName";
                dgvLDL_App.Columns[3].Width = 300;

                dgvLDL_App.Columns[4].HeaderText = "Application Date Name";
                dgvLDL_App.Columns[4].Width = 140;

                dgvLDL_App.Columns[5].HeaderText = "Passed Test";
                dgvLDL_App.Columns[5].Width = 90;

                dgvLDL_App.Columns[6].HeaderText = "Status";
                dgvLDL_App.Columns[6].Width = 90;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetAllLocalDrivingLicenseApp.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvLDL_App.RowCount.ToString();

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
                _GetAllLocalDrivingLicenseApp.DefaultView.RowFilter = "";
            else
                _GetAllLocalDrivingLicenseApp.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);

            lblRecordsCount.Text = dgvLDL_App.Rows.Count.ToString();
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
                _GetAllLocalDrivingLicenseApp.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvLDL_App.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.

                _GetAllLocalDrivingLicenseApp.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _GetAllLocalDrivingLicenseApp.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvLDL_App.Rows.Count.ToString();

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddLocalDrivingLicenseApplication frm = new frmAddLocalDrivingLicenseApplication();
            frm.ShowDialog();

            frmListLocalDrivingLicenseApplication_Load(null, null);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure do want to Cancel Application ",
                  "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.CancelApplication((int)dgvLDL_App.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Canceled Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicenseApplication_Load(null, null);
                }
                else
                    MessageBox.Show("Application was not Canceled because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvLDL_App.CurrentRow.Cells[0].Value + "]",
                "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.DeleteLicenseApplication((int)dgvLDL_App.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicenseApplication_Load(null, null);
                }
                else
                    MessageBox.Show("Application was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDitelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

    
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestAppoinments frm = new frmTestAppoinments((int)dgvLDL_App.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void issueDirvingLicenseFindTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void showhistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void cmsApplication_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //(int)dgvLDL_App.CurrentRow.Cells[0].Value
        }
    }
}
