using System;

using System.Data.SqlClient;



namespace DataAccessLayer
{
    public class clsTestTable
    {
      static public   bool PersonPassedTest(int LDLID, int typeID)
        {
            bool answer = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "Select Answer='Y' from  viewAppointments inner join Tests on viewAppointments.TestAppointmentID=Tests.TestAppointmentID where viewAppointments.TestTypeID=@TestTypeID and viewAppointments.LDLApp=@LDLAppID and Tests.TestResult=1;";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@TestTypeID",typeID);
            command.Parameters.AddWithValue("@LDLAppID", LDLID);
            try {
            connection.Open();
                object value= command.ExecuteScalar();
                if (value != null) { answer = true; }

            
            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return answer;
        }
        static public int AddRowInTestsTable(int testAppointmentID,bool TestResult,string  Notes,int createdByUserID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "INSERT INTO Tests(TestAppointmentID,TestResult,Notes,CreatedByUserID) VALUES ( @TestAppointmentID, @TestResult, @Notes,@CreatedByUserID);SELECT SCOPE_IDENTITY();";
            SqlCommand command= new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult); 
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            try {
                connection.Open();
                    object value= command.ExecuteScalar();
                if (int.TryParse(value.ToString(),out int result))
                {
                        TestID = result;  
                }
            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return TestID;



        }


    }
}
