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
    public partial class ShowDetailsInUserManagement : Form
    {
        public ShowDetailsInUserManagement(int userID)
        {
            InitializeComponent();
            showUserInformation1.FillInformation(userID);
        }

        public ShowDetailsInUserManagement(clsUser user)
        {
            InitializeComponent();
            showUserInformation1.FillInformation(user);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
