using DataAccessLayer;
using System;
using System.Data;


namespace bussinessLayer
{
    public class clsAppType
    {
        public enum enAppTypes
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService = 2,
            ReplacementForALostDrivingLicense = 3,
            ReplacementForADamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicsense = 5,
            NewInternationalLicense = 6,
                RetakeTest=7
        };

        public int appTypeID {  get; set; }
        public string appTypeTitle {  get; set; }
        public float appTypeFees {  get; set; }
     
        //AllConstractors
        private clsAppType() { }//prevent a user to create a dummy object(there a limited types of object)
        private clsAppType(int appTypeID,string appTypeTitle, float appTypeFees)
        {
            this.appTypeID = appTypeID;
            this.appTypeTitle = appTypeTitle;
            this.appTypeFees = appTypeFees;
        }
        //methods
        static public DataView GetAllAppTypes()
        {
            DataTable table = appTypesTable.GetAllAppTypes();
            return table.DefaultView;
        }
        static public clsAppType FindApp(int appTypeID)
        {
            if (appTypeID <= 0 || appTypeID > 7)
            {
                return null;
            }
            else
            {


                string appTypeTitle = "";
                float appTypeFees = 0;
                if (appTypesTable.FindApp(appTypeID, ref appTypeTitle, ref appTypeFees))
                {




                    return new clsAppType(appTypeID, appTypeTitle, appTypeFees);
                }
                else
                {
                    return null;
                }



            }
        }
        static public clsAppType FindApp(enAppTypes appTypeID)
        {

            return FindApp((int)appTypeID);
        }

        public bool Save()
        {
            return appTypesTable.SaveChanges(this.appTypeID,this.appTypeTitle,this.appTypeFees);
        }
        



    }
}
