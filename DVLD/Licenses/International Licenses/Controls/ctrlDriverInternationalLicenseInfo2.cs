using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.International_Licenses.Controls
{
    public partial class ctrlDriverInternationalLicenseInfo2 : UserControl
    {
       private clsInternationalLicense _InternationalLicense;
        public ctrlDriverInternationalLicenseInfo2()
        {
            InitializeComponent();
        }

        public void LoadInternationalApplication(int LicenseID)
        {
            _InternationalLicense = clsInternationalLicense.FindByID(LicenseID);

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();
            
            lblExpirationDate.Text = DateTime.Now.AddYears(clsLicenseClass.Find((int)clsApplication.enApplicationType.NewInternationalLicense).DefaultValidityLength).ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

        }

     
    }
}
