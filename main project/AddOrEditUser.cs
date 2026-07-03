using System;
using bussinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddOrEditUser : Form
    {
      // private clsPerson _person;
        private clsUser _user;

        private void  _FillUserPart()
        {
            lbUserID.Text = _user.userID.ToString();
            tbUserName.Text = _user.username.ToString();
            mtbPassword.Text = _user.password.ToString();
             cbIsActive.Checked = _user._isActive;
            

        }
        private void _AddUser()
        {
            gbSearchGroup.Enabled = true;
            lbTitle.Text = "Add new user";
            _user=clsUser.FindUser(-1);
            showDetails1.FillInformation(_user._person);//Fill the person's information part.


        }
        private void _UpdateUser(int userID)
        {
            gbSearchGroup.Enabled= false;//in the update mode ,you can't change the person completely
            lbTitle.Text = "Update the user";
            _user=clsUser.FindUser(userID);
            showDetails1.FillInformation(_user._person);//Fill the person's information part.
            _FillUserPart();
            _personPartDone=true;

        }
        private void _LoadData(int ID)
        {
            //ID equals -1 is  the adding mode
            // otherwise, ID(usually greater than 0) is  the updating mode
            cbSearchBarChoices.SelectedIndex = 0;
            if (ID == -1)
            {
                _AddUser();
            }
            else if (ID > 0)
            {
                _UpdateUser(ID);
            }

        }
        public AddOrEditUser(int ID)
        {
            InitializeComponent();
            _LoadData(ID);
        }
        private bool _personPartDone=false;
        private bool _userPartDone = false;
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }


        private void btnSearchAboutPerson_Click(object sender, EventArgs e)
        {
            //Fill the person's information in show details if the person exists in data base.
            if (cbSearchBarChoices.SelectedIndex == 0 && int.TryParse(tbSearchBar.Text, out int ID))
            {//search about person by person ID. 
                if((_user._person= clsPerson.FindPerson(ID))!=null){
                    if (showDetails1.FillInformation(_user._person)) _personPartDone = true ;
                    
                }
                else
                {
                    MessageBox.Show($"The person is not found with this ID: {tbSearchBar.Text}","Informe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    showDetails1.Clear();
                }
            }
            else//search about person by national number.
            {
                if ((_user._person = clsPerson.FindPerson(tbSearchBar.Text)) != null)
                {
                    if (showDetails1.FillInformation(_user._person)) _personPartDone = true;

                }
                else
                {
                    MessageBox.Show($"The person is not found with this National num: ID: {tbSearchBar.Text}", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDetails1.Clear();
                }

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PersonInfoManipulationForm form = new PersonInfoManipulationForm(-1);
            form.BackData += setNewPerson;//subscribe in the PersonInfoManipulationForm's event. 
            form.ShowDialog();



        }
        
        public void setNewPerson(clsPerson person)
        {
            if (showDetails1.FillInformation(person))
            {
                _user._person = person;
                _personPartDone = true;

            }
        }
       
        private bool _everyThingsWasCompleted = false;
        private void btnColse_Click(object sender, EventArgs e)
        {
            if (!_everyThingsWasCompleted)
            {
                if (MessageBox.Show("Are you sure you want to cancel the operation", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else { this.Close(); }
            }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_user.mode==clsUser.enMode.ADD){ 
            if (_personPartDone)
            {
                if (!clsUser.IsPersonUser(_user._person.PersonID))
                {
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                {
                    MessageBox.Show("This person is already a user choose another", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    showDetails1.Clear();
                }
            }
            else
            {
                MessageBox.Show("fill the person form first");
            }
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
            }
       
        
        }

        private void _EmptyPerson()
        {
            showDetails1.Clear();   
        }
      
        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            
            if (_user._person != null ) {

                _EmptyPerson();
                _personPartDone = false;
                tbSearchBar.Clear();

            }
            else
            {

                MessageBox.Show("there is no person's information");



            }
        }

        
        
        
        
        
        private void tbUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text))
            {
                e.Cancel = true;
                
                tbUserName.Focus();
                errorProvider1.SetError(tbUserName, "Username is required");


            }else if (clsUser.usernameExists(tbUserName.Text))
            {
                e.Cancel = true;

                tbUserName.Focus();
                errorProvider1.SetError(tbUserName, "This username  already exists");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUserName, "");
            }
        }

        private void mtbPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(mtbPassword.Text))
            {
                e.Cancel = true;

                mtbPassword.Focus();
                errorProvider1.SetError(mtbPassword, "Username is required");
                mtbConfirmedPassword.Enabled = false;


            }
            else
            {
                mtbConfirmedPassword.Enabled = true ;
                e.Cancel = false;
                errorProvider1.SetError(mtbPassword, "");
            }



        }

        private void mtbConfirmedPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(mtbPassword.Text))
            {
                e.Cancel = true;

                mtbPassword.Focus();
                errorProvider1.SetError(mtbPassword, "Username is required");


            }
            else
            {
                if (mtbConfirmedPassword.Text != mtbPassword.Text)
                {
                    e.Cancel = true;
                    mtbPassword.Focus();
                    errorProvider1.SetError(mtbPassword, "The password is wrong,enter the correct one");
                    mtbConfirmedPassword.Text = "";
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(mtbPassword, "");
                }
            }


        }
    
        
        private void _IsEveryFieldFilled()
        {
            if(tbUserName.Text!="" &&((_user.mode==clsUser.enMode.UPDATE && mtbPassword.Text==_user.password)|| mtbConfirmedPassword.Text==mtbPassword.Text && mtbPassword.Text != ""))
            {
                _userPartDone = true;
                _user.username=tbUserName.Text;
                _user.password=mtbPassword.Text;
                _user._isActive = cbIsActive.Checked;
                //_person._person = _person;
            }
       
        
        }

        private void btnpervious_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        private void _FillUser()
        {
            _user.username = tbUserName.Text;
            _user.password = mtbPassword.Text;
            _user._isActive = cbIsActive.Checked;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _IsEveryFieldFilled();//Check if the user part is completed.
            string MODE = (_user.mode == clsUser.enMode.ADD ? "added": "updated");
            if (!_userPartDone)
            {
                MessageBox.Show("the user part has not been completed yet. ", "Information");
            }else if (!_personPartDone)
            {
                MessageBox.Show("the person part has not been completed yet. ", "Information");
            }else
            {
                _FillUser();
                if (_user.Save()) {
                    MessageBox.Show($"user was {MODE} successfully");
                    _everyThingsWasCompleted=true;
                    lbTitle.Text = "Update the user";
                    lbUserID.Text = _user.userID.ToString();
                    gbSearchGroup.Visible = false;

                }
                else {
                    MessageBox.Show("user was not added successfully");
                }
                
                
            }
                    

        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {
            //cbSearchChoices combo box controlle's items
            // PersonID
            // NationalNo
            if (cbSearchBarChoices.SelectedIndex == 0)
            {
                if (!int.TryParse(tbSearchBar.Text, out int result))
                {
                    tbSearchBar.Text = "";
                }

            }
        }
   
    
    
    
    }
}
