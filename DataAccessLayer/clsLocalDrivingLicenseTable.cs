using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseTable
    {
        static private DataTable CreateLDLAtable()
        {
           
            DataTable dt = new DataTable();
            DataColumn dtColumn;
            // LDLApp
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "LDLApp";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
           
            
            dt.Columns.Add(dtColumn);//Adding The above column to a data table
            // NationalNo
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "NationalNo";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dt.Columns.Add(dtColumn);//Adding The above column to a data table
            // // DrivingClass
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "DrivingClass";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dt.Columns.Add(dtColumn);//Adding The above column to a data table
                                     //
           //FullName
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "FullName";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dt.Columns.Add(dtColumn);//Adding The above column to a data table
            //ApplicationDate
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);//type
            dtColumn.ColumnName = "ApplicationDate";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dt.Columns.Add(dtColumn);//Adding The above column to a data table
            //ApplicationStatus
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "ApplicationStatus";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dt.Columns.Add(dtColumn);//Adding The above column to a data table

            //passedTests
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "passedTests";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dt.Columns.Add(dtColumn);//Adding The above column to a data table
            return dt;

        }
        static public int AddRow(int ApplicationID, int LicenseClassID, int passedTests, int applicationBase=-1)
        {
            int LocalDrivingLicenseID = -1;
           
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID,LicenseClassID ,passedTests,applicationBase)VALUES(@ApplicationID,@LicenseClassID ,@passedTests,@applicationBase);  SELECT SCOPE_IDENTITY();";
                SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID",ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@passedTests", passedTests);
            if (applicationBase == -1)
            {
                command.Parameters.AddWithValue("@applicationBase", DBNull.Value);

            }
            else
            {
                command.Parameters.AddWithValue("@applicationBase", applicationBase);

            }


            try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (int.TryParse(result.ToString(), out int ID))
                    {
                        LocalDrivingLicenseID = ID;

                    }
                }
                catch (Exception ex) { }
                finally { connection.Close(); }
            return LocalDrivingLicenseID;


        }

       static public bool ObjectWithIDexists(int ID, ref int originalLLocalDrivingLicenseApplicationsID, ref int localDrivingLicenseApplicationsID, ref int licenseClassID, ref int  applicationID, ref int passedTest)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                  applicationID=int.Parse( reader["ApplicationID"].ToString());
                 licenseClassID=int.Parse(  reader["LicenseClassID"].ToString());
                 
                    passedTest= int.Parse( reader["passedTests"].ToString());
                  originalLLocalDrivingLicenseApplicationsID=(reader["applicationBase"]==DBNull.Value ? ID:int.Parse( reader["applicationBase"].ToString()));
                    isFound = true;

                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return isFound;

        }
        static public DataTable GetAllLDLApplications()
        {
            DataTable table = CreateLDLAtable();
            SqlConnection connection =new SqlConnection(dataAccessSettings.connectionString);
            string query = "Select LDLApp=LDLAview.LocalDrivingLicenseApplicationID,People.NationalNo,LDLAview.ClassName as DrivingClass,FullName = People.FirstName+' '+People.SecondName + ' ' +People.ThirdName+' '+People.LastName ,Applications.ApplicationDate,ApplicationStatus =case when Applications.ApplicationStatus=1 then 'New' when Applications.ApplicationStatus=2 then 'Cancelled' when Applications.ApplicationStatus=3 then 'Completed' end ,LDLAview.passedTests  from Applications inner join People on applications.ApplicantPersonID=People.PersonID inner join LDLAview on LDLAview.applicationID=Applications.ApplicationID where LDLAview.applicationBase is Null;";
            SqlCommand command =new SqlCommand(query, connection);
            try {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                while (reader.HasRows) {
                    table.Load(reader);
                }
                    reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            

            return table;
        }
    
        static public bool UpdateRow(int localDrivingLicenseApplicationsID,  int passedTest, int originalLLocalDrivingLicenseApplicationsID)
        {
           int  rowsAffeted = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query;
            SqlCommand command;
            if (localDrivingLicenseApplicationsID == originalLLocalDrivingLicenseApplicationsID)
            {
                 query = "UPDATE LocalDrivingLicenseApplications  SET passedTests = @passedTests WHERE LocalDrivingLicenseApplicationID=@ID;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", localDrivingLicenseApplicationsID);


            }
            else
            {
                query = "UPDATE LocalDrivingLicenseApplications  SET passedTests = @passedTests WHERE LocalDrivingLicenseApplicationID=@LDLID and LocalDrivingLicenseApplicationID=@OriginalLDLID;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LDLID", localDrivingLicenseApplicationsID);
                command.Parameters.AddWithValue("@OriginalLDLID", originalLLocalDrivingLicenseApplicationsID);



            }
            command.Parameters.AddWithValue("@passedTests",passedTest);
            try { 
                connection.Open();
                rowsAffeted = command.ExecuteNonQuery();

            
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return rowsAffeted >0;
        }
   
    
        static public bool DeleteLocalDrivingLicenceRow(int LocalDrivingLicenseID)
        {
            int rowsAffected= -1;

            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "DELETE FROM LocalDrivingLicenseApplications  WHERE LocalDrivingLicenseApplicationID=@ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID",LocalDrivingLicenseID);
            try {

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            
            }
            catch (Exception ex) { }
            finally{ connection.Close(); }





            
            return rowsAffected > 0;
        }



    }
}
