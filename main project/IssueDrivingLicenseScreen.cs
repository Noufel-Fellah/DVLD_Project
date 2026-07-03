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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class IssueDrivingLicenseScreen : Form
    {
       //clsDLApplication _application;
        clsLicenses _licenses;
        //clsDrivers _driver;
        private void _LoadData(int appID)
        {
            clsLocalDrivingLicense LDLobj = clsLocalDrivingLicense.ObjectWithexistedID(appID);
            if (LDLobj != null)
            {
                clsDLApplication _application = clsDLApplication.initialleLDLAppByLocalDrivingLicenseID(LDLobj, clsAppType.enAppTypes.NewLocalDrivingLicenseService);
                showingLDLAppInfo1.FillForm(_application);
                
                _licenses = clsLicenses.CreateNewDrivingLicense(new clsDrivers(_application.Person, _application.user), _application.user, _application.application, _application.Dclass) ;
                
            }
         

        }
        public IssueDrivingLicenseScreen(int appID)
        {
            InitializeComponent();
            _LoadData(appID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_licenses.Driver.Save())
            {
                 tbNotes.Text=_licenses.Notes;
                int f = 4;
                if (_licenses.Save())
                {

                    _licenses.Application.ApplicationStatus = clsApplication.enAppStatus.Completed;
                    if (_licenses.Application.Save())
                    {
                       
                        MessageBox.Show("obj has been saved successfully");

                    }

                }
                else
                {
                    MessageBox.Show("Something went wrong part 2");

                }
            }
            else
            {
                MessageBox.Show("Something went wrong part 1");
            }
        }
    }
}
