using bussinessLayer;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace DVLD
{
    public partial class LoginScreenForm : Form
    {
        public LoginScreenForm()
        {
            InitializeComponent();
            failedTrails = 0;
        }
        private int failedTrails;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginIn_Click(object sender, EventArgs e)
        {
            if (failedTrails>2)
            {
                GlobalSettings.CreateEventLog("The user failed to enter to the system", null, EventLogEntryType.Warning);
                tbPassword.Enabled = false;
                tbUsername.Enabled = false;
                btnLoginIn.Enabled = false;
                MessageBox.Show( "Somethig wrong happend,Try in another time,The page is  being closed in 10 seconds " );
                Thread.Sleep(10000);
                this.Close();
                
            }
           else if (tbUsername.Text == "")
            {
                MessageBox.Show("The username field is empty,pls fill it.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (tbPassword.Text == "")
            {
                MessageBox.Show("The password field is empty,pls fill it.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if ((GlobalSettings.currentUser = clsUser.FindUser(GlobalSettings.ComputeHash(tbUsername.Text), GlobalSettings.ComputeHash( tbPassword.Text))) != null)
                {
                    if (GlobalSettings.currentUser._isActive)
                    {
                       
                        GlobalSettings.UserEntredBefore = true;
                        GlobalSettings.saveUserNameAndPassword(tbUsername.Text, tbPassword.Text);
                        MainMenue form = new MainMenue();
                        form.ShowDialog();
                        tbUsername.Clear();
                        tbPassword.Clear();
                        cbRememberMe.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("This user is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        failedTrails++;

                    }

                }
                else
                {
                    MessageBox.Show("The user with this username and password doen not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    failedTrails++;
                }
            }
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRememberMe.Checked && GlobalSettings.UserEntredBefore) {
                string[] info= GlobalSettings.RememberMe();
               tbUsername.Text= info[0];
               tbPassword.Text= info[1];

            }
            else
            {
                tbUsername.Clear();
                tbPassword.Clear();
            }
        }
    }
}
