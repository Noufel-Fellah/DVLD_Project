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
    public partial class ReleasingDetainedLicense : Form
    {
        clsDetainedLicense detainedLicense;
        clsLicenses license;
        clsApplication application;
        public ReleasingDetainedLicense()
        {
            InitializeComponent();
        }
       private void  InitialleFormByClsDetainedLicense(clsDetainedLicense DetainedLicense)
        {
            license = DetainedLicense.License;
            detainedLicense = DetainedLicense;
            llShowLicenseHistory.Enabled = true;
            btnRelease.Enabled = true;

            searchForDrivingLicense1.EnableSearchBar = false;
            FillForm();
        }
        public ReleasingDetainedLicense(clsDetainedLicense DetainedLicense)
        {
            InitializeComponent();
            InitialleFormByClsDetainedLicense(DetainedLicense);
          
        }
        private void FillForm()
        {
            application = clsApplication.CreateApplication(license.Driver.Person, clsAppType.enAppTypes.ReleaseDetainedDrivingLicsense, GlobalSettings.currentUser);
            lbCreator.Text = GlobalSettings.currentUser.username;
            lbFineFees.Text=detainedLicense.FineFees.ToString();
            lbAppFees.Text=application.paidFees.ToString();
            lbTotalFees.Text = (detainedLicense.FineFees + application.paidFees).ToString();
            lbDetainedLicenseID.Text = detainedLicense.DetainID.ToString();
            lbLicenseID.Text=license.licenseID.ToString();
            llbDetainedDate.Text=detainedLicense.DetainDate.ToString();
        }
        private void searchForDrivingLicense1_GetLicence(clsLicenses obj)
        {
            if (clsDetainedLicense.IsLicenseDetained(obj))
            {
               
                license =obj;
                detainedLicense = clsDetainedLicense.GetDetainedLicense(license);
                llShowLicenseHistory.Enabled= true;
                btnRelease.Enabled= true;
                
                searchForDrivingLicense1.EnableSearchBar = false;
                FillForm();
            }
            else
            {
                MessageBox.Show("This license is not detained");
            }
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonsdrivinglicense_history form = new ShowPersonsdrivinglicense_history(license.Driver.Person);
            form.ShowDialog();
        }

        private void llShowReleasedLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicense form = new ShowLicense(license);
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            application.ApplicationStatus = clsApplication.enAppStatus.Completed;
            if (application.Save())
            {
                lbApplicationID.Text = application.ApplicationsID.ToString();
                detainedLicense.IsReleased = true;
                detainedLicense.ReleaseDate  = DateTime.Now;
                detainedLicense.ReleasedByUser = GlobalSettings.currentUser;
                detainedLicense.ReleaseApplication = application;
                if (detainedLicense.Save())
                {
                    MessageBox.Show("The license has been released succussfully");

                    llShowReleasedLicense.Enabled = true;

                    btnRelease.Enabled =false;


                }
                else
                {
                    MessageBox.Show("Something went wrong");

                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }





        }
    }
}
