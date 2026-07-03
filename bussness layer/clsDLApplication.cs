using bst;
using DataAccessLayer;
using System;


namespace bussinessLayer
{
    public  class clsDLApplication
    {

        //properties
        
       public clsPerson Person { get; set; }
       public clsApplication application {  get; set; }
       public clsUser user { get; set; }
      public  clsAppType.enAppTypes appType { get; set; }
      public  clsLocalDrivingLicense LocalDrivingLicense { get; set; }
      //public //  clsApplication.enAppStatus Status { get; set; }
      public  clsDrivingLicenseClass.enDLC Dclass { get; set; }
        //constractors
        //1-ADD APLICATION CONSTRACTOR
        private clsDLApplication(clsPerson person, clsAppType.enAppTypes appType, clsApplication.enAppStatus status, clsDrivingLicenseClass.enDLC Dclass, clsUser user,clsApplication application)
        {
            this.Person = person;
            this.application = application;
            this.user= user;
            this.appType = appType;
           // this.Status= status;
           this. LocalDrivingLicense = null;
            this.Dclass = Dclass;


        }
       //2-UPDATE APLICATION CONSTRACTOR.
        private clsDLApplication ()  { }
        private clsDLApplication(clsLocalDrivingLicense ldl, clsAppType.enAppTypes type)
        {
           
                this.application = clsApplication.GetApplicationWithLicenseClassType(ldl.applicationID, type);
                this.Person = clsPerson.FindPerson(application.ApplicantPersonID);
                this.user = clsUser.FindUser(this.application.CreatedByUserID);
                this.appType = type;
                this.LocalDrivingLicense = ldl;
                this.Dclass = (clsDrivingLicenseClass.enDLC)ldl.licenseClassID;

            
           
        }
        
        //methods.
        static private clsDLApplication _CreateNewLocalDrivingLicenseSercivesObject(clsPerson person, clsAppType.enAppTypes appType, clsApplication.enAppStatus status, clsDrivingLicenseClass.enDLC Dclass, clsUser user, DateTime appDate)
        {
            clsApplication application = clsApplication.CreateApplication(person, appType, status, Dclass, user, appDate);
          if (application.mode==clsApplication.enmode.ADD && !person.HasDrivingLicense((int)Dclass)) 
            {
                return new  clsDLApplication(person,appType,status,Dclass,user,application);
            }
            else
            {
                return null;
            }
        }
        static public  clsDLApplication  CreateObject(clsPerson person,clsAppType.enAppTypes appType,clsApplication.enAppStatus status,clsDrivingLicenseClass.enDLC Dclass,clsUser user, DateTime ApplicationDate,DateTime LastStatusDate)
        {
            //Two part here :having a license or there is already an existing application. 
            switch (appType)
            {
                case clsAppType.enAppTypes.NewLocalDrivingLicenseService:
                    return _CreateNewLocalDrivingLicenseSercivesObject( person,  appType,  status,  Dclass,  user,  ApplicationDate);

                default:
                    return null;

            }
                 

            return null;
        }
        static public clsDLApplication initialleLDLAppByLocalDrivingLicenseID(clsLocalDrivingLicense ldl, clsAppType.enAppTypes type)
        {
           
            if (ldl!=null && (type==clsAppType.enAppTypes.RetakeTest ||type==clsAppType.enAppTypes.NewLocalDrivingLicenseService))
            {
                return new clsDLApplication(ldl,type);



            }else return null;
        }
        static public clsDLApplication CreateRetakeTest(clsPerson person, clsUser user,clsLocalDrivingLicense LDLobj, DateTime ApplicationDate)
        {
            clsDLApplication obj=new clsDLApplication();
            obj.Dclass = (clsDrivingLicenseClass.enDLC)LDLobj.licenseClassID;
            obj.application = clsApplication.CreateApplication(person, clsAppType.enAppTypes.RetakeTest, clsApplication.enAppStatus.New, obj.Dclass, user, ApplicationDate);
            obj.application.Save();
            obj.Person = person;
            obj.user = user;
            obj.LocalDrivingLicense = LDLobj.CreateObjectRelated(obj.application);
            return obj;

        }

        //Create save method.

        public bool Save()
        {
            if (this.application.Save())
            {
                this.LocalDrivingLicense = application.LocalDrivingLicense(this.Dclass);
                if(this.LocalDrivingLicense == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }






        }
        

    }
}
