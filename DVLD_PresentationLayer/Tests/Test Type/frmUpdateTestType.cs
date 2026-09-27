using DVLD.Classes;
using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmUpdateTestType : Form
    {

        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsTestType _TestType;
        public frmUpdateTestType(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
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
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon");
                return;
            }

            _TestType.Title = txtTypeTitle.Text.Trim();
            _TestType.Description = txtDescription.Text.Trim();
            _TestType.Fees = Convert.ToSingle(txtFees.Text.Trim());

            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {

            _TestType = clsTestType.Find(_TestTypeID);
            if (_TestType != null)
            {
                lblApplicationTypeID.Text = ((int)_TestType.ID).ToString();
                txtTypeTitle.Text = _TestType.Title;
                txtDescription.Text = _TestType.Description;
                txtFees.Text = _TestType.Fees.ToString();
            }
            else
            {
                MessageBox.Show("Cpuld not Test Type with id = " + _TestTypeID.ToString());
                this.Close();
            }
        }

        private void txtTypeTitle_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtTypeTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTypeTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtTypeTitle, null);
            }

        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFees, null);

            }


            if (!clsValidatoin.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }


        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtDescription, null);
            }
        }
    }
}
