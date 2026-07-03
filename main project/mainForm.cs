using bst;
using bussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainMenue : Form
    {
        public MainMenue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeopleManagement form=new PeopleManagement();
            form.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserManagement form =new UserManagement();
            form.ShowDialog();
        }

        

        private void btnAccountSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cmsAccountSettings.Show(btnAccountSettings, 0, btnAccountSettings.Height);





            }
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetailsInUserManagement form=new ShowDetailsInUserManagement(GlobalSettings.currentUser);
            form.ShowDialog();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChangePasswordScreen form = new ChangePasswordScreen(GlobalSettings.currentUser);
            form.ShowDialog();


        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deniedLicneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cmsApplicationsManipulation.Show(button2, 0, button2.Height);





            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAppType form = new ManageAppType();
            form.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestType form = new ManageTestType();
            form.ShowDialog();

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicense form= new NewLocalDrivingLicense();
            form.ShowDialog();
        }

        

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLDLApp form=new ManageLDLApp();
            form.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalDrivingLicenseApplication form=new InternationalDrivingLicenseApplication();
            form.ShowDialog();
        }

        private void internatioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfInternationalDrivingLicenses form =new ListOfInternationalDrivingLicenses();
            form.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicenseForm form = new RenewLicenseForm();
            form.ShowDialog();
        }

      

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueingForLostOrDamagedLicenseForm form = new IssueingForLostOrDamagedLicenseForm();
            form.ShowDialog();
        }

        private void detainALicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainingLicenseForm form =new DetainingLicenseForm();
            form.ShowDialog();
        }

        private void releaseADetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleasingDetainedLicense form = new ReleasingDetainedLicense();
            form.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDetainedLicensesForm form = new ListDetainedLicensesForm();
            form.ShowDialog();
        }
    }
}
