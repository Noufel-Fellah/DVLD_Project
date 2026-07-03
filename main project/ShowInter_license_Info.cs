using bst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DVLD
{
    public partial class ShowInter_license_Info : Form
    {
       private void  _LoadData(clsInternationalLicense license)
        {
            internationalLicenseInfo1.FillContainer(license);
        }
        public ShowInter_license_Info(clsInternationalLicense license)
        { 
            InitializeComponent();
            _LoadData(license);
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
