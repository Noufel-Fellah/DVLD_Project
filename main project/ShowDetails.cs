using bussinessLayer;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ShowDetails : UserControl
    {
        private int _personID;
        public ShowDetails()
        {
            InitializeComponent();
        }
        public bool FillInformation(clsPerson person=null)
        {
            if (person != null)
            {
                this._personID = person.PersonID;
                lbPersonID.Text = (_personID==-1?"": person.PersonID.ToString());
                lbNationalNum.Text = person.NationalNo;
                lbFirstName.Text = person.FirstName;
                lbSecondName.Text = person.SecondName;
                lbThirdName.Text = person.ThirdName;
                lbLastName.Text = person.LastName;
                lbEmail.Text = person.Email;
                lbdateOfBirth.Text = person.DateOfBirth.ToString();
                lbPhone.Text = person.Phone;
                lbGender.Text = person.Gender;
                lbGenderImage.ImageIndex = (person.Gender == "male" ? 1 : 0);
                lbAddress.Text = person.Address;
                lbCountry.Text = person.Country;
                if (person.ImagePath != "" && File.Exists(person.ImagePath))
                {
                    pbPersonImage.ImageLocation = person.ImagePath;
                }
                else
                {
                    pbPersonImage.Image = (person.Gender == "male" ? Resources.boy : Resources.girl);
                }
                llEdit.Visible = true;
                return true; 
            }
            else {
                llEdit.Visible = false;
                return false; }

        }
        public bool FillInformation(int PersonID)
        {
            _personID = PersonID;
            clsPerson person = clsPerson.FindPerson(_personID);
            if (person != null)
            {
                lbPersonID.Text = person.PersonID.ToString();
                lbNationalNum.Text = person.NationalNo;
                lbFirstName.Text = person.FirstName;
                lbSecondName.Text = person.SecondName;
                lbThirdName.Text = person.ThirdName;
                lbLastName.Text = person.LastName;
                lbEmail.Text = person.Email;
                lbdateOfBirth.Text = person.DateOfBirth.ToString();
                lbPhone.Text = person.Phone;
                lbGender.Text = person.Gender;
                lbGenderImage.ImageIndex = (person.Gender == "male" ? 1 : 0);
                lbAddress.Text = person.Address;
                lbCountry.Text = person.Country;
                if (person.ImagePath != "")
                {
                    pbPersonImage.ImageLocation = person.ImagePath;
                }
                else
                {
                    pbPersonImage.Image = (person.Gender == "male" ? Resources.boy : Resources.girl);
                }
                llEdit.Visible=true;
                return true;
            }
            else
            {
                llEdit.Visible = false;

                return false;
            }


        }

        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            PersonInfoManipulationForm form =new PersonInfoManipulationForm(_personID );
            form.ShowDialog();
            FillInformation(_personID);
        }
        public void Clear()
        {
            
            lbPersonID.Text = "";
            lbNationalNum.Text ="";
            lbFirstName.Text = "";
            lbSecondName.Text = "";
            lbThirdName.Text = "";
            lbLastName.Text ="";
            lbEmail.Text = "";
            lbdateOfBirth.Text = "";
            lbPhone.Text ="";
            lbGender.Text = "male";
            lbGenderImage.ImageIndex =  1 ;
            lbAddress.Text = "";
            lbCountry.Text = "";
           
                pbPersonImage.Image =  Resources.boy;
            llEdit.Visible=false;
            
        }
       
    }
}
