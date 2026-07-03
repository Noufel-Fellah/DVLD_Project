using bst;
using bussinessLayer;
using System;

using System.Windows.Forms;

namespace DVLD
{
    public partial class RenewLicenseForm : Form
    {
        clsLicenses _oldlicense;
        clsLicenses _newlicense;
        clsApplication application; 

        public RenewLicenseForm()
        {
            InitializeComponent();
        }

        private void llShowHistroyOfTheDriver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonsdrivinglicense_history form = new ShowPersonsdrivinglicense_history(_newlicense.Driver.Person);
            form.ShowDialog( );
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicense form = new ShowLicense(_newlicense);
            form.ShowDialog( );
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void fillForm()
        {
            btnRenew.Enabled = false;
            application = clsApplication.CreateApplication(_oldlicense.Driver.Person,clsAppType.enAppTypes.RenewDrivingLicenseService,GlobalSettings.currentUser);
            lbCreatedUser.Text = GlobalSettings.currentUser.username;
            lbOldLicenseID.Text = _oldlicense.licenseID.ToString();
            lbappFees.Text=application.paidFees.ToString();
            lbLicenseFees.Text=(new clsDrivingLicenseClass(_oldlicense.LicenseClass)).ClassFees.ToString();
            lbappDate.Text = DateTime.Now.ToString();
            lbIssueDate.Text = DateTime.Now.ToString();
            lbTotalFees.Text = (application.paidFees+int.Parse(lbLicenseFees.Text)).ToString();




        }
        private void searchForDrivingLicense1_GetLicence(bst.clsLicenses obj)
        {
            if(DateTime.Compare(obj.ExpirationDate,DateTime.Now)>0)
            {
                MessageBox.Show($"this obj will expired in {obj.ExpirationDate}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                llShowHistroyOfTheDriver.Enabled = false;
                llShowNewLicenseInfo.Enabled = false;
                return;
            }
           
            _oldlicense = obj;
            fillForm();
            btnRenew.Enabled = true;
            llShowHistroyOfTheDriver.Enabled = true;
        
        
        
        
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            application.ApplicationStatus = clsApplication.enAppStatus.Completed;
            if (application.Save())
            {
                _newlicense = clsLicenses.CreateNewDrivingLicense(_oldlicense.Driver, GlobalSettings.currentUser, application, _oldlicense.LicenseClass);
                lbRLAppID.Text = application.ApplicationsID.ToString();
                _newlicense.Notes=textBox1.Text;
                _oldlicense.IsActive = false;
                if (_newlicense.Save() && _oldlicense.Save())
                {
                    lbRenewedLicenseID.Text=_newlicense.licenseID.ToString();
                    lbExpirationDate.Text=_newlicense.ExpirationDate.ToString();
                    MessageBox.Show($"You new license is issued with ID{_newlicense.licenseID}");
                    llShowNewLicenseInfo.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }else
            {
                MessageBox.Show("Something went wrong");
            }
        }
        

    
    
    }
}
