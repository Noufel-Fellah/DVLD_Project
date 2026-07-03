using bussinessLayer;
using System;

using System.Windows.Forms;

namespace DVLD
{
    public partial class NewLocalDrivingLicense : Form
    {
       private clsPerson _person;
        private void _LoadData()
        { 


            searchAboutPerson1.SetPerson();
            lbAppDate.Text = DateTime.Now.ToString();
            lbAppFees.Text = clsAppType.FindApp(clsAppType.enAppTypes.NewInternationalLicense).appTypeFees.ToString();
            lbUserCreator.Text = GlobalSettings.currentUser.userID.ToString();
            cmLicenseClass.DataSource=clsDrivingLicenseClass.GetAllClasses();
            cmLicenseClass.SelectedIndex = 0;



        }
        public NewLocalDrivingLicense()
        {
            InitializeComponent();
            _LoadData();
           
        }

       

        private void searchAboutPerson1_NextOption(bussinessLayer.clsPerson person)
        {
           
            if (person != null)
            {
                _person = person;
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                MessageBox.Show("You have not  added a person");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsDrivingLicenseClass.enDLC dClass = (clsDrivingLicenseClass.enDLC)(cmLicenseClass.SelectedIndex + 1);
            clsDLApplication application;
            if ((application = clsDLApplication.CreateObject(_person, clsAppType.enAppTypes.NewLocalDrivingLicenseService, clsApplication.enAppStatus.New, dClass, GlobalSettings.currentUser, DateTime.Parse(lbAppDate.Text), DateTime.Parse(lbAppDate.Text))) != null)
            {
                if (application.Save())
                {
                    MessageBox.Show("The application has been saved successfully");
                    lbDLAppID.Text = application.application.ApplicationsID.ToString();





                }
                else
                {
                    MessageBox.Show("Something went error.404");
                }
               
            }
            else
            {
                MessageBox.Show($"Error,You can't applicate this application ,if you've{cmLicenseClass.SelectedItem} a driving obj or already have a previous application");
                btnEnterInforamtionAgain.Visible=true;
                btnEnterInforamtionAgain.Enabled = true;

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       private void _ClearForm()
        {
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnEnterInforamtionAgain.Visible = false;
            btnEnterInforamtionAgain.Enabled = false;
            tabControl1.SelectedTab = tabPage1;
            searchAboutPerson1.EmptyPerson() ;
            lbAppDate.Text = DateTime.Now.ToString();
            lbAppFees.Text = clsAppType.FindApp(clsAppType.enAppTypes.NewInternationalLicense).appTypeFees.ToString();
            _person = null;
        }
        private void btnEnterInforamtionAgain_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSave.Visible = false;
            _ClearForm();
            
        }
    }
}
