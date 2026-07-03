using bst;
using bussinessLayer;
using System;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class IssueingForLostOrDamagedLicenseForm : Form
    {
        public IssueingForLostOrDamagedLicenseForm()
        {
            InitializeComponent();
        }
        clsApplication application;
        clsLicenses newLicense;
        clsLicenses oldLicense;

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {

            if (rbDamagedLicense.Checked) {

                lbTilte.Text = "Replacement for damaged license";
                btnIssueLicense.Text ="Replacement For damaged license";


            }
            else
            {
                lbTilte.Text = "Replacement for lost license";
                btnIssueLicense.Text = "Replacement for lost license";
            }
            _FillForm();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FillForm()
        {
            if (rbDamagedLicense.Checked)
            {
                application = clsApplication.CreateApplication(oldLicense.Driver.Person,clsAppType.enAppTypes.ReplacementForADamagedDrivingLicense,GlobalSettings.currentUser);
            
            }
            else
            {
                application = clsApplication.CreateApplication(oldLicense.Driver.Person, clsAppType.enAppTypes.ReplacementForALostDrivingLicense, GlobalSettings.currentUser);
                lbApplicationFees.Text = application.paidFees.ToString();

            }
            lbApplicationFees.Text = application.paidFees.ToString();
          
        }
        private void searchForDrivingLicense1_GetLicence(bst.clsLicenses obj)
        {
            oldLicense = obj;   
            llShowLicenseHistrory.Enabled= true;
            lbCreatedByUSER.Text = GlobalSettings.currentUser.username;
            lbApplicationDate.Text = DateTime.Now.ToString();
            lbOldLicenseID.Text=obj.licenseID.ToString();
           btnIssueLicense.Enabled= true;
            _FillForm();
        }

        private void llShowLicenseHistrory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonsdrivinglicense_history form = new ShowPersonsdrivinglicense_history(oldLicense.Driver.Person);
            form.ShowDialog();


        }

        private void llShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           ShowLicense form =new ShowLicense(newLicense);
            form.ShowDialog();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            application.ApplicationStatus = clsApplication.enAppStatus.Completed;
            if (application.Save())
            {
                newLicense = clsLicenses.CreateNewDrivingLicense(oldLicense.Driver, GlobalSettings.currentUser, application, oldLicense.LicenseClass);
                newLicense.PaidFees = 0;
                newLicense.IssueDate = oldLicense.IssueDate;
                lbApplicationID.Text=application.ApplicationsID.ToString();
                oldLicense.IsActive = false;
                if (newLicense.Save() && oldLicense.Save())
                {

                    lbReplacedLicenseID .Text = newLicense.licenseID.ToString();
                    MessageBox.Show($"You new license is issued with ID{newLicense.licenseID}");
                    llShowNewLicense.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
                btnIssueLicense.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
