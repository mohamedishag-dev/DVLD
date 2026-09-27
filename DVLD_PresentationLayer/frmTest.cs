using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LicenseAppID = int.Parse(textBox1.Text.Trim());
            clsTestAppointment TestAppointment = clsTestAppointment.Find(LicenseAppID);
            ctrlLocalDrivingLicenseApplication1.LoadAppointmentCard(TestAppointment.LocalDrivingLicenseAppointmentID);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
