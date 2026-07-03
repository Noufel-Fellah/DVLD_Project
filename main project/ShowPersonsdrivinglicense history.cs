using bst;
using bussinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ShowPersonsdrivinglicense_history : Form
    {
        private void  _LoadDate(clsPerson person)
        {
            showDetails1.FillInformation(person);
                DataView table1=clsLicenses.GetAllLicensesOfPerson(person);
            dgvLocalDrivingLicenseTable.DataSource=table1;
            lbnumberOfRecordsOfIDLTable.Text = table1.Count.ToString();
            DataView table2 = clsInternationalLicense.GetAllInternationalLicensesOfPerson(person);
            dgvInternationalDrivingLicenses.DataSource=table2;
            NumberOfRecordsOfIDLTable.Text= table2.Count.ToString();
            
        }
        public ShowPersonsdrivinglicense_history(clsPerson person)
        {
            InitializeComponent();
            _LoadDate(person);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
