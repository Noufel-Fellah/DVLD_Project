using bst;
using bussinessLayer;
using System;

using System.Data;

using System.Windows.Forms;

namespace DVLD
{
    public partial class ListOfInternationalDrivingLicenses : Form
    {
        //Filted list combo box's items
        //0-none
        //1-InternationalLicenseID
        //2-LocalLicenseID
        //3-ApplicationID
        //4-IsActive
        //5-CreatedByUserID
        DataView _InternationalLicensesTable;
       
        private void _LoadData()
        {
            _InternationalLicensesTable = clsInternationalLicense.InternationalLicensesTable();
            dgvInternationalLicensesTable.DataSource= _InternationalLicensesTable;
            lbRecords.Text=_InternationalLicensesTable.Count.ToString();
            cbFiltedList.SelectedIndex = 0;
        }
        public ListOfInternationalDrivingLicenses()
        {
            InitializeComponent();
            _LoadData();
        }


       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewInternationalLicense_Click(object sender, EventArgs e)
        {
            InternationalDrivingLicenseApplication form = new InternationalDrivingLicenseApplication();
            form.ShowDialog();
            _LoadData();

        }

        private void showPersonLicenseHistroryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicensesTable.CurrentRow != null)
            {
                ShowPersonsdrivinglicense_history form = new ShowPersonsdrivinglicense_history(clsDrivers.GetDriverByDriverID(int.Parse(dgvInternationalLicensesTable.CurrentRow.Cells["DriverID"].Value.ToString())).Person);
                form.ShowDialog();
            }
            
        }

        private void dgvInternationalLicensesTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInternationalLicensesTable .ClearSelection();
                dgvInternationalLicensesTable.Rows[e.RowIndex].Selected = true;
                dgvInternationalLicensesTable.CurrentCell = dgvInternationalLicensesTable.Rows[e.RowIndex].Cells[0];
            }
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicensesTable.CurrentRow != null)
            {
               ShowInter_license_Info  form =  new ShowInter_license_Info(clsInternationalLicense.GetInternationalLicenseByLicenseID(int.Parse(dgvInternationalLicensesTable.CurrentRow.Cells["InternationalLicenseID"].Value.ToString())));
                form.ShowDialog();
            }
        }

        private void showPersonsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicensesTable.CurrentRow != null)
            {

                ShowDetailsScreen form = new ShowDetailsScreen(clsDrivers.GetDriverByDriverID(int.Parse(dgvInternationalLicensesTable.CurrentRow.Cells["DriverID"].Value.ToString())).Person.PersonID);
                form.ShowDialog();

            }
        }

        private void cbFiltedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFiltedList.SelectedIndex == 0)
            {
                cbChoicesOFIsActiveColumn.Visible = false;
                tbSearchBar.Visible = false;
                _InternationalLicensesTable.RowFilter = "";
                
            }else if(cbFiltedList.SelectedIndex == 4)
            {
                cbChoicesOFIsActiveColumn.Visible = true;
                tbSearchBar.Visible = false;
               
            }
            else
            {
                cbChoicesOFIsActiveColumn.Visible = false;
                tbSearchBar.Visible = true;

            }
        }

        private void cbChoicesOFIsActiveColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoicesOFIsActiveColumn.SelectedIndex == 1)
            {
                _InternationalLicensesTable.RowFilter = "IsActive=True";
                lbRecords.Text=_InternationalLicensesTable.Count.ToString();
            }
            else if (cbChoicesOFIsActiveColumn.SelectedIndex == 2)
            {
                _InternationalLicensesTable.RowFilter = "IsActive=False";
                lbRecords.Text = _InternationalLicensesTable.Count.ToString();


            }
            else
            {
                _InternationalLicensesTable.RowFilter = "";
                lbRecords.Text = _InternationalLicensesTable.Count.ToString();


            }
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchBar.Text))
            {
                _InternationalLicensesTable.RowFilter = "";
                lbRecords.Text = _InternationalLicensesTable.Count.ToString();
            }
            if(int.TryParse(tbSearchBar.Text,out int result))
            {
                _InternationalLicensesTable.RowFilter = $"{cbFiltedList.SelectedItem}={result}";
                lbRecords.Text = _InternationalLicensesTable.Count.ToString();
            }
            else
            {
                tbSearchBar.Clear();
                _InternationalLicensesTable.RowFilter = "";
                lbRecords.Text = _InternationalLicensesTable.Count.ToString();
            }
        }
    }
}
