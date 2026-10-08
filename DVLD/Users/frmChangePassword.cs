using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUser _User;
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void _ResetDefualtValues()
        {
            txtConfirmPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtConfirmPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUser.FindByUserID(_UserID);

            if (_User == null) 
            {
                //Here we don't continue becuase the from is not valid
                MessageBox.Show("Could not find User with id =" + _UserID.ToString(), "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlUserCard1.LoadUserCard(_UserID);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we don't continue becuase the from is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon");
                return;
            }

            _User.Password = txtNewPassword.Text.Trim();


            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
                MessageBox.Show("An Erro Occured, Password did not change.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtCrruentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtCrruentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCrruentPassword, "Crruent Password cannot be blank!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCrruentPassword, null);
            }

            if (_User.Password != txtCrruentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCrruentPassword, "Crruent Password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCrruentPassword, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password cannot be blank!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

    }
}
