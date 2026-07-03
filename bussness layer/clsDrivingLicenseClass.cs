using DataAccessLayer;
using System;
using System.Collections.Generic;


namespace bussinessLayer
{
    public class clsDrivingLicenseClass
    {
        public enum enDLC
        {
            SmallMotorcycle = 1,
            HeavyMotorcycleLicense = 2, OrdinaryDrivingLicense = 3, Commercial = 4, Agricultural = 5
, SmallAndMediumBus = 6, TruckAndHeavyVehicle = 7
        }
        
        private int _licenseClassesID;

        public int LicenseClassesID
        {
            get { return _licenseClassesID; }

            
        }
      
        public string     ClassName     { get; set; }
        public string     ClassDescription { get; set; }
        public int      MinimumAllowedAge       { get; set; }
        public int      DefaultValidityLength { get; set; }
        public float       ClassFees              { get; set; }
        public enDLC license { get; set; }
        //Constractor
       private clsDrivingLicenseClass() { }//preventing user to create object which's different amoung the six original objects.
       public  clsDrivingLicenseClass(enDLC drivingclass)
        {

            
            int licenseClassesID = (int)drivingclass;
            string className="";
             string classDescription=null;
            int minimumAllowedAge=0;
            int defaultValidityLength=0;
            float classFees = 0;
            clsLicenseClassesTable.GetDrivingClass(ref licenseClassesID, ref className, ref classDescription, ref minimumAllowedAge, ref defaultValidityLength, ref classFees);
            this._licenseClassesID = licenseClassesID;
            this.license = drivingclass;
            this.ClassName = className;
             this.ClassDescription= classDescription;

             this.MinimumAllowedAge= minimumAllowedAge;
            this.DefaultValidityLength = defaultValidityLength;
            this.ClassFees = classFees;




        }
       
        private clsDrivingLicenseClass(int licenseClassesID,string className,string classDescription,int  minimumAllowedAge,int  defaultValidityLength,float classFees) {
            this._licenseClassesID = licenseClassesID;
            this.license =(enDLC) licenseClassesID;
            this.ClassName = className;
            this.ClassDescription = classDescription;

            this.MinimumAllowedAge = minimumAllowedAge;
            this.DefaultValidityLength = defaultValidityLength;
            this.ClassFees = classFees;


        }
      static  public clsDrivingLicenseClass GetDrivingLicense(string className)
        {



            int licenseClassesID = 0;
         string classDescription = "";
         int minimumAllowedAge = 0; 
         int defaultValidityLength=0;
         float classFees = 0;
            if (clsLicenseClassesTable.GetDrivingClass(ref licenseClassesID, ref className, ref classDescription, ref minimumAllowedAge, ref defaultValidityLength, ref classFees))

            {
                return new clsDrivingLicenseClass(licenseClassesID, className, classDescription, minimumAllowedAge, defaultValidityLength, classFees);
            }
            else return null;
        }
        //methods
        static public List<string> GetAllClasses()
        {
            return clsLicenseClassesTable.GetAllClasses();
        }


    }
}
