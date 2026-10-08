using DVLD_Business;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.Internatioal_License.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private DataTable _GetAllLicenses;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        public void LoadLicenses(int PersonID)
        {
            _GetAllLicenses = clsLicense.GetAllLicensesForPersonID(PersonID);

            dgvLocalLicenses.DataSource = _GetAllLicenses;
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


    }
}
