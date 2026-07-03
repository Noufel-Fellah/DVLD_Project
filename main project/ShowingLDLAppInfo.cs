using bussinessLayer;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ShowingLDLAppInfo : UserControl
    {
        public ShowingLDLAppInfo()
        {
            InitializeComponent();
        }
        clsPerson _person;
        public void FillForm( clsDLApplication application)
        {
            if (application != null)
            {
                _person =application.Person;
                lbApplicant.Text = application.Person.FirstName + " " + application.Person.SecondName + " " + application.Person.ThirdName + " " + application.Person.LastName;
                lbApplicationDate.Text=application.application.ApplicationDate.ToString();
                lbApplicationID.Text=application.application.ApplicationsID.ToString();
                lbApplicationStutasDate.Text=application.application.LastStatusDate .ToString();
                lbAppliedForLicense.Text = application.Dclass.ToString();
                lbUser.Text = application.user._person.FirstName + " " + application.user._person.SecondName + " " + application.user._person.ThirdName + " " + application.user._person.LastName;
                lbPassedTests.Text = application.LocalDrivingLicense.passedTest.ToString();
                lbDLAppID.Text = (application.LocalDrivingLicense.originalLLocalDrivingLicenseApplicationsID == -1 ? application.LocalDrivingLicense.localDrivingLicenseApplicationsID.ToString() : application.LocalDrivingLicense.originalLLocalDrivingLicenseApplicationsID.ToString());
                lbFees.Text=application.application.paidFees.ToString();
                lbType.Text = application.appType.ToString();
                lbStatus.Text = application.application.ApplicationStatus.ToString();



                    }
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowDetailsScreen form = new ShowDetailsScreen(_person);
            form.ShowDialog();
            _person = clsPerson.FindPerson(_person.PersonID);
            lbApplicant.Text = _person.FirstName + " " + _person.SecondName + " " + _person.ThirdName + " " + _person.LastName;

        }
    }
}
