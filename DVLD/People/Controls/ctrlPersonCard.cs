using DVLD_Business;
using DVLD.People;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPresonCard : UserControl
    {
        private clsPerson _Person;
        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public ctrlPresonCard()
        {
            InitializeComponent();
        }

        public void LoadPresonCard(int PersonID)
        {

            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                _PersonID = -1;
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillPresonInfo();

        }

        public void LoadPresonCard(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                _PersonID = -1;
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillPresonInfo();

        }

        private void _LoadPresonImage()
        {

            if (_Person.Gendor == 0)
                imgPerson.Image = Properties.Resources.Male_512;
            else
                imgPerson.Image = Properties.Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    imgPerson.Load(ImagePath);
                else
                    MessageBox.Show("could not find this image." + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPresonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPresonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationailNO.Text = _Person.NationalNo;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblDateOfBrith.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = _Person.countryInfo.CountryName;
            lblAddress.Text = _Person.Address;
            lblGedor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            _LoadPresonImage();

        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            //refresh
            LoadPresonCard(_PersonID);
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPresonID.Text = "N/A";
            lblName.Text = "[????]";
            lblNationailNO.Text = "[????]";
            lblPhone.Text = "[????]";
            lblGedor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblDateOfBrith.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            imgPerson.Image = Properties.Resources.Male_512;
            llEditPersonInfo.Enabled = false;
        }

        private void ctrlPresonCard_Load(object sender, System.EventArgs e)
        {
            llEditPersonInfo.Enabled = (_Person != null);

        }
    }
}
