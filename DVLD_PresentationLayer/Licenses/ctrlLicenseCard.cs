using DVLD_BusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses
{
    public partial class ctrlLicenseCard : UserControl
    {
        private int _LicenseID;
        private clsLicense LicenseInfo;
        private string _NationalNo = "";

        public ctrlLicenseCard()
        {
            InitializeComponent();
        }

        private void ctrlLicenseCard_Load(object sender, EventArgs e)
        {

        }

        public void LoadLicenseCard(int LicenseID)
        {
            _LicenseID = LicenseID;
            LicenseInfo = clsLicense.Find(_LicenseID);

            if (LicenseInfo == null)
            {
                _LicenseID = -1;
                ResetLicenseInfo();
                MessageBox.Show("No Person with LicenseID = " + LicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillLicenseInfo();

        }

        public void LoadLicenseCard(string NationalNo, int LicenseClass)
        {
            _NationalNo = NationalNo;
            LicenseInfo = clsLicense.Find(_NationalNo, LicenseClass);

            if (LicenseInfo == null)
            {
                _LicenseID = -1;
                ResetLicenseInfo();
                MessageBox.Show("No Person with NationalNo = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillLicenseInfo();

        }

        private void _LoadLicenseImage()
        {

            if (LicenseInfo.ApplicationInfo.PersonInfo.Gendor == 0)
                imgPerson.Image = Properties.Resources.Male_5121;
            else
                imgPerson.Image = Properties.Resources.Female_512;

            string ImagePath = LicenseInfo.ApplicationInfo.PersonInfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    imgPerson.ImageLocation = ImagePath;
                else
                    MessageBox.Show("could not find this image." + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillLicenseInfo()
        {
            _LicenseID = -1;
            lbClass.Text = LicenseInfo.LicenseClassInfo.ClassName;
            lblName.Text = LicenseInfo.ApplicationInfo.ApplicantName;
            lblLicenseID.Text = LicenseInfo.LicenseID.ToString();
            lblNationailNO.Text = LicenseInfo.ApplicationInfo.PersonInfo.NationalNo;
            lblGedor.Text = LicenseInfo.ApplicationInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = LicenseInfo.IssueDate.ToShortDateString();
            lblIssueReason.Text = LicenseInfo.IssueReasonText;

            if (LicenseInfo.Notes != "")
                lblNotes.Text = LicenseInfo.Notes;
            else
                lblNotes.Text = "No Notes";

            lblIsActive.Text = LicenseInfo.IsActive == true ? "Yes" : "No";
            lblDateOfBrith.Text = LicenseInfo.ApplicationInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = LicenseInfo.DriverID.ToString();
            lblExpirationDate.Text = LicenseInfo.ExpirationDate.ToShortDateString();
            lblIsDetained.Text = LicenseInfo.IsActive == true ? "No" : "Yes";

            _LoadLicenseImage();

        }

        public void ResetLicenseInfo()
        {
            _LicenseID = -1;
            lbClass.Text = "N/A";
            lblName.Text = "N/A";
            lblLicenseID.Text = "N/A";
            lblNationailNO.Text = "N/A";
            lblGedor.Text = "N/A";
            lblIssueDate.Text = "N/A";
            lblIssueReason.Text = "N/A";
            lblNotes.Text = "N/A";

            lblIsActive.Text = "N/A";
            lblDateOfBrith.Text = "N/A";
            lblDriverID.Text = "N/A";
            lblExpirationDate.Text = "N/A";
            lblIsDetained.Text = "N/A";

            imgPerson.Image = Properties.Resources.Male_512;
        }


    }
}
