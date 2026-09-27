using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {

            dgvTestTypes.DataSource = clsTestType.GetAllTestTypes();
            lblRecordsCount.Text = dgvTestTypes.RowCount.ToString();

            if (dgvTestTypes.RowCount > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 80;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvTestTypes.Columns[3].HeaderText = "Fess";
                dgvTestTypes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType((clsTestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            //revrsh
            frmListTestTypes_Load(null, null);
        }

    }
}
