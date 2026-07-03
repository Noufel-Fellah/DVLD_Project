using bussinessLayer;
using DataAccessLayer;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using static bst.clsAppointement;


namespace bst
{
    public class clsAppointement
    {
        private int _appointmentID;
        public int AppointmentID
        {
            get { return _appointmentID; }
        }

        private clsTestTypes.enTestTypes _testType;
        public clsTestTypes.enTestTypes TestType
        {
            get { return _testType; }
            set
            {
                if (this._mode == enMode.ADD)
                {
                    _testType = value;
                }
            }
        }


        private int _LDLAID;
        public int LDLAID
        {
            get { return _LDLAID; }
            set
            {
                if (this._mode == enMode.ADD)
                {
                    _LDLAID = value;
                }
            }

        }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        private int _createdByUserID;
        public int CreatedByUserID
        {
            get { return _createdByUserID; }
            set
            {
                if (this._mode == enMode.ADD)
                {
                    _createdByUserID = value;
                }
            }

        }
        public bool IsLocked { get; set; }
        public enum enMode { ADD = 1, UPDATE = 2 };
        public enMode _mode;
        public enum enSavedColumn { All = 0, isLockedColumn = 1, DateApointmentColumn = 2 };

        //Constractors
        clsAppointement(int appointmentID, clsTestTypes.enTestTypes type, int LDLAID, DateTime AppointmentDate, float AppointmentFees, bool isLocked, int CreatorID)
        {
            this._appointmentID = appointmentID;
            this._testType = type;
            this._LDLAID = LDLAID;
            this.AppointmentDate = AppointmentDate;
            this.IsLocked = isLocked;
            this.PaidFees = AppointmentFees;
            this._createdByUserID = CreatorID;
            this._mode = enMode.UPDATE;

        }
        clsAppointement()
        {
            this._appointmentID = -1;

            this._mode = enMode.ADD;

        }
        //Methods
        static public DataView GetAllAppointmentsOfLDLID(int LDLID, clsTestTypes.enTestTypes type)
        {

            return TestAppointmetsTable.GetAllAppointmentsOfLDLID(LDLID, (int)type).DefaultView;
        }

        static private clsAppointement _CreateAppointmentWithID(int appointmentID)
        {
            int typeID = 0;
            int LDLAID = 0;
            DateTime AppointmentDate = DateTime.Now;
            float AppointmentFees = 0;
            bool isLocked = false;
            int creatorID = 0;
            if (clsApplicationTable.FindAppointmentWithID(appointmentID, ref typeID, ref LDLAID, ref AppointmentDate, ref AppointmentFees, ref isLocked, ref creatorID))
            {
                return new clsAppointement(appointmentID, (clsTestTypes.enTestTypes)typeID, LDLAID, AppointmentDate, AppointmentFees, isLocked, creatorID);
            }
            else
            {
                return null;
            }
        }
        static public clsAppointement CreateAppointment(int appointmentID = -1)//Trial=The number of test  Appointments that a person subscribes in
        {
            //This function returns a clsAppointment object
            //if the appointmentID equals : the function will
            //-1  : Create new object with activating add mode 
            //true appointmentID :Activate update mode on existing 
            //fake appointmentID: return null value 
            if (appointmentID == -1)
            {
                return new clsAppointement();
            }
            else { return _CreateAppointmentWithID(appointmentID); }







        }

        private bool _UpdateAppointment(clsAppointement.enSavedColumn  savedColumn)
        {
           
            switch (savedColumn)
            {

                case enSavedColumn.All:
                    return TestAppointmetsTable.UpdateAppointment(this.AppointmentID, this._LDLAID, this.AppointmentDate, (int)this.TestType, this.PaidFees, this.IsLocked, this.CreatedByUserID);
                case enSavedColumn.isLockedColumn:
                    return TestAppointmetsTable.UpdateAppointment(this.AppointmentID ,this.IsLocked);
                case enSavedColumn.DateApointmentColumn:

                   return TestAppointmetsTable.UpdateAppointment(this.AppointmentID, this.AppointmentDate);


            }
            return false;
        }
        private bool _AddNewAppointment()
        {
            this._appointmentID = TestAppointmetsTable.AddNewTestAppointment(this._LDLAID, this.AppointmentDate, (int)this.TestType, this.PaidFees, this.IsLocked, this.CreatedByUserID);
            return this._appointmentID != -1;
        }
        public bool Save(clsAppointement.enSavedColumn savedColumn = clsAppointement.enSavedColumn.All)
        {
            switch (this._mode)
            {
                case enMode.ADD:
                    return _AddNewAppointment();
                case enMode.UPDATE:


                    return _UpdateAppointment(savedColumn);

            }

            return false;

        }




    }
}
