using DVLD_Business;
using System.IO;
using System.Windows.Forms;

namespace DVLD.Licenses.International_Licenses.Controls
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID;
        private clsInternationalLicense _InternationalLicense;
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void ResetLicenseInfo()
        {
            lblName.Text = "[???]";
            lblInternationalLicenseID.Text = "[???]";
            lblLicenseID.Text = "[???]";
            lblNationailNO.Text = "[???]";
            lblGedor.Text = "[???]";
            lblIssueDate.Text = "[???]";
            lblApplicationID.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblDateOfBrith.Text = "[???]";
            lblDriverID.Text = "[???]";
            lblExpirationDate.Text = "[???]";
            imgPerson.Image = Properties.Resources.Male_512;
        }

        private void _LoadPresonImage()
        {

            if (_InternationalLicense.ApplicationInfo.PersonInfo.Gendor == 0)
                imgPerson.Image = Properties.Resources.Male_512;
            else
                imgPerson.Image = Properties.Resources.Female_512;

            string ImagePath = _InternationalLicense.ApplicationInfo.PersonInfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    imgPerson.Load(ImagePath);
                else
                    MessageBox.Show("could not find this image." + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillLicenseInfo()
        {
            lblName.Text = _InternationalLicense.ApplicationInfo.PersonInfo.FullName;
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationailNO.Text = _InternationalLicense.ApplicationInfo.PersonInfo.NationalNo;
            lblGedor.Text = _InternationalLicense.ApplicationInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();

            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblDateOfBrith.Text = _InternationalLicense.ApplicationInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();

            _LoadPresonImage();

        }

        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicense.FindByID(InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                _InternationalLicenseID = -1;
                ResetLicenseInfo();
                MessageBox.Show("No International License with ID = " + _InternationalLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillLicenseInfo();


        }

    }
}