using bst;
using DVLD.Properties;
using System;

using System.Windows.Forms;

namespace DVLD
{
    public partial class InternationalLicenseInfo : UserControl
    {
        public InternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public void FillContainer(clsInternationalLicense license)
        {
            if (license != null) {
                lbName.Text = license.Driver.Person.FirstName + " " + license.Driver.Person.SecondName + " " + license.Driver.Person.ThirdName + " " + license.Driver.Person.LastName;
                lbLicenseID.Text=license.IssuedUsingLocalLicense.licenseID.ToString();
                lbNationalNum.Text=license.Driver.Person.NationalNo;
                lbDateOfBirth.Text=license.Driver.Person.DateOfBirth.ToString();
                lbIsActive.Text = (license.IsActive ? "Yes" : "NO");
                lbIssueDate.Text=license.IssueDate.ToString();
                lbGendor.Text = license.Driver.Person.Gender;
                lbExpirationDate.Text=license.ExpirationDate.ToString();
                lbApplicationID.Text=license.Application.ApplicationsID.ToString();
                lbInterLicenseID.Text= license.InternationalLicenseID.ToString();
                lbDriverID.Text=license.Driver.DriverID.ToString();
                if (license.Driver.Person.ImagePath != "")
                {
                    pictureBox2.ImageLocation = license.Driver.Person.ImagePath;
                }
                else
                {
                    pictureBox2.Image = (license.Driver.Person.Gender=="male"?Resources.boy:Resources.girl);
                }

            }
        }
       
        
    }
}
