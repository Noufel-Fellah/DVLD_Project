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
    public partial class showUserInformation : UserControl
    {
        public void FillInformation(int userID)
        {
            clsUser user = clsUser.FindUser(userID);
            showDetails1.FillInformation(user._person);
            lbUserID.Text = user.userID.ToString();
            lbUsername.Text = user.username;
            rbIsActive.Checked = user._isActive;

        }
        public void FillInformation(clsUser user)
        {
            showDetails1.FillInformation(user._person);
            lbUserID.Text = user.userID.ToString();
            lbUsername.Text = user.username;
            rbIsActive.Checked = user._isActive;

        }

        public showUserInformation()
        {
            InitializeComponent();
        }

        
    }
}
