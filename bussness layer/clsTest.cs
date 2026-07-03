using bussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bst
{
    public class clsTest
    {
        private int _testID;
        public int TestID
        {
            get { return _testID; }
        }
        private int _testAppointmentID;
        public int TestAppointmentID
        {
            get { return _testAppointmentID; }
        }
     public  bool TestResult { get; set; }
    public  string Notes { get; set; }
        private int _createdByUserID;
        public int createdByUserID
        {
            get { return _createdByUserID; }
           
        }
        private clsAppointement _appointment;
        //Constractors:
        clsTest() { }
       public  clsTest(clsAppointement appointement,clsUser user)
        {
            _testID = -1;
            _testAppointmentID = appointement.AppointmentID;
            _createdByUserID = user.userID;
            _appointment = appointement;

        }
       private bool _SaveRowInDB()
        {
        
          _testID = clsTestTable.AddRowInTestsTable(_testAppointmentID, TestResult, Notes, _createdByUserID);
            return _testID != -1;
        }
        public bool Save()
        {
            if (_SaveRowInDB())
            {
                _appointment.IsLocked = true;
                _appointment.Save(clsAppointement.enSavedColumn.isLockedColumn);
                if (this.TestResult)
                {
                  int ID=  clsLocalDrivingLicense.ObjectWithexistedID(_appointment.LDLAID).originalLLocalDrivingLicenseApplicationsID;
                  clsLocalDrivingLicense obj=  clsLocalDrivingLicense.ObjectWithexistedID(ID);
                   obj.passedTest++ ;
                    obj.Save();

                }
                return true;
            }
            else return false;
          
        }
       static public bool PersonPassedTest(int LDLID,clsTestTypes.enTestTypes type)
        {
            return clsTestTable.PersonPassedTest(LDLID, (int)type);
        }


    }
}
