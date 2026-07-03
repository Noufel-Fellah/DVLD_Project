using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace DataAccessLayer
{
    public  class clsLicensesTable
    {
       static public bool PersonHasDrivingLicense(int personID,int  licenseClassesID)
        {

            bool answer = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select top 1 Answer='Y' from Licenses li inner join Drivers D on li.DriverID=D.DriverID   inner join LicenseClasses L on L.LicenseClassID=li.LicenseClass where D.PersonID=@personID and L.LicenseClassID=@LicenseClassID ;";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@personID",personID);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassesID);
            try {
                connection.Open();
                object value=command.ExecuteScalar();
                if (value != null) { answer = true; }
            
            
            }
            catch (Exception ex){ }
            finally { connection.Close(); }
            return answer;
        }

      static public int   AddNewRowInLicenseTable(int applicationID,int driverID,int licenseClassID, DateTime issueDate, DateTime expirationDate,string Notes, float paidFees,bool IsActive,byte IssueReason, int  userID)
        {
            int licenseID = -1;
            SqlConnection connection =new SqlConnection (dataAccessSettings.connectionString);
            string query = "INSERT INTO Licenses(ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID) VALUES(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID); SELECT SCOPE_IDENTITY();";
            SqlCommand command =new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ApplicationID",applicationID);
            command.Parameters.AddWithValue("@DriverID", driverID);
            command.Parameters.AddWithValue("@LicenseClass", licenseClassID);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            if (string.IsNullOrWhiteSpace(Notes))
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);

            }
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", userID);
            try
            {
                connection.Open();
                object result=command.ExecuteScalar();
                if (int.TryParse(result.ToString(),out int ID))
                {
                    licenseID = ID;
                }


            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return licenseID;
            }

        static public bool GetActiveLicense(ref int licenseID, ref int applicationID, int DriverID, ref int licenseClassTypeID, ref DateTime issueDate, ref DateTime expirationDate, ref string Notes, ref float paidFees, ref bool IsActive, ref int IssueReason, ref int createdByUserID)
        {
            bool itExisted = false;
            //write the logic in here
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "SELECT  Top 1  * FROM Licenses  where DriverID=@DriverID and  LicenseClass=@licenseClass   order by IssueReason desc;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@licenseClass", licenseClassTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    licenseID = int.Parse(reader["LicenseID"].ToString());
                    applicationID = int.Parse(reader["ApplicationID"].ToString());
                    issueDate = DateTime.Parse(reader["IssueDate"].ToString());
                    expirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());
                    Notes = reader["Notes"].ToString();
                    paidFees = float.Parse(reader["PaidFees"].ToString());
                    IsActive = bool.Parse(reader["IsActive"].ToString());
                    IssueReason = int.Parse(reader["IssueReason"].ToString());
                    createdByUserID = int.Parse(reader["CreatedByUserID"].ToString());
                    licenseClassTypeID = int.Parse((reader["LicenseClass"]).ToString());
                    itExisted = true;

                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return itExisted;


        }
        static public bool GetActiveLicenseByLicenseID( int licenseID, ref int applicationID,ref int  DriverID,ref int licenseClassTypeID, ref DateTime issueDate, ref DateTime expirationDate, ref string Notes, ref float paidFees, ref bool IsActive, ref int  IssueReason, ref int createdByUserID)
        {
            bool itExisted=false;
            //write the logic in here
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "SELECT   * FROM Licenses  where LicenseID=@ID   ";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.Read()) {

                  //licenseID =int.Parse(reader["LicenseID"].ToString());
                  applicationID =int.Parse(reader ["ApplicationID"].ToString());
                  issueDate =DateTime.Parse(reader ["IssueDate"].ToString());
                  expirationDate = DateTime.Parse(reader ["ExpirationDate"].ToString());
                  Notes =reader ["Notes"].ToString();
                    DriverID = int.Parse(reader["DriverID"].ToString());
                   paidFees =float.Parse(reader ["PaidFees"].ToString());
                  IsActive = bool.Parse(reader["IsActive"].ToString());
                  IssueReason =int.Parse(reader ["IssueReason"].ToString());
                  createdByUserID =int.Parse(reader ["CreatedByUserID"].ToString());
                    licenseClassTypeID = int.Parse((reader["LicenseClass"]).ToString());
                    itExisted = true;

                }
            }
            catch (Exception ex) { }
            finally{ connection.Close(); }


            return itExisted;


        }
        static private DataTable _GetLicensesTableOFOneDriver()
        {
            DataTable table = new DataTable();
            DataColumn dtColumn;
            //Create LicenseID column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "LicenseID";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
          
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create ApplicationID column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "ApplicationID";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute

            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create ClassName column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "ClassName";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute

            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create IssueDate column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);//type
            dtColumn.ColumnName = "IssueDate";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute

            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create ExpirationDate column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);//type
            dtColumn.ColumnName = "ExpirationDate";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute

            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create IsActive column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(bool);//type
            dtColumn.ColumnName = "IsActive";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute

            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            return table;


        }
        static public DataTable GetAllLicensesOfDriverByTheirID(int driverID)
        {
            DataTable table = _GetLicensesTableOFOneDriver();
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "Select Licenses.LicenseID,Licenses.ApplicationID,LicenseClasses.ClassName,Licenses.IssueDate,Licenses.ExpirationDate,Licenses.IsActive from Licenses inner join LicenseClasses on Licenses.LicenseClass=LicenseClasses.LicenseClassID where Licenses.DriverID=@ID;";
            SqlCommand command=new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ID", driverID);
            try {

                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
            
            }
            catch(Exception ex) { }
            finally { connection.Close(); }
            return table;
        }

        static public bool deactivatedLicense(int licenseID)
        {
            int rowsAffected = -1;
            SqlConnection connection =new SqlConnection (dataAccessSettings.connectionString);
            string query = "UPDATE Licenses  SET IsActive = 0  WHERE Licenses.LicenseID=@ID;";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            try {
                connection.Open();
                rowsAffected= command.ExecuteNonQuery();
            
            
            
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffected > 0;
        }




    }
}
