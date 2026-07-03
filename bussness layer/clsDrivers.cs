using DataAccessLayer;
using System;
using System.Runtime.InteropServices;


namespace bussinessLayer
{
    public class clsDrivers
    {
        private int _driverID;
        public int  DriverID {  get { return _driverID; } }

        private clsPerson _person;
        public clsPerson Person { get { return _person; } }

        private int _createdByUserID;
        public int createdByUserID {  get { return _createdByUserID; } }
        private DateTime _createdDate;
        public DateTime CreatedDate
        {
           get { return _createdDate; }
            set
            {
                if(ADDMode) { _createdDate = value; }
            }
        }

        bool ADDMode;
        //methodes
        clsDrivers() { }
       public clsDrivers(clsPerson person,clsUser user) {
            int driverID=0;
            int createdByUserID=0  ;
            DateTime createdDate=DateTime.Now;
            if (clsDriversTable.DriverExistsByPersonID(person.PersonID,ref driverID,ref createdByUserID,ref createdDate ))
            {
                this._driverID = driverID;
                this._person = person;
                this._createdByUserID = createdByUserID;
                this.CreatedDate = createdDate;
                ADDMode = false;
            }
            else
            {
                this._driverID = -1;
                this._person = person;
                this._createdByUserID = user.userID;
                ADDMode = true;
                this.CreatedDate = DateTime.Now;
            }
       
        }
      private  clsDrivers(clsPerson person,int  driverID,int  createdByUserID,DateTime createdDate)
        {
            this._driverID = driverID;
            this._person = person;
            this._createdByUserID = createdByUserID;
            this.CreatedDate = createdDate;
            ADDMode = false;
        }

        public  bool Save()
        {
            if (ADDMode)
            {
                this._driverID = clsDriversTable.AddRowInDriversTable(this._person.PersonID, this._createdByUserID, this.CreatedDate);
                return _driverID != -1;
            }
           else return true;   
        }
        //Create find method by personID.

         static  public clsDrivers FindDriverByPerson(clsPerson person)
        {
            int driverID = 0;
            int createdByUserID = 0;
            DateTime createdDate = DateTime.Now;
            if (clsDriversTable.DriverExistsByPersonID(person.PersonID, ref driverID, ref createdByUserID, ref createdDate))
            {
                return new clsDrivers(person, driverID, createdByUserID, createdDate);
            }
            else return null;
        }
        static public clsDrivers GetDriverByDriverID(int DriverID)
        {
            int personID = 0;
            int createdByUserID = 0;
            DateTime createdDate = DateTime.Now;
            if(clsDriversTable.GetDriverByDriverID(DriverID,ref personID,ref createdByUserID,ref createdDate))
            {
                return new clsDrivers(clsPerson.FindPerson(personID),DriverID, createdByUserID, createdDate);
            }else return null;
        }




















    }
}
