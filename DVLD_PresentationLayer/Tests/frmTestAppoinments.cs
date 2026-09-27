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

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmTestAppoinments : Form
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        private enTestType _TestType;
        private clsLocalDrivingLicenseApplication _LicenseApp;
        private int _DrivingLicenseApplicationID;
        public frmTestAppoinments(int DrivingLicenseApplicationID)
        {
            InitializeComponent();
            _DrivingLicenseApplicationID = DrivingLicenseApplicationID;
        }

        private void _ResetDefualtValues()
        {

            if (_TestType == enTestType.VisionTest)
            {
                lblTitle.Text = "Vision Test Appoinments";
                this.Text = "Vision Test Appoinments";
            }
            else if (_TestType == enTestType.WrittenTest)
            {
                lblTitle.Text = "Written Test Appoinments";
                this.Text = "Written Test Appoinments";
            }
            else
            {
                lblTitle.Text = "Street Test Appoinments";
                this.Text = "Street Test Appoinments";

            }

        }

        private void frmSechduleTest_Load(object sender, EventArgs e)
        {

            ctrlAppointmentCard1.LoadAppointmentCard(_DrivingLicenseApplicationID);
            _LicenseApp = clsLocalDrivingLicenseApplication.Find(_DrivingLicenseApplicationID);
            dgvAppoinments.DataSource = clsTestAppointment.GetAllTestAppointments(_LicenseApp.LocalDrivingLicenseApplicationID, _LicenseApp.ApplicationInfo.ApplicationTypeID);
            lblRecordsCount.Text = dgvAppoinments.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
