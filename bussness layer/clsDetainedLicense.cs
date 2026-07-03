using bussinessLayer;
using DataAccessLayer;
using System;
using System.ComponentModel;
using System.Data;


namespace bst
{
    public class clsDetainedLicense
    {
        enum enMode { ADD = 0, UPDATE = 1 }
        enMode _mode;
        private int _detainID;
        public int DetainID
        {
            get { return _detainID; }
        }
       
        private clsLicenses _license;
        public clsLicenses License
        {
            get { return _license; }
        }
        
        private DateTime _detainDate;
        public DateTime DetainDate
        {
            get { return _detainDate; }
        }
        
        private float _fineFees;
        public float FineFees
        {
            get { return _fineFees; }
        }
        
        private clsUser _createdByUser;
        public clsUser CreatedByUser
        {
            get { return _createdByUser; }
        }

        private bool _isReleased;
        public bool IsReleased
        {
            get { return _isReleased; }
            set
            {
                if (!_isReleased) _isReleased = value;
            }
        }
        

        private DateTime _releaseDate;
        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set {
            
                    if (_isReleased) _releaseDate = value;
                
            }
        }
        private clsUser _releasedByUser;
        public clsUser ReleasedByUser
        {
            get { return _releasedByUser; }
            set
            {

                if (_isReleased) _releasedByUser = value;

            }
        }
        
        private clsApplication _releaseApplication;
        public clsApplication ReleaseApplication
        {
            get { return _releaseApplication; }
            set
            {

                if (_isReleased) _releaseApplication = value;

            }
        }
        //Constructor:
       private  clsDetainedLicense() { }
       public  clsDetainedLicense(clsLicenses license,DateTime detainedDate,float fineFees ,clsUser user)
        {
            _mode = enMode.ADD;
            _detainID = -1;
            _license = license;
            _createdByUser = user;
            _detainDate = detainedDate;
            _fineFees = fineFees;
            _releasedByUser = null;
            _releaseApplication = null;
            _isReleased = false;
            _releaseDate=DateTime.MinValue;



        }
        private clsDetainedLicense(int detainLicenseID,clsLicenses license, DateTime detainedDate, float fineFees, clsUser Createduser,bool IsReleased,DateTime releaseDate,clsApplication application,clsUser ReleasedUser)
        {
            this._detainID= detainLicenseID;
            this._license = license;
            this._createdByUser = Createduser;
            this._detainDate = detainedDate;
            this._isReleased= IsReleased;
            this._releaseDate = releaseDate;
            this._releasedByUser = ReleasedUser;
            this._fineFees = fineFees;
            this._releaseApplication = application;
            this._mode = enMode.UPDATE;
        }
        //Methods
        static public bool IsLicenseDetained(clsLicenses license)
        {
            return clsDetainedLicenseTable.IsLicenseDetained(license.licenseID);
        }
       public  static clsDetainedLicense GetDetainedLicense(clsLicenses license)
        {
          int   DetainID=0;

            DateTime DetainDate = DateTime.Now          ;
          float   FineFees =0           ;
          int   CreatedByUserID =0    ;
          bool   IsReleased  =false        ;
          DateTime   ReleaseDate=DateTime.Now         ;
          int   ReleasedByUserID =0   ;
          int   ReleaseApplicationID=0;
            if (clsDetainedLicenseTable.GetDetainedLicenseByLicenseID(ref   DetainID, license.licenseID, ref   DetainDate, ref   FineFees, ref  CreatedByUserID, ref  IsReleased, ref  ReleaseDate, ref  ReleasedByUserID, ref  ReleaseApplicationID))
            {
                return new clsDetainedLicense(DetainID,license, DetainDate, FineFees,clsUser.FindUser(CreatedByUserID),IsReleased, ReleaseDate,clsApplication.GetApplicationWithID(ReleaseApplicationID)  ,clsUser.FindUser(ReleasedByUserID));
            }
            else
            {
                return null;
            }
        }
        private  bool  _ADDNewDetainedLicense()
        {


            this._detainID = clsDetainedLicenseTable.ADDNewDetainedLicense(_license.licenseID,_detainDate,_fineFees,_createdByUser.userID);

            return this._detainID != -1;



        }
        private bool _UPDATEDetainedLicense()
        {
            return clsDetainedLicenseTable.UpdateDetainedLicenseRow(this._detainID, this.ReleaseDate,this.ReleasedByUser.userID, this.ReleaseApplication.ApplicationsID);
        }
       static public DataView GetAllDetainedLicenses()
        {
            return clsDetainedLicenseTable.GetAllDetainedLicenses().DefaultView;
        }
        public bool Save()
        {
            switch (this._mode)
            {
                case enMode.ADD:
                    return this._ADDNewDetainedLicense();
                    case enMode.UPDATE:
                    return _UPDATEDetainedLicense();

            }
            return false;
        }


    }
}
