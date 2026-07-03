//using bussinessLayer;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using DataAccessLayer;

namespace bussinessLayer
{
    public class clsUser
    {
        public enum enMode { ADD, UPDATE };
        public int  userID {  get; set; } 
        public string username {  get; set; }
        public string password { get; set; }
        public bool _isActive {  get; set; }
        //private int _personID {  get; set; }
        public enMode mode { get; set; }

        public clsPerson _person {  get; set; }
        //Constrators
        private clsUser(int userID, int personID, string username, string password, bool isActive)
        {
            this.mode = enMode.UPDATE;
            this.userID = userID;
            this._isActive = isActive;
            // this.PersonID = personID;
            this.username = username;
            this.password = password;
            this._person = clsPerson.FindPerson(personID);


        }
        private clsUser()
        {
            this.mode = enMode.ADD;
            this.userID = -1;
           // this._person=clsPerson.FindPerson(-1);
        }
        //Methodes
        static public DataView UserTable()
        {
            DataTable userTable = clsUserTable.UserTable();
            return userTable.DefaultView;
        }
        static public clsUser  FindUser(string username, string password)
        {
            //This object returns the clsUser Object if the object exists,otherwise returns null.
            int userID = 0,personID=0;
            bool isActive=false;
            // string username = "";password = "";
            if (clsUserTable.FindUserbyUsernameAndPassword(ref userID,ref personID, username, password,ref isActive))
            {
                return new clsUser(userID,personID ,username, password,isActive);


            }
            else
            {
                return null;
            }
        }
     
        static private clsUser _GetUserWithID(int userID)
        {
            //This method returns the clsUser Object if the object exists,otherwise returns null.
            int personID = 0;
            bool isActive = false;
            string username = "",password = "";
            if (clsUserTable.FindUserbyID( userID, ref personID,ref username,ref password, ref isActive))
            {
                return new clsUser(userID, personID, username, password, isActive);


            }
            else
            {
                return null;
            }
        }
        static public clsUser FindUser(int userID)
        {
            //ID equals -1 is  the adding mode
            // otherwise, ID(usually greater than 0) is  the updating mode
            if (userID == -1)
            {
                return new clsUser();
            }
            else
            {
                return _GetUserWithID(userID);
            }
        }
        private bool _AddNewUser()
        {
            this.userID =clsUserTable.AddNewUser(this._person.PersonID,this.username,this.password,this._isActive);
            if (this.userID != -1) { this.mode = enMode.UPDATE; return true; }
            else { return false; }
        }
        private bool _UpdateUser()
        {
            return clsUserTable.UpdateUser(this.userID ,this._person.PersonID, this.username, this.password, this._isActive);

        }
        public bool Save()
        {
            switch (this.mode)
            {
                case enMode.ADD:
                  return   _AddNewUser();
                case enMode.UPDATE:
                    return _UpdateUser();
            }
            return false;
        }
        static public bool IsPersonUser(int userID)
        {
            return clsUserTable.IsUser( userID);
        }

        static public bool usernameExists(string username)
        {
            return clsUserTable.UsernameExists(username);
        }

        private static int _GetPersonWithUserID(int UserID)
        {
            return clsUserTable.GetPersonWithUserID(UserID);
        }
        public static bool DeleteUserWithID(int UserID)
        {
            int personID = _GetPersonWithUserID(UserID);
            if (clsUserTable.DeleteUserWithUserID(UserID))
            {
                if (clsPeopleTable.DeletePerson(personID))
                {

                    return true;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }
    }
}
