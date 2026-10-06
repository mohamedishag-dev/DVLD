using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        private clsUser _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;
        }
     
        private void _LoadData()
        {

            _User = clsUser.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ctrlPersonWithFilter1.FilterEnabled = false;

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            checkbIsActive.Checked = _User.IsActive;
            txtConfirmPassword.Text = _User.Password;
            ctrlPersonWithFilter1.LoadPersonInfo(_User.PersonID);
        }
     
        private void _ResetDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
                tpLoginInfo.Enabled = false;
                ctrlPersonWithFilter1.Focus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;

            }

            lblUserID.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            checkbIsActive.Checked = true;

        }
     
        private void frmAddUser_Load(object sender, EventArgs e)
        {

            Image imgNext = Resources.Next_64;
            btnNext.Image = new Bitmap(imgNext, new Size(24, 24));

            Image imgPrev = Resources.Prev_64;
            btnPrev.Image = new Bitmap(imgPrev, new Size(24, 24));


            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }
     
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                return;
            }

            //incase of add new mon=de.
            if (ctrlPersonWithFilter1.PersonID != -1)
            {

                if (clsUser.IsUserExistForPersonID(ctrlPersonWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user. Chose another one", "Select another Person",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonWithFilter1.Focus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK);
                ctrlPersonWithFilter1.Focus();
            }
        }
     
        private void btnPrev_Click(object sender, EventArgs e)
        {
            tcUserInfo.SelectedTab = tcUserInfo.TabPages["tbPersonInfo"];
        }
     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we don't continue becuase the from is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrlPersonWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = checkbIsActive.Checked;


            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
            ;

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
            

            if (_Mode == enMode.AddNew)
            {

                if (clsUser.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
                
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.IsUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    }
                    
                }
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
    }

}