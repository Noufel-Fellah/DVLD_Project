using bst;
using bussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ShowLicense : Form
    {
        private void _LoadData(clsDrivers driver, clsDrivingLicenseClass licenseClassItem)
        {
            driverLicenseInfo1.FillControl( driver, licenseClassItem);

        }
        public ShowLicense(clsDrivers driver, clsDrivingLicenseClass licenseClassItem)
        {
            InitializeComponent();
            _LoadData(driver, licenseClassItem);
        }

        public ShowLicense(clsLicenses license)
        {
            InitializeComponent();
            driverLicenseInfo1.FillControl(license);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
