using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmSechduleTest : Form
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        private enTestType _TestType;


        public frmSechduleTest()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSechduleTest_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();


        }

        private void _ResetDefualtValues()
        {

            // Set the minimum and default date to today.
            dtpDate.MinDate = DateTime.Now;
            dtpDate.Value = dtpDate.MinDate;
          
        }
    }
}
