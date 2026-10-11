using DVLD.Licenses;
using DVLD_Business;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.Internatioal_License.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID=-1;
        private clsDriver _Driver;
        private DataTable _GetLocalLicenses;
        private DataTable _GetInternationalLicenses;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        public void LoadInfo(int DriverID)
        {
            _Driver = clsDriver.FindByDriverID(DriverID);

            if (_Driver == null)
            {
                MessageBox.Show("There is no driver linked with id = " + DriverID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DriverID = _Driver.DriverID;
            LoadLocalLicenses();
            InternationalLicenses();

        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = clsDriver.FindByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show("There is no driver linked with person with id = " + PersonID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DriverID = _Driver.DriverID;
            LoadLocalLicenses();
            InternationalLicenses();

        }

        private void LoadLocalLicenses()
        {
            _GetLocalLicenses = clsLicense.GetDriverLicenses(_DriverID);

            dgvLocalLicenses.DataSource = _GetLocalLicenses;
            lblRecordsCountLocal.Text = dgvLocalLicenses.Rows.Count.ToString();

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicenses.Columns[0].Width = 90;

                dgvLocalLicenses.Columns[1].HeaderText = "App.ID";
                dgvLocalLicenses.Columns[1].Width = 90;

                dgvLocalLicenses.Columns[2].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[2].Width = 190;

                dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[3].Width = 100;

                dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[4].Width = 120;

                dgvLocalLicenses.Columns[5].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[5].Width = 90;
            }
        }

        private void InternationalLicenses()
        {
            _GetInternationalLicenses = clsInternationalLicense.GetAllInternationalLicenses(_DriverID);
            dgvInternationalLicenses.DataSource = _GetInternationalLicenses;
            lblRecordsCountInternatioal.Text = _GetInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 100;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 100;

                dgvInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[2].Width = 190;

                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 120;

                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 120;

                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 90;
            }
        }

        private void showLicenseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvLocalLicenses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvInternationalLicenses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
