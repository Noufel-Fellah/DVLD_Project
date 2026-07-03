using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class TestAppointmetsTable
    {
       static private  DataTable _initialleTable()
        {
            
           DataTable table =new DataTable();
            DataColumn dtColumn;//declare the variable
            //Delcare TestAppointmentID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "TestAppointmentID";//Name
         
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Delcare TestAppointmentID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);//type
            dtColumn.ColumnName = "AppointmentDate";//Name

            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Delcare TestAppointmentID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(float);//type
            dtColumn.ColumnName = "PaidFees";//Name

            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Delcare TestAppointmentID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(bool);//type
            dtColumn.ColumnName = "IsLocked";//Name

            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table

           return table;









        }




        static public DataTable GetAllAppointmentsOfLDLID(int LDLID, int TesttypeID)
        {
            //initialle the table:
            DataTable table = _initialleTable();
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "Select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from viewAppointments where LDLApp=@LDLApp and TestTypeID=@TestTypeID;";
            SqlCommand command =new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLApp", LDLID);
            command.Parameters.AddWithValue("@TestTypeID", TesttypeID);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) { 
                
                table.Load(reader);
                }
               
                
                
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return table;
        }

       static public int  AddNewTestAppointment(int lDLAID, DateTime appointmentDate, int testType, float paidFees, bool isLocked, int createdByUserID)
        {
            int recordID = -1;
            SqlConnection connection=new SqlConnection(dataAccessSettings.connectionString);
            string query = "INSERT INTO TestAppointments (TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked) VALUES (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", testType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", lDLAID);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@IsLocked", isLocked);
            try {
                connection.Open();
                object result = command.ExecuteScalar();
                if (int.TryParse(result.ToString(),out int ID))
                {
                    recordID = ID;
                }

            }
            catch(Exception ex) { } 
            finally { connection.Close(); } 
            return recordID;




        }
        static public bool UpdateAppointment(int appointmentID, int lDLAID, DateTime appointmentDate, int testType, float paidFees, bool isLocked, int createdByUserID)
        {
            int rowsAffected = -1;
            SqlConnection connection=new SqlConnection(dataAccessSettings.connectionString);
            string query = "UPDATE TestAppointments SET TestTypeID = @TestTypeID, LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ,AppointmentDate = @AppointmentDate, PaidFees = @PaidFees ,CreatedByUserID = @CreatedByUserID ,IsLocked = @IsLocked  WHERE TestAppointments.TestAppointmentID=@ID;";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", appointmentID);
            command.Parameters.AddWithValue("@TestTypeID", testType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID ", lDLAID);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@IsLocked", isLocked);
            try {
                connection.Open();
                rowsAffected= command.ExecuteNonQuery();
                
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffected > 0;




        }
        static public bool UpdateAppointment(int appointmentID,bool isLocked)
        {
            int rowsAffected = -1;
            //write the updating login in the test appointment table;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "UPDATE TestAppointments SET IsLocked = @IsLocked  WHERE TestAppointments.TestAppointmentID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", appointmentID);
          
            command.Parameters.AddWithValue("@IsLocked", isLocked);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffected > 0;



        }
        static public bool UpdateAppointment(int appointmentID, DateTime appointmentDate)
        {
            int rowsAffected = -1;
            //write the updating login in the test appointment table;
       
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "UPDATE TestAppointments SET AppointmentDate = @AppointmentDate WHERE TestAppointments.TestAppointmentID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", appointmentID);
          
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
         
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffected > 0;



        }
    
        




    }
}
