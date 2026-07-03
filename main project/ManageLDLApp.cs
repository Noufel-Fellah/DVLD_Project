using bst;
using bussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManageLDLApp : Form
    {
        private DataView _LDLappTable;
        private string []_ChoicesOfstatus = { "All","New", "Cancelled", "Completed" };
        private List<string> _lsDrivingClass;
        private void _initial_lsDrivingClass()
        {
            _lsDrivingClass=new List<string>();
            _lsDrivingClass.Add("All");

            foreach(string Dclass in  clsDrivingLicenseClass.GetAllClasses()){

                _lsDrivingClass.Add(Dclass);

            }
        }
        private void _LoadData()                    
        {                                  
            _LDLappTable = clsLocalDrivingLicense.GetAllLDLApplications();
            dgvLDLapp.DataSource = _LDLappTable;
            lbNumOfRecords.Text=_LDLappTable.Count.ToString();
            cbFiltrationList.SelectedIndex= 0;
            if (_lsDrivingClass == null)
            {
                _initial_lsDrivingClass();
            }
   

        }
        public ManageLDLApp()
        {
            InitializeComponent();
            _LoadData();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FilterScreenBy(string filterby="")
        {
            _LDLappTable.RowFilter = filterby;
            lbNumOfRecords.Text = _LDLappTable.Count.ToString();

        }
        private void cbFiltrationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbFiltrationList's items
            //0- none
            //1- LDLApp
            //2- NationalNo
            //3- DrivingClass->need  a combo box
            //4- FullName.
            //5- _applicationDate ->need a time picker controlle.
            //6- ApplicationStatus->need a combo box.
            //7- passedTests
            if (cbFiltrationList.SelectedIndex== 0)
            {
                cbStatusAndDrivingClassItems.Visible = false;
                tbSearchBar.Visible = false;
                _FilterScreenBy();
            }else if(cbFiltrationList.SelectedIndex==3|| cbFiltrationList.SelectedIndex == 6 )
            {
                int index = cbFiltrationList.SelectedIndex;
                cbStatusAndDrivingClassItems.Visible = true;
                tbSearchBar.Visible = false;
                if (index == 6) cbStatusAndDrivingClassItems.DataSource = _ChoicesOfstatus;
                else cbStatusAndDrivingClassItems.DataSource =_lsDrivingClass;


                cbStatusAndDrivingClassItems.SelectedItem = 0;
            }
            else
            {
                cbStatusAndDrivingClassItems.Visible = false;
                tbSearchBar.Visible=true;
            }
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {
            //cbFiltrationList's items
            //0- none
            //1- LDLApp
            //2- NationalNo
            //3- DrivingClass->need  a combo box
            //4- FullName.
            //5- _applicationDate ->need a time picker controlle.
            //6- ApplicationStatus->need a combo box.
            //7- passedTests

            if (cbFiltrationList.SelectedIndex==1|| cbFiltrationList.SelectedIndex == 7)
            {
                if(!int.TryParse(tbSearchBar.Text, out int result))
                {
                    tbSearchBar.Clear();
                }
                else
                {
                    _FilterScreenBy($"{cbFiltrationList.SelectedItem} = {tbSearchBar.Text}");

                  
                } 

            }else if (cbFiltrationList.SelectedIndex == 2 || cbFiltrationList.SelectedIndex == 4)
            {
                _FilterScreenBy($"{cbFiltrationList.SelectedItem} like '{tbSearchBar.Text}%'");

            }
          
        }

        private void cbStatusAndDrivingClassItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            //CbStatusAndDrivingClassItems' items if the status choice is selected
            //0- 1-New,2-Cancelled,3-Completed
            //CbStatusAndDrivingClassItems' items if the Driving Class choice is selected
            //  0-All
            //1-Class 1 - Small Motorcycle
            //2-Class 2 - Heavy Motorcycle License
            //3-Class 3 - Ordinary driving obj
            //4-Class 4 - Commercial
            //5-Class 5 - Agricultural
            //6-Class 6 - Small and medium bus
            //7-Class 7 - Truck and heavy vehicle
            if (cbStatusAndDrivingClassItems.SelectedIndex != 0)
            {
               
                _FilterScreenBy($"{cbFiltrationList.SelectedItem} = '{cbStatusAndDrivingClassItems.SelectedItem}'");
            }
            else _FilterScreenBy();


        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicense form = new NewLocalDrivingLicense();
            form.ShowDialog();
            _LoadData();
        }

      

        private void dgvLDLapp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvLDLapp.ClearSelection();
                dgvLDLapp.Rows[e.RowIndex].Selected = true;
                dgvLDLapp.CurrentCell = dgvLDLapp.Rows[e.RowIndex].Cells[0];
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //Diable and enable the items of context menuStrip depending on app status and passed test
            if (dgvLDLapp .CurrentRow != null)
            {
              if (  dgvLDLapp.CurrentRow.Cells["ApplicationStatus"].Value.ToString()== "New") {
                    editApplicationToolStripMenuItem.Enabled = true;
                    cancelApplicationToolStripMenuItem.Enabled = true;
                    if (int.Parse(dgvLDLapp.CurrentRow.Cells["passedTests"].Value.ToString())!= 3)
                    {
                        sechduleTestsToolStripMenuItem.Enabled = true;
                        //enable test types depending on the number of passed tests
                        if (int.Parse(dgvLDLapp.CurrentRow.Cells["passedTests"].Value.ToString()) == 0)
                        {
                            visionTesttToolStripMenuItem.Enabled = true;
                            theoryTestToolStripMenuItem.Enabled = false;
                            praticalTestToolStripMenuItem.Enabled = false;
                        }
                        else if (int.Parse(dgvLDLapp.CurrentRow.Cells["passedTests"].Value.ToString()) == 1)
                        {
                            visionTesttToolStripMenuItem.Enabled = false;
                            theoryTestToolStripMenuItem.Enabled = true;
                            praticalTestToolStripMenuItem.Enabled = false;
                        }
                        else if (int.Parse(dgvLDLapp.CurrentRow.Cells["passedTests"].Value.ToString()) == 2)
                        {
                            visionTesttToolStripMenuItem.Enabled = false;
                            theoryTestToolStripMenuItem.Enabled = false;
                            praticalTestToolStripMenuItem.Enabled = true;
                        }


                    }
                    else
                    {
                        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                    }


                }
              else if (dgvLDLapp.CurrentRow.Cells["ApplicationStatus"].Value.ToString() == "Completed") { 
                
                    showLicenseToolStripMenuItem.Enabled = true;
                    showPersonsDrivingLicenseToolStripMenuItem.Enabled = true;
                
                }
               
            
            
            
            
            }







        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            editApplicationToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
            showPersonsDrivingLicenseToolStripMenuItem.Enabled = false;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            sechduleTestsToolStripMenuItem.Enabled = false;
            visionTesttToolStripMenuItem.Enabled = false;
            theoryTestToolStripMenuItem.Enabled = false;
            praticalTestToolStripMenuItem.Enabled = false;
        }

      

        private void visionTesttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null)
            {

                TestScreen form = new TestScreen(int.Parse(dgvLDLapp.CurrentRow.Cells["LDLApp"].Value.ToString()),clsTestTypes.enTestTypes.VisionTest);
                 form.ShowDialog();
                _LoadData();
        }
        }

        private void theoryTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null)
            {

                TestScreen form = new TestScreen(int.Parse(dgvLDLapp.CurrentRow.Cells["LDLApp"].Value.ToString()), clsTestTypes.enTestTypes.WrittenTest);
                form.ShowDialog();
                _LoadData();

            }
        }

        private void praticalTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null)
            {

                TestScreen form = new TestScreen(int.Parse(dgvLDLapp.CurrentRow.Cells["LDLApp"].Value.ToString()), clsTestTypes.enTestTypes.PraticalTest);
                form.ShowDialog();
                _LoadData();

            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null) {

                IssueDrivingLicenseScreen form = new IssueDrivingLicenseScreen(int.Parse(dgvLDLapp.CurrentRow.Cells["LDLApp"].Value.ToString()));
               form.ShowDialog();
                _LoadData();

            }
           
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null)
            {
                clsPerson person = clsPerson.FindPerson(dgvLDLapp.CurrentRow.Cells["NationalNo"].Value.ToString());
                clsDrivingLicenseClass DrivingClassItem = clsDrivingLicenseClass.GetDrivingLicense(dgvLDLapp.CurrentRow.Cells["DrivingClass"].Value.ToString());
                ShowLicense form = new ShowLicense(clsDrivers.FindDriverByPerson(person),DrivingClassItem  );
                form.ShowDialog();
                _LoadData();
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null)
            {
                clsLocalDrivingLicense ldl = clsLocalDrivingLicense.ObjectWithexistedID(int.Parse(dgvLDLapp.CurrentRow.Cells["LDLApp"].Value.ToString()));
                clsDLApplication app = clsDLApplication.initialleLDLAppByLocalDrivingLicenseID(ldl, clsAppType.enAppTypes.NewLocalDrivingLicenseService);
                app.application.ApplicationStatus = clsApplication.enAppStatus.Canceled;
                if(app.application.Save()){
                    MessageBox.Show("The application has been canceled");
                }
                else
                {
                    MessageBox.Show("Something went error");

                }
                _LoadData();

            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null)
            {
                if (clsLocalDrivingLicense.DeleteLocalDrivingLicense(int.Parse(dgvLDLapp.CurrentRow.Cells["LDLApp"].Value.ToString())))
                {
                    MessageBox.Show("The local driving obj application was deleted successfully");
                }else
                {
                    MessageBox.Show("You have already appointed in a test or more ");
                }
                    _LoadData();
            }

        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null)
            {
                clsLocalDrivingLicense app = clsLocalDrivingLicense.ObjectWithexistedID(int.Parse(dgvLDLapp.CurrentRow.Cells["LDLApp"].Value.ToString()));
                if (app != null)
                {
                    ShowLocalDrivingLicenseApplicationInfo form = new ShowLocalDrivingLicenseApplicationInfo(clsDLApplication.initialleLDLAppByLocalDrivingLicenseID(app, clsAppType.enAppTypes.NewLocalDrivingLicenseService));
                    form.ShowDialog();
                    _LoadData();
                }
                
               
            }
        }

        private void showPersonsDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLDLapp.CurrentRow != null)
            {
                clsPerson person = clsPerson.FindPerson (dgvLDLapp.CurrentRow.Cells["NationalNo"].Value.ToString());
                if (person != null)
                {
                    ShowPersonsdrivinglicense_history form = new ShowPersonsdrivinglicense_history(person);
                    form.ShowDialog();
                    _LoadData();

                }

            }
        }
    }
}
