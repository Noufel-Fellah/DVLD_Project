using bst;
using bussinessLayer;
using System;

using System.Windows.Forms;

namespace DVLD
{
    public partial class InternationalDrivingLicenseApplication : Form
    {
        clsInternationalLicense _license;

        private void _LoadData()//Fill the international obj info in an event body

        {
            lbAppDate.Text = DateTime.Now.ToString();
            lbCreatedByUserID.Text = GlobalSettings.currentUser.userID.ToString();
            lbFees.Text = clsAppType.FindApp(clsAppType.enAppTypes.NewInternationalLicense).appTypeFees.ToString(); ;
            lbExpirationDate.Text = DateTime.Now.AddYears(1).ToString();
            lbIssueDate.Text = DateTime.Now.ToString();


        }
        public InternationalDrivingLicenseApplication()
        {
            InitializeComponent();
            _LoadData();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to complete the application's procedures  ", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
            {
                this.Close();

            }
        }

        private void searchForDrivingLicense2_GetLicence(bst.clsLicenses obj)
        {
            if (obj.LicenseClass == clsDrivingLicenseClass.enDLC.OrdinaryDrivingLicense)
            {
                lbLocalDrivingLicenseID.Text = obj.licenseID.ToString();
               //lbLocalDrivingLicenseID.Text = obj.licenseID.ToString();
                if ((_license = clsInternationalLicense.CreateInternationalLicense(obj)) != null)
                {
                    lbApplicationID.Text = _license.Application.ApplicationsID.ToString();
                    lbInternationalDriivngLicenseID.Text = _license.InternationalLicenseID.ToString();
                    btnIssue.Enabled = false;
                    llShowLicenseInfo.Enabled = true;

                }
                else
                {
                    btnIssue.Enabled = true;

                    _license = clsInternationalLicense.CreateInternationalLicense(obj, GlobalSettings.currentUser);
                }
            }
            else
            {
                MessageBox.Show("The licese shall be ordinary driving class Oldlicense");
                btnIssue.Enabled = false;

            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_license.Save())
            {

                lbApplicationID.Text = _license.Application.ApplicationsID.ToString();
                lbInternationalDriivngLicenseID.Text = _license.InternationalLicenseID.ToString();

                MessageBox.Show("The international driving obj has been issued successufully");
                btnIssue.Enabled = false;
                llShowLicenseInfo.Enabled = true;

            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonsdrivinglicense_history form = new ShowPersonsdrivinglicense_history(_license.Driver.Person);
            form.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowInter_license_Info form = new ShowInter_license_Info(_license);
            form.ShowDialog();
        }
    }
}
