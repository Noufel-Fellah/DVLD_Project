using bst;
using bussinessLayer;
using DVLD.Properties;
using System;

using System.Data;

using System.Windows.Forms;

namespace DVLD
{
    public partial class TestScreen : Form
    {
        clsDLApplication _application;
        DataView _appointmentsTable;
        int _trials;
        clsTestTypes.enTestTypes _type;
        private void _SetHeader( )
        {
            switch (_type)
            {
                case clsTestTypes.enTestTypes.VisionTest:
                    pbPictureofTile.Image = Resources.eye;
                    lbTitle.Text = "Vision test";
                    break;
                case clsTestTypes.enTestTypes.WrittenTest:
                    pbPictureofTile.Image = Resources.theory_test ;
                    lbTitle.Text = "Theory test";
                    break;
                case clsTestTypes.enTestTypes.PraticalTest:
                    pbPictureofTile.Image = Resources.pratical_test ;
                    lbTitle.Text = "Pratical test";
                    break;
            }
        }
        private void _LoadData(int ID, clsTestTypes.enTestTypes type)
        {
            clsLocalDrivingLicense app;
            if ((app = clsLocalDrivingLicense.ObjectWithexistedID(ID)) != null) {
                _application = clsDLApplication.initialleLDLAppByLocalDrivingLicenseID(app, clsAppType.enAppTypes.NewLocalDrivingLicenseService);
                _type = type;
                //_SetHeader();
                //showingLDLAppInfo1.FillForm(_application);
                //_appointmentsTable=clsAppointement.GetAllAppointmentsOfLDLID(ID, type);
                //dgvTestAppointmentsTable.DataSource= _appointmentsTable;
                // _trials = _appointmentsTable.Count;
                //lbNumberOfRecords.Text = _trials.ToString();
                _LoadData();

            }

        }

        private void _LoadData()
        {
            _SetHeader();
            showingLDLAppInfo1.FillForm(_application);
            _appointmentsTable = clsAppointement.GetAllAppointmentsOfLDLID(_application.LocalDrivingLicense.originalLLocalDrivingLicenseApplicationsID , _type);
            dgvTestAppointmentsTable.DataSource = _appointmentsTable;
            _trials = _appointmentsTable.Count;
            lbNumberOfRecords.Text = _trials.ToString();
        }


        public TestScreen(int ID,clsTestTypes.enTestTypes type)
        {
            InitializeComponent();
            _LoadData(ID,type);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       private bool _AllAreLockedTest()
        {
            for(int i = 0; i < _appointmentsTable.Count; i++)
            {
                if ( !bool.Parse(_appointmentsTable[i][3].ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        private bool _PermissionToScheduleTest()

        {

            return  !clsTest.PersonPassedTest(_application.LocalDrivingLicense.localDrivingLicenseApplicationsID,_type)&& _AllAreLockedTest();
        }
        private void btnAddApointment_Click(object sender, EventArgs e)
        {
            if (_appointmentsTable.Count==0) {
                //-1:add new appointment operation
                //otherwise the value of  an ID is :update an appoitment operation
                TestSubscribtionScreen form = new TestSubscribtionScreen(-1, _application, _type, _trials);
                form.ShowDialog();
                _LoadData();
            }
            else if (_PermissionToScheduleTest())
            {
                TestSubscribtionScreen form = new TestSubscribtionScreen(-1, _application, _type, _trials,true);
                form.ShowDialog();
                _LoadData();
            }



        }


        private void dgvTestAppointmentsTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvTestAppointmentsTable.ClearSelection();
                dgvTestAppointmentsTable.Rows[e.RowIndex].Selected = true;
                dgvTestAppointmentsTable.CurrentCell = dgvTestAppointmentsTable.Rows[e.RowIndex].Cells[0];

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTestAppointmentsTable.CurrentRow != null)
            {
                TestSubscribtionScreen form = new TestSubscribtionScreen(int.Parse(dgvTestAppointmentsTable.CurrentRow.Cells["TestAppointmentID"].Value.ToString()),_application,_type,_trials);
                form.ChangedColumn(clsAppointement.enSavedColumn.DateApointmentColumn);
                form.ShowDialog();
                _LoadData();
            }
        }

        private void takeTheTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTestAppointmentsTable.CurrentRow != null)
            {
                TakeTestScreen form = new TakeTestScreen(int.Parse(dgvTestAppointmentsTable.CurrentRow.Cells["TestAppointmentID"].Value.ToString()), _application, _type, _trials);
                //form.ChangedColumn(clsAppointement.enSavedColumn.DateApointmentColumn);
                form.ShowDialog();
                _LoadData();
            }
        }
    }
}
