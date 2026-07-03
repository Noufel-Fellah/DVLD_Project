using DataAccessLayer;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;



namespace bussinessLayer
{

    public class clsLocalDrivingLicense 
    {
        private int _localDrivingLicenseApplicationsID;
        
        public int localDrivingLicenseApplicationsID
        {
            get { return _localDrivingLicenseApplicationsID; }
        }

        private int _applicationID;
        public int applicationID
        {
            get { return _applicationID; }
        }

        private int _licenseClassID;
        public int licenseClassID
        {
            get { return _licenseClassID; }
        }

        public int passedTest  { get; set; }
        private int _originalLLocalDrivingLicenseApplicationsID { get; set; }
        public int originalLLocalDrivingLicenseApplicationsID
        {
            get { return _originalLLocalDrivingLicenseApplicationsID; }
        }

        private clsLocalDrivingLicense(int LocalDrivingLicenseApplicationsID, int ApplicationID, int LicenseClassID) { 
        


            this._localDrivingLicenseApplicationsID= LocalDrivingLicenseApplicationsID;
            this._applicationID = ApplicationID;
            this._licenseClassID = LicenseClassID;
            this.passedTest = 0;
            this._originalLLocalDrivingLicenseApplicationsID = LocalDrivingLicenseApplicationsID;//null in data base.
       
        }
            private clsLocalDrivingLicense() { }

        private clsLocalDrivingLicense(int LocalDrivingLicenseApplicationsID, int ApplicationID, int LicenseClassID, int passedTest, int originalLLocalDrivingLicenseApplicationsID)
        {

            this._localDrivingLicenseApplicationsID = LocalDrivingLicenseApplicationsID;
            this._applicationID = ApplicationID;
            this._licenseClassID = LicenseClassID;
            this.passedTest = passedTest;
            this._originalLLocalDrivingLicenseApplicationsID = originalLLocalDrivingLicenseApplicationsID;



        }

        static   public clsLocalDrivingLicense CreateLocalDrivingLicense(int applicationID,int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationsID = clsLocalDrivingLicenseTable.AddRow(applicationID,LicenseClassID,0, -1);
            if (LocalDrivingLicenseApplicationsID != -1)
            {
                return new clsLocalDrivingLicense(LocalDrivingLicenseApplicationsID, applicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        static public DataView GetAllLDLApplications()
        {
            DataTable  table= clsLocalDrivingLicenseTable.GetAllLDLApplications();
            return table.DefaultView;

        }
      static public clsLocalDrivingLicense  ObjectWithexistedID(int ID)
        {
            int originalLLocalDrivingLicenseApplicationsID = 0;
            int localDrivingLicenseApplicationsID = 0;
            int licenseClassID = 0;
            int applicationID = 0;
            int passedTest = 0;
            if (clsLocalDrivingLicenseTable.ObjectWithIDexists(ID,ref originalLLocalDrivingLicenseApplicationsID,ref localDrivingLicenseApplicationsID,ref licenseClassID,ref applicationID,ref passedTest))
            {
                
                return new clsLocalDrivingLicense(ID, applicationID, licenseClassID, passedTest, originalLLocalDrivingLicenseApplicationsID);
            }else return null;
        }
        public bool Save()
        {

            //if the row is related to the new local driving license application in application table row 
            //then will update only in one row
            // otherwise if the row is related to the retake test application then the updating will affect
            //the that related to the retake test application and the original row of Local driving license table 
            //which  is  linked to the new local driving lincese driving application throught the originalLLocalDrivingLicenseApplicationsID column 
            return clsLocalDrivingLicenseTable.UpdateRow(this._localDrivingLicenseApplicationsID, this.passedTest,this. _originalLLocalDrivingLicenseApplicationsID );
            
          
        }
        
        //here you need another static constractor method accepts int applicationID,int LicenseClassID and the original  Local  Driving license.(Retake a test)
       public clsLocalDrivingLicense (clsApplication RetakeTestApplication,clsDrivingLicenseClass.enDLC DClass,clsLocalDrivingLicense originalLdlObj)
        {
            this._applicationID = RetakeTestApplication.ApplicationsID;
            this._licenseClassID = (int)DClass;
            this.passedTest = 0;
            this._originalLLocalDrivingLicenseApplicationsID = originalLdlObj.originalLLocalDrivingLicenseApplicationsID;
            this._localDrivingLicenseApplicationsID = clsLocalDrivingLicenseTable.AddRow(_applicationID, _licenseClassID, passedTest, _originalLLocalDrivingLicenseApplicationsID);
        
        
        }
        public clsLocalDrivingLicense CreateObjectRelated(clsApplication retakeTestApplication)
        {
            int theNewObjectID =clsLocalDrivingLicenseTable.AddRow(retakeTestApplication.ApplicationsID, this._licenseClassID,this.passedTest,this._originalLLocalDrivingLicenseApplicationsID) ;
            return new clsLocalDrivingLicense(theNewObjectID, retakeTestApplication.ApplicationsID, this.licenseClassID, this.passedTest,this._originalLLocalDrivingLicenseApplicationsID);
        }
    
            public static bool DeleteLocalDrivingLicense(int LocalDrivingLicenseID)
            {

            clsLocalDrivingLicense LDLObject = ObjectWithexistedID(LocalDrivingLicenseID);
            if (LDLObject != null)
            {

                return clsLocalDrivingLicenseTable.DeleteLocalDrivingLicenceRow(LocalDrivingLicenseID) && clsApplication.DeleteApplication(LDLObject.applicationID);

            }
            else return false;



        }
    
    
    }
}
