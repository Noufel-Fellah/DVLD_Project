using bussinessLayer;
using System;

using System.ComponentModel;

using System.Windows.Forms;

namespace DVLD
{
    public partial class ChangePasswordScreen : Form
    {
        private bool _isSaved = true;
        private clsUser _user;
        private void _LoadData(int userID)
        {
            _user = clsUser.FindUser(userID);
            showUserInformation1.FillInformation(_user);

        }

        private void _LoadData(clsUser user)
        {
            _user = user;
            showUserInformation1.FillInformation(_user);

        }

        public ChangePasswordScreen(int userID)
        {
            InitializeComponent();
            _LoadData(userID);
        }
        public ChangePasswordScreen(clsUser user)
        {
            InitializeComponent();
            _LoadData(user);
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool _passIsCorrect = false;
        private void mtbOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbOldPassword.Text))
            {
                if (mtbOldPassword.Text != _user.password)
                {
                    e.Cancel = true;
                    mtbOldPassword.Focus();
                    errorProvider1.SetError(mtbOldPassword, "The password is wrong:-(");

                }
                else
                {
                    e.Cancel = false;
                    _passIsCorrect = true;
                    errorProvider1.SetError(mtbOldPassword, "");
                }
            }
        }

        private void mtbOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbOldPassword.Text))
            {
                _isSaved = false;
            }
            else { _isSaved = true; }
                    
        }

        private void mtbNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbOldPassword.Text)) { 
                if (!string.IsNullOrWhiteSpace(mtbNewPassword.Text))
                {
                    _isSaved = false;
                    mtbConfirmedNewPassword.Visible = true;

                }
                else {
                    mtbConfirmedNewPassword.Visible = false;
                    _isSaved = true; }
            }
            else
            {
                errorProvider1.SetError(mtbNewPassword, "You have to enter your old password first");
                mtbNewPassword.Clear();
            }
                
        
        }

        private void mtbConfirmedNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbOldPassword.Text))
            {
                _isSaved = false;
            }
            else { 
                
                _isSaved = true; }
        }

        private void btnCLose_Click_1(object sender, EventArgs e)
        {
            if (!_isSaved)
            {
                if (MessageBox.Show("Are you you want to cancel the operation", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this._passIsCorrect && mtbConfirmedNewPassword.Text == mtbNewPassword.Text && !string.IsNullOrEmpty(mtbNewPassword.Text)){
               _user.password = mtbNewPassword.Text;
                if (_user.Save()) { MessageBox.Show("Your password has been updated ");
                    _isSaved = true;
                    if (_user.username==GlobalSettings.currentUser.username) {
                        GlobalSettings.saveUserNameAndPassword(_user.username, _user.password); }
                }
                else { MessageBox.Show("Something went wrong"); }
            }
            else if(mtbConfirmedNewPassword.Text != mtbNewPassword.Text &&!string.IsNullOrWhiteSpace(mtbNewPassword.Text)&&!string.IsNullOrWhiteSpace(mtbConfirmedNewPassword.Text))
            {
                MessageBox.Show("You have entered a wrong password in the confirmed new password field", "Error") ;
            }
            else if (string.IsNullOrWhiteSpace(mtbOldPassword.Text))
            {
                MessageBox.Show("You should  enter your old password", "Error");

            }
            else if (!string.IsNullOrWhiteSpace(mtbOldPassword.Text)&&(string.IsNullOrWhiteSpace(mtbNewPassword.Text))) {
                MessageBox.Show("enter the new password or delete the operation by deleting your old password  from the old password field");
            
            }
            


        }
    }
}
