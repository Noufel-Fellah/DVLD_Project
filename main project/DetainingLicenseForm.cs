using bst;
using bussinessLayer;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace DVLD
{
    public partial class DetainingLicenseForm : Form
    {
        clsLicenses _license;
        clsDetainedLicense _detainedLicense;

        public DetainingLicenseForm()
        {
            InitializeComponent();
        }
        private void FillForm()
        {
            lbCreator.Text = GlobalSettings.currentUser.username;
            lbLicenseID.Text = _license.licenseID.ToString();
            lbDetainedDate.Text = DateTime.Now.ToString();

        }
        private void searchForDrivingLicense1_GetLicence(clsLicenses obj)
        {
            if (!clsDetainedLicense.IsLicenseDetained(obj))
            {
                searchForDrivingLicense1.EnableSearchBar= false;
                _license = obj;
                btnDetain.Enabled = true;
                llShowLicenseHistory.Enabled = true;
                FillForm();
            }
            else {
                MessageBox.Show("This license has already detained,search for  another one");
                }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFineFees.Text))
            {
                _detainedLicense = new clsDetainedLicense(_license, DateTime.Now,float.Parse( tbFineFees.Text),GlobalSettings.currentUser);
                if (_detainedLicense.Save())
                {

                    MessageBox.Show("The license was detained successfully","Message");
                    llShowDetainedLicense.Enabled = true;
                    lbDetainedLicenseID.Text=_detainedLicense.DetainID.ToString();


                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                MessageBox.Show("The fine fees sould be filled");
                tbFineFees.Focus();
            }



        }

        private void tbFineFees_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbFineFees.Text, out int result))
            {
                tbFineFees.Text = "";

            }
           
        }

        

        private void tbFineFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFineFees.Text)){

                e.Cancel = true;
                tbFineFees.Focus();
                errorProvider1.SetError(tbFineFees, "This Field should be filled");
            } else {
                e.Cancel = false;
                errorProvider1.SetError(tbFineFees, "");
            }

        }

        private void llShowDetainedLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicense form = new ShowLicense(_license); 
            form.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonsdrivinglicense_history form = new ShowPersonsdrivinglicense_history(_license.Driver.Person);
            form.ShowDialog();
        }
        
    
    
    
    
    }
}
