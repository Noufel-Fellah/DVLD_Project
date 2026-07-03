
using bussinessLayer;
using DVLD.Properties;
using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DVLD
{
    public partial class fillForm : UserControl
    {
     // private  int _personID;
        private clsPerson _person;
        //public void personID(int _personID)
        //{
        //    this._personID = _personID;
        //}

         
        private void _ActivatedDefaultSettings()
        {
            cmCountry.DataSource = clsCountry.getAllCountries();
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            cmCountry.SelectedItem = "Germany";





        }
        private void _LoadData(int ID)
        {
            //cmCountry.DataSource =clsCountry.getAllCountries() ;
            _person = clsPerson.FindPerson(ID);
            if (ID == -1) {
                //Adding mode.
                lbTitle.Text = "Add New Person";

                //_ActivatedDefaultSettings();
               
                

            }
            else
            {
                    //update mode.
                //_person=clsPerson.FindPerson(ID);
                _FillAllFieldWithPersonProperties();
               
            }


        }
       private void _FillAllFieldWithPersonProperties()
        {
            lbTitle.Text = "Update a Person";
            lbPersonIDValue.Text = _person.PersonID.ToString();
            tbNationalNum.Text=_person.NationalNo;
           // tbNationalNum.Enabled = false;//preventing the user to change the National num of a person
            tbNationalNum.Enabled = false;//preventing the user to change a person's national num.
            dtpDateOfBirth.Value = _person.DateOfBirth;
            tbPhone.Text = _person.Phone;
            tbAddress.Text = _person.Address;
            tbEmail.Text = _person.Email;
            tbFirstName.Text = _person.FirstName;
            tbLastName.Text = _person.LastName;
            tbSecondName.Text = _person.SecondName;
            tbThirdName.Text = _person.ThirdName;
            cmCountry.SelectedItem = _person.Country ;
            if (_person.Gender == "male")
            {
                rbMale.Checked = true;
                rbFemale.Checked = false;
                //Set the image in pbPersonImage controlle if image path in invalid
                if (_person.ImagePath == "")
                {
                    llRemove.Visible = false;
                    _ImageInserted = false;

                    pbPersonImage.Image = Resources.boy ;
                }
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = true;
                //Set the image in pbPersonImage controlle if image path in invalid
                if (_person.ImagePath == "")
                {
                    llRemove.Visible = false;
                    _ImageInserted = false;
                    pbPersonImage.Image = Resources.girl;//9-index of male image,10 is index of female image
                }
            }
            
            
            
            
            
            
            if (_person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _person.ImagePath;
                llRemove.Visible=true;
                _ImageInserted=true;
            }


            btnSave.Text = "Save changes";

        }
        public fillForm()
        {
            InitializeComponent();
            _ActivatedDefaultSettings();
           // _LoadData();
        }
        public void setMode(int ID)
        {
            //Update mode is activated when the ID is PersonID of the selected person
            //add mode is activated when the ID is -1.
            _LoadData(ID);
        }//The only public  property.
       public void SetPerson(clsPerson person)
        {
            this._person= person;
        }
       public clsPerson Person()
        {
            return _person;
        }
        private void HasUserleft(TextBox sender, CancelEventArgs e,string message)
        {
            //This function is only used in Validing event of  a text box
            if (string.IsNullOrWhiteSpace(sender.Text))
            {


                e.Cancel = true;
                sender.Focus();
                errorProvider1.SetError(sender, message);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(sender , "");
            }
        }
        
        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            
               HasUserleft((TextBox)sender, e,"The first name must be filled");

        }

        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            HasUserleft((TextBox)sender, e,"The second name must be filled");
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            HasUserleft((TextBox)sender, e,"The last name must be filled");
        }

        private void cmNationalNum_Validating(object sender, CancelEventArgs e)
        {
            string message = null;
            if (clsPerson.DoesNationalNumExist(tbNationalNum.Text,ref message))
            {
                e.Cancel = true;
                tbNationalNum.Focus();
                errorProvider1.SetError(tbNationalNum, message);

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNum, message);

            }

        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbPhone.Text, out int phone))
            {

                e.Cancel = true;
                tbPhone.Focus();
                errorProvider1.SetError(tbPhone, "phone does not contain letters or symbols");
            }

        }
        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            HasUserleft((TextBox)tbAddress, e, "Address is required");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            //int pos = 0;
            if (!tbEmail.Text.EndsWith("@gmail.com") &&!string.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = false;
                tbEmail.Focus();
                errorProvider1.SetError(tbEmail,tbEmail.Text+"does not end with\"@gmail.com \" extension");
                     tbEmail.Text = "";
            }
        }
        private bool _ImageInserted = false;
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OFD1.Filter = "PNG Files (*.png)|*.png";
            if (OFD1.ShowDialog() == DialogResult.OK)
            {
                llRemove.Visible = true;
                pbPersonImage.ImageLocation = OFD1.FileName;
                _ImageInserted = true;
            }

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
             
            if (rbMale.Checked)
            {
              if(!_ImageInserted)  pbPersonImage.Image = Resources.boy;//9-boy picture and 10 is the index of girl picture.

                rbFemale.Checked = false;

                

            }
            else
            {
                if (!_ImageInserted) pbPersonImage.Image = Resources.girl;//9-boy picture and 10 is the index of girl picture.

                rbFemale.Checked = true ;
            }
        
        }
       private bool _CheckAnyRequiredFeildIsEmpty()
        {
            if(string.IsNullOrWhiteSpace(tbNationalNum.Text))
            {
                MessageBox.Show("National number is empty","Caption",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                MessageBox.Show("First name is empty", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("LastName is empty", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbSecondName.Text))
            {
                MessageBox.Show("Second name  is empty", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Phone is empty", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("Address  is empty", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
       
        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Are you sure you wanna to delete the image", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                llRemove.Visible=false;
                pbPersonImage.Image = (rbMale.Checked ? Resources.boy : Resources.girl);
                _ImageInserted = false;
            }
        }
        //make the close event
        public event Action<object, EventArgs> close_Form;
        protected virtual void function_close_form(object sender, EventArgs e)
        {

            Action<object, EventArgs> handler = close_Form;
            if (handler != null) { 
            handler(sender, e );
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (close_Form != null)
            {
                //FillThePersonMail();
                function_close_form (sender, e );

            }

        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_CheckAnyRequiredFeildIsEmpty())//making sure that required info are filled.
            {
                //-Sent _person to the bussiness layer.
                //1-fill the object.
                _person.FirstName = tbFirstName.Text;
                _person.LastName = tbLastName.Text;
                _person.SecondName = tbSecondName.Text;
                _person.Phone = tbPhone.Text;
                _person.Address = tbAddress.Text;
                _person.ThirdName = tbThirdName.Text;
                _person.Gender = (rbMale.Checked ? "male" : "female");
                _person.NationalNo = tbNationalNum.Text;
                _person.DateOfBirth = dtpDateOfBirth.Value;
                _person.Country = cmCountry.SelectedItem.ToString();
                _person.Email = tbEmail.Text;
                if (_ImageInserted)
                {
                    _person.ImagePath = pbPersonImage.ImageLocation;
                }
                else
                {
                    _person.ImagePath = "";
                }
                //2-Save the object.
                clsPerson.enMode mode = _person.mode;
                if (_person.Save())
                {
                    if (mode == clsPerson.enMode.ADD)
                    {
                        MessageBox.Show("Person was added successfully", "notification");

                    }
                    else
                    {
                        MessageBox.Show("Person was updated successfully", "notification");
                    }

                }
                //3-initialle the person id.
                _FillAllFieldWithPersonProperties();
            }

        }


    }


}

