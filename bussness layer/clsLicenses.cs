using bussinessLayer;
using DataAccessLayer;
using System;
using System.Data;

namespace bst
{
    public class clsLicenses
    {
        public enum enIssueReason {FirstTime=1,Renew=2, ReplacementForDamaged = 3, ReplacementForLost= 4 };
        private enum enmode{ADD=1,UPDATE=2};
       private enmode _mode;
        private int _licenseID;
        public int licenseID
        {
            get { return _licenseID; }
        }
       private clsApplication _application;
        public clsApplication Application
        {
            get { return _application; }
        }
        private int _DefaultValidityLength;
        private clsDrivers _driver;
        public clsDrivers Driver
        {
            get { return _driver; }
        }
       
        private clsDrivingLicenseClass.enDLC _licenseClass;
        public clsDrivingLicenseClass.enDLC LicenseClass
        {
            get { return _licenseClass; }
        }
       private DateTime _issueDate;
        public DateTime IssueDate
        {
            get { return _issueDate; }
            set
            {
                _issueDate = value;
                _expirationDate = _issueDate.AddYears(_DefaultValidityLength);
            }
        }
        private DateTime _expirationDate;
        
        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
        }
        public string Notes { get; set; }
        private float _paidFees;//fees of the license class.
        public float PaidFees
        {
            get { return _paidFees; }
            set { _paidFees = value; }
        }
       public bool IsActive { get; set; }
       private enIssueReason _IssueReason;
        public enIssueReason IssueReason
        {
            get { return _IssueReason ; }
        }
        private clsUser _createdByUser;
        public clsUser createdByUser
        {
            get { return _createdByUser; }
        }
        //Constructors
        clsLicenses() { }
        //Create in here two contrator 
        //The first has person ,user,enum of the license class and Date of today .of course here
        //the situation of creating a license for the first time.
        //the second one has driver ,user ,enum of the license class ,application ,IssueReason..
        //for the rest of applications
    private clsLicenses(int licenseID,clsDrivers driver,clsUser user,  clsApplication application,clsDrivingLicenseClass.enDLC licenseClass,byte IssueReason,bool isActive ,enmode _mode)
        {
            this._licenseID = licenseID;
            this._mode = _mode;
            this._application = application;
            this._driver = driver;
            this._licenseClass = licenseClass;
            this._issueDate = DateTime.Now;
            clsDrivingLicenseClass DClass = new clsDrivingLicenseClass(licenseClass);
            this._DefaultValidityLength = DClass.DefaultValidityLength;
            this._expirationDate=IssueDate.AddYears(_DefaultValidityLength);
            this.Notes="";
            this._paidFees = DClass.ClassFees;
            this.IsActive = isActive;
            this._IssueReason = (enIssueReason)IssueReason;
            this._createdByUser=user;
        }
      
        private clsLicenses( clsDrivers driver, clsUser user, clsApplication application, clsDrivingLicenseClass.enDLC licenseClass, enIssueReason IssueReason, bool isActive, enmode _mode)
        {
            this._licenseID = -1;
            this._mode = _mode;
            this._application = application;
            this._driver = driver;
            this._licenseClass = licenseClass;
            this._issueDate = DateTime.Now;
            clsDrivingLicenseClass DClass = new clsDrivingLicenseClass(licenseClass);
            this._DefaultValidityLength = DClass.DefaultValidityLength;
            this._expirationDate = IssueDate.AddYears(_DefaultValidityLength);
            this.Notes = "";
            this._paidFees = DClass.ClassFees;
            this.IsActive = isActive;
            this._IssueReason = IssueReason;

            this._createdByUser = user;
        }
        private clsLicenses(int licenseID, clsDrivers driver, clsUser user, clsApplication application, clsDrivingLicenseClass.enDLC licenseClass, byte IssueReason, bool isActive, enmode _mode, DateTime issueDate, DateTime expirationDate,string Notes,float fees)
        {
            this._licenseID = licenseID;
            this._mode = _mode;
            this._application = application;
            this._driver = driver;
            this._licenseClass = licenseClass;
            this._issueDate = issueDate;
            //clsDrivingLicenseClass DClass = new clsDrivingLicenseClass(licenseClass);
            this._DefaultValidityLength = expirationDate.Year- issueDate.Year;
            this._expirationDate = expirationDate ;
            this.Notes = Notes;
            this._paidFees = fees;
            this.IsActive = isActive;
            this._IssueReason = (enIssueReason)IssueReason;
            this._createdByUser = user;
        }

        //methods
        static public clsLicenses CreateNewDrivingLicense(clsDrivers driver, clsUser user, clsApplication application, clsDrivingLicenseClass.enDLC licenseClass)
        {

            switch ((clsAppType.enAppTypes)application.ApplicationTypeID)
            {
                case clsAppType.enAppTypes.NewLocalDrivingLicenseService:
                    return new clsLicenses(driver,user,application,licenseClass, enIssueReason.FirstTime, true,enmode.ADD);
                case clsAppType.enAppTypes.RenewDrivingLicenseService:
                    return new clsLicenses(driver, user, application, licenseClass, enIssueReason.Renew, true, enmode.ADD);
                case clsAppType.enAppTypes.ReplacementForALostDrivingLicense:
                    return new clsLicenses(driver, user, application, licenseClass, enIssueReason.ReplacementForLost, true, enmode.ADD);
                case clsAppType.enAppTypes.ReplacementForADamagedDrivingLicense:
                    return new clsLicenses(driver, user, application, licenseClass, enIssueReason.ReplacementForDamaged, true, enmode.ADD);

                default: return null;
            }





        }
        static public clsLicenses GetLicenseOf(clsDrivers driver, clsDrivingLicenseClass.enDLC licenseClass)
        {
            int _licenseID = -1;
             
            int applicationID =0 ;
            clsDrivers Driver = driver;
            clsDrivingLicenseClass.enDLC licenseClassType = licenseClass;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string Notes = "";
            float paidFees = 0;
            bool IsActive =true ;
            int IssueReason = 0;
           int licenseClassTypeID = (int)licenseClassType;
            int createdByUserID = 0;
            if (clsLicensesTable.GetActiveLicense(ref _licenseID, ref applicationID, Driver.DriverID, ref licenseClassTypeID, ref issueDate, ref expirationDate, ref Notes, ref paidFees, ref IsActive, ref IssueReason, ref createdByUserID))
            {
                return new clsLicenses(_licenseID,Driver, clsUser.FindUser(createdByUserID), clsApplication.GetApplicationWithID(applicationID), licenseClass, (byte)IssueReason, IsActive, enmode.UPDATE , issueDate,  expirationDate,Notes,paidFees);


        }
            else return null;
        }
        static public clsLicenses GetLicenseByLicenseID(int licenseID)
        {
            //int _licenseID = -1;

            int applicationID = 0;
            int DriverID = 0;
            int licenseClassTypeID = 0;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string Notes = "";
            float paidFees = 0;
            bool IsActive = true;
            int IssueReason = 0;
            int createdByUserID = 0;
            if (clsLicensesTable.GetActiveLicenseByLicenseID( licenseID, ref applicationID,ref DriverID, ref licenseClassTypeID, ref issueDate, ref expirationDate, ref Notes, ref paidFees, ref IsActive, ref IssueReason, ref createdByUserID))
            {
                return new clsLicenses(licenseID,clsDrivers.GetDriverByDriverID(DriverID) , clsUser.FindUser(createdByUserID), clsApplication.GetApplicationWithID(applicationID),(clsDrivingLicenseClass.enDLC)licenseClassTypeID, (byte)IssueReason, IsActive, enmode.UPDATE, issueDate, expirationDate, Notes, paidFees);


            }
            else return null;
        }

        private bool _CreatingNewDrivingLicense()
        {
           
            this._licenseID =clsLicensesTable.AddNewRowInLicenseTable(Application.ApplicationsID,_driver.DriverID,(int) _licenseClass, _issueDate, _expirationDate, Notes, _paidFees,IsActive,(byte)IssueReason,_createdByUser.userID);
            return this._licenseID!=-1;
        }
        private bool _UpdateDrivingLicense()
        {
            return clsLicensesTable.deactivatedLicense(this.licenseID);
        }
        public bool isLicenseDentained()
        {
            return clsDetainedLicenses.IsLicenseDentained(this.licenseID);
        }
        public bool Save()
        {
            switch (this._mode)
            {
                case enmode.ADD:
                    return _CreatingNewDrivingLicense();
                case enmode.UPDATE:
                    return _UpdateDrivingLicense();
            }
            return false;
        
        }

        static public DataView GetAllLicensesOfPerson(clsPerson person)
        {
            clsDrivers driver = clsDrivers.FindDriverByPerson(person);
            if (driver == null) return null;
            else
            {
                return clsLicensesTable.GetAllLicensesOfDriverByTheirID(driver.DriverID).DefaultView ;

            }



        }






    }
}
