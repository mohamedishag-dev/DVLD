using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Local_License
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        private int _LicenseID = -1;
        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                btnFindLicense.PerformClick();

            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            _LicenseID = int.Parse(txtFilterValue.Text);
            ctrlDriverLicenseInfo1.LoadLicenseCard(_LicenseID);
            
        }
    }
}
