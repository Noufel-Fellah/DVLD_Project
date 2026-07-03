using bst;
using bussinessLayer;
using DVLD.Properties;

using System.Windows.Forms;

namespace DVLD
{
    public partial class DriverLicenseInfo : UserControl
    {
        public void FillControl(clsDrivers Driver, clsDrivingLicenseClass licenseClassItem)
        {
           FillControl(clsLicenses.GetLicenseOf(Driver, licenseClassItem.license));
           
         
        
        
        }
        
        public void FillControl(clsLicenses license)
        {
            clsDrivingLicenseClass DrivingClassItem = new clsDrivingLicenseClass(license.LicenseClass);
            lbClass.Text = DrivingClassItem.ClassName;
            lbName.Text =license.Driver.Person.FirstName + " " + license.Driver.Person.SecondName + " " + license.Driver.Person.ThirdName + " " + license.Driver.Person.LastName;
            lbDriverID.Text = license.Driver.DriverID.ToString();
            lbLicenseID.Text = license.licenseID.ToString();
            lbDateOfBirth.Text = license.Driver.Person.DateOfBirth.ToString();
            lbGender.Text = license.Driver.Person.Gender.ToString();
            lbIsActive.Text = (license.IsActive ? "Yes" : "No");
            lbIsDetained.Text = (license.isLicenseDentained() ? "Yes" : "NO");
            lbIssueDate.Text = license.IssueDate.ToString();
            lbExpirationDate.Text = license.ExpirationDate.ToString();
            lbNationalNum.Text = license.Driver.Person.NationalNo;
            lbNotes.Text = (license.Notes != "" ? license.Notes : "No notes");
            lbIssueReason.Text = license.IssueReason.ToString();
            if (license.Driver.Person.ImagePath != "")
            {
                pbDriverImage.ImageLocation = license.Driver.Person.ImagePath;
            }
            else
            {
                if (license.Driver.Person.Gender == "male")
                {
                    pbDriverImage.Image = Resources.boy;
                }
                else
                {
                    pbDriverImage.Image = Resources.girl;

                }
            }
        }
        public DriverLicenseInfo()
        {
            InitializeComponent();

        }

     
    }
}
