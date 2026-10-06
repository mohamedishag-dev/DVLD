using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses
{
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID = -1;
        private DataTable _GetAllLicenses;
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonWithFilter1.FilterEnabled = false;
            ctrlPersonWithFilter1.LoadPersonInfo(_PersonID);
            _GetAllLicenses = clsLicense.GetAllLicensesForPersonID(_PersonID);
            LoadLocalLicenses();


        }

        private void LoadLocalLicenses()
        {

            dgvLocalLicenses.DataSource = _GetAllLicenses;
            lblRecordsCountLocal.Text = dgvLocalLicenses.Rows.Count.ToString();

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicenses.Columns[0].Width = 90;

                dgvLocalLicenses.Columns[1].HeaderText = "App.ID";
                dgvLocalLicenses.Columns[1].Width = 90;

                dgvLocalLicenses.Columns[2].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[2].Width = 90;

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
