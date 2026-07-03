using DataAccessLayer;
using System;


namespace bussinessLayer
{
    public class clsApplication
    {
        public enum enmode{ADD=1,UPDATE=2};
        private enmode _mode;
        public enmode mode
        {
            get { return _mode; }
        }
        public enum enAppStatus { New = 1, Canceled = 2, Completed = 3 };
        private int _applicationsID;
        public int ApplicationsID
        {
            get { return _applicationsID; }
        }
        private int _applicantPersonID;
        public int ApplicantPersonID
        {
            get { return _applicantPersonID; }
        }
        private DateTime _applicationDate;
        public DateTime ApplicationDate
        {
            get { return _applicationDate; }
        }

        private int _applicationTypeID;//pls use the enum.
        public clsAppType.enAppTypes ApplicationTypeID
        {
            get { return (clsAppType.enAppTypes)_applicationTypeID; }
        }
        public enAppStatus _applicationStatus;
        public enAppStatus ApplicationStatus
        {
            get { return _applicationStatus; }
            set
            {
                _applicationStatus = value;
                _lastStatusDate= DateTime.Now;
            }
        }
        private DateTime _lastStatusDate;
        public DateTime LastStatusDate
        {
            get { return _lastStatusDate; }
        }
        public float paidFees          { set; get; }
        private int _createdByUserID;
        private enAppStatus _originalStatus;
        public int CreatedByUserID
        {
            get { return _createdByUserID; }
        }


      private   clsApplication() { }
        private clsApplication(int personID, int appTypeID, int status,int userID,DateTime appDate,DateTime LastApplicationStatus,enmode mode) {
            this._applicationsID = -1;
            this._applicantPersonID =personID;
            this._applicationDate=appDate;
            this._applicationTypeID = appTypeID;

            this.ApplicationStatus =(enAppStatus) status;
            this._mode = mode;
            this._lastStatusDate = LastApplicationStatus;
            this._createdByUserID = userID;
            this.paidFees = clsAppType.FindApp(appTypeID).appTypeFees;

        
        
        
        }
       private clsApplication( int applicationID,int ApplicantPersonID ,DateTime ApplicationDate ,int ApplicationTypeID ,int ApplicationStatus ,DateTime LastStatusDate ,float PaidFees ,int CreatedByUserID)
        {
            this._applicationsID = applicationID;
            this._applicantPersonID = ApplicantPersonID;
            this._applicationDate = ApplicationDate;
            this._applicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = (enAppStatus)ApplicationStatus;
            this._lastStatusDate=LastStatusDate;
            this.paidFees= PaidFees;
            this._createdByUserID= CreatedByUserID;
            this._mode= enmode.UPDATE;
            this._originalStatus = (enAppStatus)ApplicationStatus;

        }

        //methods
        static public clsApplication CreateApplication(clsPerson person, clsAppType.enAppTypes appType, clsApplication.enAppStatus status, clsDrivingLicenseClass.enDLC Dclass, clsUser user, DateTime appDate)
        {
            if (appType == clsAppType.enAppTypes.NewLocalDrivingLicenseService ||appType==clsAppType.enAppTypes.RetakeTest)
            {
                if (!clsApplicationTable.ApplicationExists(person.PersonID, (int)appType, (int)Dclass, (int)status, appDate))
                {

                    return new clsApplication(person.PersonID, (int)appType, (int)status, user.userID, appDate, appDate, enmode.ADD);



                }
                else return new clsApplication(person.PersonID, (int)appType, (int)status, user.userID, appDate, appDate, enmode.UPDATE);
            }else
            {
                return null;
            }

        }
        static public clsApplication CreateApplication(clsPerson person,clsAppType.enAppTypes appType,clsUser user)
        {
            return new clsApplication(person.PersonID, (int)appType, (int)clsApplication.enAppStatus.New, user.userID,DateTime.Now,DateTime.Now,enmode.ADD);
        }
      private bool _NewApplication()
        {
            // Returns:
            // -1  : Saving operation failed.
            // Other values : Saving operation succeeded.
          
            this._applicationsID  = clsApplicationTable.AddNewApplication(this._applicantPersonID,this._applicationDate, _applicationTypeID,(int) ApplicationStatus, _lastStatusDate, paidFees, _createdByUserID);
            return this._applicationsID != -1;
           
        }
       
      private bool _UpdateApplication()
        {
            //if you change both status and date status ,the saving opertion will be excuted in data base 
            //and return true,other wise will return false.
            if (this.ApplicationStatus != this._originalStatus)
            {
                return clsApplicationTable.UpdateApplication(this.ApplicationsID,(int) this.ApplicationStatus, this._lastStatusDate);
            }
            else return false;
        }
        public clsLocalDrivingLicense LocalDrivingLicense(clsDrivingLicenseClass.enDLC dClass)
        {

            clsLocalDrivingLicense obj = clsLocalDrivingLicense.CreateLocalDrivingLicense(this._applicationsID, (int)dClass);
            if (obj != null) { return obj; }
            else
            {
                return null;
            }



        }
        public static clsApplication GetApplicationWithLicenseClassType(int appID, clsAppType.enAppTypes type)
        {

            int ApplicantPersonID = 0;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = (int)type;
            int ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = 0;

            if (clsApplicationTable.GetApplicationWithID(appID, ref ApplicantPersonID, ref ApplicationDate,ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {

                return new clsApplication(appID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);


            }
            else return null;

        }

        public static clsApplication GetApplicationWithID(int appID)
        {
            int ApplicantPersonID = 0;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = 0;
            int  ApplicationStatus=0 ;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = 0;

            if (clsApplicationTable.GetApplicationWithID(appID, ref ApplicantPersonID, ref ApplicationDate,ref  ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {

                return new clsApplication(appID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);


            }
            else return null;
        }

       static public bool DeleteApplication(int applicationID)
        {
            return clsApplicationTable.DeleteApplicationRow(applicationID);
        }
        public bool Save()
        {
            switch (this.mode)
            {

                case enmode.ADD:
                    this._mode= enmode.UPDATE;
                   return  this._NewApplication();
                case enmode.UPDATE:
                    return this._UpdateApplication();
            }
            return false;
            

            
                



        }
        
     


    }

    
}
