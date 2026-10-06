using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Tests;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmListApplicationType : Form
    {
        public frmListApplicationType()
        {
            InitializeComponent();
        }

        private void dgvApplicationTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmManageApplicationType_Load(null, null);
        }

        private void frmManageApplicationType_Load(object sender, EventArgs e)
        {
            dgvApplicationTypes.DataSource = clsApplicationType.GetAllApplicationTypes();
            lblRecordsCount.Text = dgvApplicationTypes.Rows.Count.ToString();

            if (dgvApplicationTypes.RowCount > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 80;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 250;

                dgvApplicationTypes.Columns[2].HeaderText = "Fess";
                dgvApplicationTypes.Columns[2].Width = 100;
             
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmManageApplicationType_Load(null, null);
        }
    }
}
