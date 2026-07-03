using bussinessLayer;
using DataAccessLayer;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace bst
{
    public class clsTestTypes
    {
       public enum enTestTypes { VisionTest=1,WrittenTest=2,PraticalTest=3};
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }
        //constructors
        //preventing user to create an object from this class because the number of object are 
        //already spicified  ,this class has only 3 objects.
        //So we create an object  throught only the find method.
        private clsTestTypes() { }

        private clsTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;

        }

        static public DataView GetAllTestTypes()
        {
            DataTable table = clsTestTypesTable.GetAllTestTypes ();
            return table.DefaultView;
        }
        static public clsTestTypes FindTest(int testTypeID)
        {
            if (testTypeID <= 0 || testTypeID > 3)
            {
                return null;
            }
            else
            {




             
              string  TestTypeTitle = "";
                string  TestTypeDescription = "";
                float TestTypeFees = 0;

                if (clsTestTypesTable.FindTest(testTypeID, ref TestTypeTitle, ref TestTypeDescription,ref TestTypeFees))
                {




                    return new clsTestTypes(testTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
                }
                else
                {
                    return null;
                }



            }
        }

         public bool Save()
        {
            return clsTestTypesTable.Save(this.TestTypeID,this.TestTypeTitle,this.TestTypeDescription,this.TestTypeFees);
        }


    }
}
