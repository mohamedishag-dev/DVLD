using DVLD_BusinessLayer;
using DVLD_PresentationLayer.People;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Controls
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {

        public int ApplicationBasicID
        {
            get { return _ApplicationBasicID; }
        }
        private int _ApplicationBasicID = -1;
        private clsApplication _ApplicationBasic;

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void ResetApplicationBasic()
        {

            //Reset Application Basic Info
            _ApplicationBasicID = -1;
            lbID.Text = "N/A";
            lblStatus.Text = "[????]";
            lblFess.Text = "0";
            lblType.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreatedBy.Text = "[????]";
            llViewPersonInfo.Enabled = false;
        }

        private void _FillApplicationBasicInfo()
        {

            //Fill Application Basic Info
            lbID.Text = _ApplicationBasic.ApplicationID.ToString();
            lblStatus.Text = _ApplicationBasic.StatusText;
            lblFess.Text = _ApplicationBasic.PaidFees.ToString();
            lblType.Text = _ApplicationBasic.ApplicationTypeInfo.Title.ToString();
            lblApplicant.Text = _ApplicationBasic.PersonInfo.FullName.ToString();
            lblDate.Text = _ApplicationBasic.ApplicationDate.ToShortDateString();
            lblStatusDate.Text = _ApplicationBasic.LastStatusDate.ToShortDateString();
            lblCreatedBy.Text = _ApplicationBasic.CreatedByUser.UserName.ToString();
            llViewPersonInfo.Enabled = true;
        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _ApplicationBasicID = ApplicationID;
            _ApplicationBasic = clsApplication.FindBaseApplication(_ApplicationBasicID);
            llViewPersonInfo.Enabled = (_ApplicationBasic != null);

            if (_ApplicationBasic == null)
            {
                _ApplicationBasicID = -1;
                ResetApplicationBasic();
                MessageBox.Show("No Application with ApplicationID = " + _ApplicationBasicID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillApplicationBasicInfo();

        }

        private void ctrlApplicationBasicInfo_Load(object sender, EventArgs e)
        {
            llViewPersonInfo.Enabled = (_ApplicationBasic != null);

        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_ApplicationBasic.ApplicantPersonID);
            frm.ShowDialog();

            LoadApplicationInfo(_ApplicationBasicID);
        }
   
    }
}
