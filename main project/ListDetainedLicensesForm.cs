using bst;
using System;
using System.Windows.Forms;
using System.Data;
namespace DVLD
{
    public partial class ListDetainedLicensesForm : Form
    {
        clsLicenses license;
        DataView DetainedLicensesTable;
      private void   _LoadDate()
        {
           
                DetainedLicensesTable = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicensesTable.DataSource= DetainedLicensesTable;
            cbFilteredList.SelectedIndex = 0;
            lbRecords.Text=DetainedLicensesTable.Count.ToString(); 

        }

        public ListDetainedLicensesForm()
        {
            InitializeComponent();
            _LoadDate();
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ReleasingDetainedLicense form = new ReleasingDetainedLicense();
            form.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            DetainingLicenseForm form =new DetainingLicenseForm();
            form.ShowDialog();
        }

        private void dgvDetainedLicensesTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
         
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvDetainedLicensesTable.ClearSelection();
                dgvDetainedLicensesTable.Rows[e.RowIndex].Selected = true;
                dgvDetainedLicensesTable.CurrentCell = dgvDetainedLicensesTable.Rows[e.RowIndex].Cells[0];
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
          if(dgvDetainedLicensesTable.CurrentRow != null)
            {
                releaseDetaineLicenseToolStripMenuItem.Enabled =(!bool.Parse( dgvDetainedLicensesTable.CurrentRow.Cells["IsReleased"].Value.ToString()));


            }
        }

        private void showPersonsLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicensesTable.CurrentRow != null)
            {
                  license=clsLicenses.GetLicenseByLicenseID( int.Parse(dgvDetainedLicensesTable.CurrentRow.Cells["LicenseID"].Value.ToString()));
                PersonInfoManipulationForm form = new PersonInfoManipulationForm(license.Driver.Person.PersonID);
                form.ShowDialog();

            }
        }

        private void showPersonsLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicensesTable.CurrentRow != null)
            {
                 license = clsLicenses.GetLicenseByLicenseID(int.Parse(dgvDetainedLicensesTable.CurrentRow.Cells["LicenseID"].Value.ToString()));
                ShowLicense form = new ShowLicense(license);
                form.ShowDialog();

            }
        }

        private void showPersonsLicenseHostoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicensesTable.CurrentRow != null)
            {
                 license = clsLicenses.GetLicenseByLicenseID(int.Parse(dgvDetainedLicensesTable.CurrentRow.Cells["LicenseID"].Value.ToString()));
                ShowPersonsdrivinglicense_history  form = new ShowPersonsdrivinglicense_history(license.Driver.Person);
                form.ShowDialog();

            }
        }

        private void releaseDetaineLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicensesTable.CurrentRow != null)
            {
                license = clsLicenses.GetLicenseByLicenseID(int.Parse(dgvDetainedLicensesTable.CurrentRow.Cells["LicenseID"].Value.ToString()));
                ReleasingDetainedLicense form = new ReleasingDetainedLicense();
                form.ShowDialog();

            }
        }
    }
}
