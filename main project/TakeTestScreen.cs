using bst;
using bussinessLayer;
using DVLD.Properties;
using System.Windows.Forms;

namespace DVLD
{
    public partial class TakeTestScreen : Form
    {
        clsTest _test;
        clsAppointement _appointement;
       private void _initialleHeader(clsTestTypes.enTestTypes testType)
        {

            switch (testType)
            {

                case clsTestTypes.enTestTypes.VisionTest:
                    gbTestTypeTitle.Text = "Vision test";
                    pictureBox1.Image = Resources.eye;
                    lbTitle.Text = "Taking vision test";
                    break;
                case clsTestTypes.enTestTypes.WrittenTest:
                    gbTestTypeTitle.Text = "written test";
                    pictureBox1.Image = Resources.theory_test ;
                    lbTitle.Text = "Taking written test";
                    break;
                case clsTestTypes.enTestTypes.PraticalTest:
                    gbTestTypeTitle.Text = "Pratical test";
                    pictureBox1.Image = Resources.pratical_test;
                    lbTitle.Text = "Taking Pratical test";
                    break;


            }
        }

        private void _LoadData(int appointmentID, clsDLApplication app, clsTestTypes.enTestTypes testType, int trial)
        {
            _initialleHeader(testType);
             _appointement = clsAppointement.CreateAppointment(appointmentID);
            lbDLAppID.Text=app.LocalDrivingLicense.originalLLocalDrivingLicenseApplicationsID.ToString();
            lbDrivingClass.Text=app.Dclass.ToString();
            lbName.Text = app.Person.FirstName + app.Person.SecondName+ app.Person.ThirdName+ app.Person.LastName;
            lbTestDate.Text=_appointement.AppointmentDate.ToString();
            lbTrials.Text=trial.ToString();
            lbTestFees.Text = _appointement.PaidFees.ToString();
             _test = new clsTest(_appointement, GlobalSettings.currentUser);
            if (_appointement.IsLocked)
            {
                btnSave.Enabled = false;
                rdPass.Checked = _test.TestResult;
                tbNotes.Text =_test.Notes;


            }

        }
       
        public TakeTestScreen(int appointmentID, clsDLApplication app, clsTestTypes.enTestTypes testType, int trial)
        {
          
            InitializeComponent();
            _LoadData(appointmentID,app,testType,trial);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the changes?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
               
                _test.Notes = tbNotes.Text;
                _test.TestResult = rdPass.Checked;
                if(_test.Save())
                {
                    MessageBox.Show("The test was saved successfully");
                    rdFail.Enabled = false;
                    rdPass.Enabled = false;
                    tbNotes.Enabled=false;

                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
                
                
            }
        }
    }
}
