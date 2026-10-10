using DVLD_Business;
using System.IO;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public int LicenseID
        {
            get { return _LicenseID; }
        }
        private int _LicenseID = -1;
        private clsLicense _LicenseInfo;
        public clsLicense SelectedLicenseInfo
        {
            get { return _LicenseInfo; }
        }

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _LicenseInfo = clsLicense.Find(_LicenseID);

            if (_LicenseInfo == null)
            {
                _LicenseID = -1;
                _RestLicenseInfo();
                MessageBox.Show("Could not find License ID = " + _LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillLicenseInfo();

        }

        private void _LoadLicenseImage()
        {

            if (_LicenseInfo.DriverInfo.PersonInfo.Gendor == 0)
                imgPerson.Image = Properties.Resources.Male_512;
            else
                imgPerson.Image = Properties.Resources.Female_512;

            string ImagePath = _LicenseInfo.DriverInfo.PersonInfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    imgPerson.ImageLocation = ImagePath;
                else
                    MessageBox.Show("could not find this image." + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillLicenseInfo()
        {
            lbClass.Text = _LicenseInfo.LicenseClassInfo.ClassName;
            lblName.Text = _LicenseInfo.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _LicenseInfo.LicenseID.ToString();
            lblNationailNO.Text = _LicenseInfo.DriverInfo.PersonInfo.NationalNo;
            lblGedor.Text = _LicenseInfo.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = _LicenseInfo.IssueDate.ToShortDateString();
            lblIssueReason.Text = _LicenseInfo.IssueReasonText;
            lblNotes.Text = _LicenseInfo.Notes == "" ? "No Notes" : _LicenseInfo.Notes;

            lblIsActive.Text = _LicenseInfo.IsActive ? "Yes" : "No";
            lblDateOfBrith.Text = _LicenseInfo.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _LicenseInfo.DriverID.ToString();
            lblExpirationDate.Text = _LicenseInfo.ExpirationDate.ToShortDateString();
            lblIsDetained.Text = _LicenseInfo.IsDetained ? "Yes" : "No";

            _LoadLicenseImage();

        }

        private void _RestLicenseInfo()
        {
            lbClass.Text = "[???]";
            lblName.Text = "[???]";
            lblLicenseID.Text = "[???]";
            lblNationailNO.Text = "[???]";
            lblGedor.Text = "[???]";
            lblIssueDate.Text = "[???]";
            lblIssueReason.Text = "[???]";
            lblNotes.Text = "No Notes";
            lblIsActive.Text = "[???]";
            lblDateOfBrith.Text = "[???]";
            lblDriverID.Text = "[???]";
            lblExpirationDate.Text = "[???]";
            lblIsDetained.Text = "[???]";
            imgPerson.Image = Properties.Resources.Male_512;

        }

    
    }
}
