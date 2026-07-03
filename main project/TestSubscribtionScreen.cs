using bst;
using bussinessLayer;
using DVLD.Properties;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    //Trial=The number of test  Appointments that a person subscribes in
    public partial class TestSubscribtionScreen : Form
    {
        clsAppointement.enSavedColumn _savedColumn;
        clsDLApplication _app;
        clsAppointement _appointment;
        bool _retakingTest;
        private void _LoadData(int testAppointmentID, clsDLApplication app, clsTestTypes.enTestTypes testType, int trial,bool retakingTest)
        {
            _retakingTest = retakingTest;
            _app = app;
            lbDLAppID.Text = _app.LocalDrivingLicense.localDrivingLicenseApplicationsID.ToString();
            lbDrivingClass.Text = _app.Dclass.ToString();
            lbName.Text = _app.Person.FirstName + _app.Person.SecondName + _app.Person.ThirdName + _app.Person.LastName;
            lbTrials.Text = trial.ToString();
            _appointment = clsAppointement.CreateAppointment(testAppointmentID);
            if (_appointment._mode == clsAppointement.enMode.UPDATE)
            {
             
                if (_appointment.IsLocked)
                {
                    dtpTestDate.Enabled = false;

                    dtpTestDate.Value = _appointment.AppointmentDate;

                }
                else
                {
                    dtpTestDate.Value = _appointment.AppointmentDate;
                   
                    dtpTestDate.MinDate = DateTime.Now;//reducing the mistakes of course there is no schedule a test in date which was past

                }
            }
            else
            {
                dtpTestDate.Value = DateTime.Now ;
                dtpTestDate.MinDate = DateTime.Now;//reducing the mistakes of course there is no schedule a test in date which was past

            }
            float fees = clsTestTypes.FindTest((int)testType).TestTypeFees;
            lbTestFees.Text = fees.ToString();
           
           _appointment.TestType = testType;
            _appointment.PaidFees = fees;
            _appointment.IsLocked = false;
            _appointment.LDLAID = _app.LocalDrivingLicense.localDrivingLicenseApplicationsID;
            switch (testType) {
                case clsTestTypes.enTestTypes.VisionTest:
                    pbFrontPicture.Image = Resources.eye;
                    break;
                case clsTestTypes.enTestTypes.WrittenTest:
                    pbFrontPicture.Image = Resources.theory_test;
                    break;
                case clsTestTypes.enTestTypes.PraticalTest:
                    pbFrontPicture.Image= Resources.pratical_test;
                    break;
            
            
            }

            if (trial > 0)
            {
                //write the logic of gpRetake test in here
                gpRetakeTest.Enabled = true ;
                lbTitle.Text = "Schedule retake test";
                    float retakeTestFees =clsAppType.FindApp(clsAppType.enAppTypes.RetakeTest).appTypeFees;
                lbReTestFees.Text = retakeTestFees.ToString();
                _appointment.PaidFees += retakeTestFees;
                lbTotalFees.Text=(retakeTestFees + fees).ToString();
            }
        }
       
        public TestSubscribtionScreen(int testID,clsDLApplication app,clsTestTypes.enTestTypes testType,int trial,bool retakingTest=false)
        {
            //-1:add new appointment operation
            //otherwise the value of  an ID is :update an appoitment operation.
            InitializeComponent();
            _LoadData(testID,app,testType,trial,retakingTest);


        }
        public void ChangedColumn(clsAppointement.enSavedColumn savedColumn)
        {
            _savedColumn = savedColumn;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
           this. Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //return this to make it more better.
            if (MessageBox.Show("Do you wanna schedule the test", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                bool PermissionForSaving = false;
                if (_appointment._mode == clsAppointement.enMode.ADD)
                {
                    _appointment.CreatedByUserID = GlobalSettings.currentUser.userID;
                    _appointment.AppointmentDate = dtpTestDate.Value;
                    PermissionForSaving = true;

                }
                if (_appointment._mode == clsAppointement.enMode.UPDATE && _appointment.AppointmentDate != dtpTestDate.Value)
                {
                    _appointment.AppointmentDate = dtpTestDate.Value;
                    PermissionForSaving = true;
                }

                if (PermissionForSaving)
                {
                    if (_appointment.Save(_savedColumn))
                    {
                        MessageBox.Show("Test appointment has been saved successfully");
                        dtpTestDate.Enabled = false;
                        btnSave.Enabled = false;
                        if (_retakingTest) {
                        lbRetestAppID.Text= clsDLApplication.CreateRetakeTest(_app.Person, GlobalSettings.currentUser, _app.LocalDrivingLicense, DateTime.Now).application.ApplicationsID.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }

            }
        }
        
    
    
    }
}
