using DataAccessLayer;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.IO;
namespace bussinessLayer
{
    public class clsPerson
    {
        public enum enMode { ADD, UPDATE };
        public enMode mode { get; set; }
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }
        private string ImagePathCopy { get; set; }


        public static DataView AllPersons()
        {

            return clsPeopleTable.GetPeopleTable().DefaultView;


        }
        public static bool DoesNationalNumExist(string nationalNum,ref string message)
        {
            if (string.IsNullOrEmpty(nationalNum))
            {
                message = "This field is required";
                return false;
            }
            bool result= clsPeopleTable.DoesNationalNumExist(nationalNum);
            message = (result ? "This national number is already existed":"");
            return result;
        }
        private static clsPerson _EmptyPerson()
        {
            clsPerson person = new clsPerson();
            //person.PersonID = -1;
          person.FirstName = "";
          person.NationalNo = "";
          person.SecondName = "";
          person.ThirdName = "";
          person.LastName = "";
          person.DateOfBirth = DateTime.Now;
          person.Gender = "";
          person.Address = "";
          person.Phone = "";
          person.Email = "";
          person.Country = "";
          person.ImagePath = "";
            person.ImagePathCopy = "";
            person.mode = enMode.ADD;

            return  person;

        }
        private static clsPerson _FullPerson(int personID)
        {
            clsPerson person = new clsPerson();
            string FirstName = "";
            string NationalNo = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            string Gender = "";
            string Address = "";
            string Phone = "";
            string Email = "";
            string Country = "";
            string ImagePath = "";
            //string mode = enMode.UPDATE;



            if (clsPeopleTable.PersonWithThisIDExist(personID, ref NationalNo, ref  FirstName,ref  SecondName,ref ThirdName,ref LastName,ref Gender,ref Address,ref DateOfBirth,ref Phone,ref Email,ref Country,ref ImagePath ))
            {
                person.PersonID = personID;
                person.mode = enMode.UPDATE;
                person.FirstName = FirstName;
                person.LastName = LastName;
                person.Gender = Gender;
                person.Address = Address;
                person.Phone = Phone;
                person.Email = Email;
                person.DateOfBirth = DateOfBirth;
                person.NationalNo = NationalNo;
                person.SecondName = SecondName;
                person.ThirdName = ThirdName;
                person.ImagePath = ImagePath;
                person.ImagePathCopy = ImagePath;
                person.Country = Country;
                return person;
            }
            else { return null; }

                //set the update mode in here.
              
        }
        
        public static clsPerson FindPerson(int PersonID)
        {
            //Update mode is activated when the ID is PersonID of the selected person
            //add mode is activated when the ID is -1.
            //return null if the PersonID does not exist.
            if (PersonID == -1)
            {
                return _EmptyPerson();
            }
            else
            {
                return _FullPerson(PersonID);
            }
        }

        public static clsPerson FindPerson(string NationalNo)
        {
            clsPerson person = new clsPerson();
            int personID = 0;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            string Gender = "";
            string Address = "";
            string Phone = "";
            string Email = "";
            string Country = "";
            string ImagePath = "";
            //string mode = enMode.UPDATE;



            if (clsPeopleTable.PersonWithThisNationalNumExist(ref personID,  NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref Gender, ref Address, ref DateOfBirth, ref Phone, ref Email, ref Country, ref ImagePath))
            {
                person.PersonID = personID;
                person.mode = enMode.UPDATE;
                person.FirstName = FirstName;
                person.LastName = LastName;
                person.Gender = Gender;
                person.Address = Address;
                person.Phone = Phone;
                person.Email = Email;
                person.DateOfBirth = DateOfBirth;
                person.NationalNo = NationalNo;
                person.SecondName = SecondName;
                person.ThirdName = ThirdName;
                person.ImagePath = ImagePath;
                person.ImagePathCopy = ImagePath;
                person.Country = Country;
                return person;
            }
            else { return null; }
        }
        public static bool DeletePersonWith(   int PersonID)
        {
            return clsPeopleTable.DeletePerson(PersonID);
        }       



















        private string _pathOFFolders = @"C:\DVLD\main project\People images";
        private void _ChangeImagePathFormat()
        {
            if (this.ImagePath != this.ImagePathCopy ) {
                if (this.ImagePath != "")
                {
                    Guid guidPath = Guid.NewGuid();
                    string RealPath = _pathOFFolders + "\\"+guidPath.ToString() + ".jpg";//This path will be saved in data base
                    FileInfo OriginaleImagePath = new FileInfo(this.ImagePath);//Where exactly the image is
                    OriginaleImagePath.CopyTo(RealPath);

                    this.ImagePath = RealPath;
                }
                //Deleting the old image.
                if ( this.ImagePathCopy != "") {
                    FileInfo oldImage = new FileInfo(this.ImagePathCopy);//The place Where we are gonna save the copy of  image

                    oldImage.Delete();
                }
               this. ImagePathCopy = this. ImagePath;
}               


        }
        private clsPerson() { }

        private bool _SaveNewPerson()
        {

            this.PersonID = clsPeopleTable.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, Gender, Address, DateOfBirth, Phone, Email, Country, ImagePath);
              return this.PersonID  != -1;
        }
        private bool _SaveChanges()
        {
            return  clsPeopleTable.UpdatePerson(PersonID,NationalNo, FirstName, SecondName, ThirdName, LastName, Gender, Address, DateOfBirth, Phone, Email, Country, ImagePath);

        }
        public bool Save()
        {
            switch (this.mode)
            {
                case enMode.ADD:
                    this.mode = enMode.UPDATE;
                    this._ChangeImagePathFormat();
                    return this._SaveNewPerson();

                case enMode.UPDATE:
                    this._ChangeImagePathFormat();

                    return this._SaveChanges();
            }
            return false;
        }

       public bool HasDrivingLicense (int licenseClassesID)
        {
            return clsLicensesTable.PersonHasDrivingLicense(this.PersonID,licenseClassesID);
        }

    }
}
