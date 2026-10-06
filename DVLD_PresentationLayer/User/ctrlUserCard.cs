using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class ctrlUserCard : UserControl
    {
        private clsUser _User;
        private int _UserID = -1;
        public int UserID
        { 
            get { return _UserID; }
        }
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserCard(int userID)
        {
            _UserID = userID;
            _User = clsUser.FindByUserID(userID);

            if (_User == null)
            {
                _ResetUserInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            
            ctrlPresonCard1.LoadPresonCard(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";

        }

        private void _ResetUserInfo()
        {

           ctrlPresonCard1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";

        }


    }
}
