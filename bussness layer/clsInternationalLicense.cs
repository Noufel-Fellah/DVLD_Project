using bussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace bst
{
    public class clsInternationalLicense
    {
       public enum enMode{ADD=1,UPDATE=2};
        private enMode _mode;
        public enMode Mode
        {
            get { return _mode; }
        }
      private  int _internationalLicenseID;
        public int InternationalLicenseID
        {
            get { return _internationalLicenseID; }
        }
     private  clsApplication _application;
        public clsApplication Application
        {
            get { return _application; }
          
        }
      clsDrivers _driver;
        public clsDrivers Driver
        {
            get { return _driver; }
        }
      clsLicenses _issuedUsingLocalLicense;
        public clsLicenses IssuedUsingLocalLicense
        {
            get { return _issuedUsingLocalLicense; }
        }
        private DateTime _issueDate;
        public DateTime IssueDate
        {
            get {return _issueDate; }
            set
            {
                if (this._mode == enMode.ADD) {
                    _issueDate = value;


                } }

        }
      DateTime _expirationDate;
        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set
            {
                if (this._mode == enMode.ADD)
                {
                    _expirationDate = value;


                }
            }
        }
     public bool IsActive { get; set; }
        bool _previousActiveStatus;
        clsUser  _createdByUser ;
        public clsUser CreatedByUser
        {
            get { return _createdByUser; }
        }
        //Constuctors
        clsInternationalLicense() { }
        clsInternationalLicense(int internationalLicenseID,clsLicenses license, clsApplication application,DateTime issueDate,DateTime expirationDate,bool IsActive, clsUser CreatedByUser, enMode mode)
        {
            this._internationalLicenseID = internationalLicenseID;
            this._mode=mode;
            this._createdByUser = CreatedByUser;
            this.IsActive=IsActive;
            this._issueDate = issueDate;
            this._expirationDate = expirationDate;
            this._driver=license.Driver;
            this._issuedUsingLocalLicense = license;
            this._application = application;
            _previousActiveStatus = IsActive;
        }
        //Methods
        static public DataView GetAllInternationalLicensesOfPerson(clsPerson person)
        {
            clsDrivers driver = clsDrivers.FindDriverByPerson(person);
            if (driver == null) return null;
            else
            {
                return clsInternationalLicensesTable .GetAllLicensesOfDriverByTheirID(driver.DriverID).DefaultView;

            }



        }
    
       
        static public clsInternationalLicense CreateInternationalLicense(clsLicenses license,clsUser user=null)
        {
            if(license == null ||!license.IsActive ||license.LicenseClass!=clsDrivingLicenseClass.enDLC.OrdinaryDrivingLicense ) return null;
          int  InternationalLicenseID=-1;
          int   ApplicationID=-1;
          DateTime IssueDate= DateTime.Now;
          DateTime ExpirationDate=DateTime.Now;
          bool IsActive=false;
          int CreatedByUserID = -1;
            if (clsInternationalLicensesTable.LicenseExists(ref InternationalLicenseID,ref ApplicationID, license.licenseID, ref IssueDate,ref ExpirationDate, ref IsActive,ref CreatedByUserID))
            {
                //Activing the update mode
                return  new clsInternationalLicense(InternationalLicenseID,license,clsApplication.GetApplicationWithID( ApplicationID),IssueDate,ExpirationDate,IsActive,clsUser.FindUser(CreatedByUserID),enMode.UPDATE);

            }
            else
            {
                if (user != null) {
                    return new clsInternationalLicense(-1, license, clsApplication.CreateApplication(license.Driver.Person, clsAppType.enAppTypes.NewInternationalLicense, user), DateTime.Now, DateTime.Now.AddYears(1), true, user, enMode.ADD);
                        } else return null;
            }


        }     
      static public clsInternationalLicense GetInternationalLicenseByLicenseID(int ID)
        {
            if(ID<=0)return null;
            int ApplicationID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;
            int   licenseID = 0;
            if (clsInternationalLicensesTable.GetInternationalLicenseByID(ID, ref ApplicationID, ref licenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                //Activing the update mode
                return new clsInternationalLicense(ID, clsLicenses.GetLicenseByLicenseID(licenseID), clsApplication.GetApplicationWithID(ApplicationID), IssueDate, ExpirationDate, IsActive, clsUser.FindUser(CreatedByUserID), enMode.UPDATE);

            }
            else return null;
        }
        static public DataView InternationalLicensesTable()
        {
            return clsInternationalLicensesTable.GetAllInternationalLiceneses().DefaultView;
        }
        public bool _AddNewObject()
        {
            if (this._application.Save())//save the new international application in DB
            {
                this._internationalLicenseID = clsInternationalLicensesTable.AddNewInternationalLicense(_issuedUsingLocalLicense.licenseID,_driver.DriverID ,_application.ApplicationsID, IssueDate, ExpirationDate, IsActive, _createdByUser.userID);
                if( _internationalLicenseID != -1)//here to make sure the information was saved successfully.
                {
                    //here to set the International license application as completed.
                    this._application.ApplicationStatus = clsApplication.enAppStatus.Completed;
                    if (this._application.Save()) return true;
                    else return false;
                }else return false;
            }
            else
            {
                return false;
            }
        }
       public bool _UpdateObject()
        {
            if (this.IsActive != _previousActiveStatus)
            {
                return true;

            }
            return false;
        }
        public bool Save()
        {
            switch (this._mode)
            {
                case enMode.ADD:
                    return _AddNewObject();
                case enMode.UPDATE:
                    return _UpdateObject();
            }
            return false;
        }
    
    
    
    }
}
