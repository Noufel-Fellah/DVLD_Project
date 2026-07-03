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

namespace DVLD
{
    public partial class ShowDetailsScreen : Form
    {
        private clsPerson _person;
        public ShowDetailsScreen(int personID)
        {
            InitializeComponent();
            showDetails1.FillInformation(personID);
        }
        public ShowDetailsScreen(clsPerson person)
        {
            //_person=person;
            InitializeComponent();
            showDetails1.FillInformation(person);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
