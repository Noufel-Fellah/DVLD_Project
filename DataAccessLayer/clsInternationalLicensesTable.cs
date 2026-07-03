using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public  class clsInternationalLicensesTable
    {
        static private DataTable _InternationalDrivingLicenseForOneDriver()
        {
           // InternationalLicenses.,InternationalLicenses.ApplicationID,LocalLicenseID = InternationalLicenses.IssuedUsingLocalLicenseID ,InternationalLicenses.IssueDate,InternationalLicenses.ExpirationDate,InternationalLicenses.IsActive
            DataTable table = new DataTable();
            DataColumn dtColumn;
            //Create InternationalLicenseID column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "InternationalLicenseID";//Name
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
            //Create LocalLicenseID column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "LocalLicenseID";//Name
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
            DataTable table = _InternationalDrivingLicenseForOneDriver();
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "Select InternationalLicenses.InternationalLicenseID,InternationalLicenses.ApplicationID,LocalLicenseID=InternationalLicenses.IssuedUsingLocalLicenseID ,InternationalLicenses.IssueDate,InternationalLicenses.ExpirationDate,InternationalLicenses.IsActive from InternationalLicenses where InternationalLicenses.DriverID =@PrimaryID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PrimaryID", driverID);
            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return table;
        }
        static public bool LicenseExists(ref int InternationalLicenseID, ref int  ApplicationID, int licenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {

            bool itExists = false;
            SqlConnection connection =new SqlConnection(dataAccessSettings.connectionString);
            string query = "SELECT InternationalLicenseID,ApplicationID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID FROM InternationalLicenses where InternationalLicenses.IssuedUsingLocalLicenseID=@PrimaryID;";
            SqlCommand command =new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PrimaryID",licenseID);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                 InternationalLicenseID =int.Parse( reader ["InternationalLicenseID"].ToString());
               ApplicationID   =int.Parse( reader ["ApplicationID"].ToString());
                IssueDate  =DateTime.Parse( reader ["IssueDate"].ToString());
                 ExpirationDate =DateTime.Parse( reader ["ExpirationDate"].ToString());
                 IsActive =bool.Parse( reader ["IsActive"].ToString());
                 CreatedByUserID =int.Parse( reader ["CreatedByUserID"].ToString());
                    itExists = true;
                }
            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return itExists;


        }

        static public bool GetInternationalLicenseByID( int InternationalLicenseID, ref int ApplicationID,ref int licenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {

            bool itExists = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "SELECT IssuedUsingLocalLicenseID,ApplicationID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID FROM InternationalLicenses where InternationalLicenses.InternationalLicenseID=@PrimaryID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PrimaryID", InternationalLicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    licenseID = int.Parse(reader["IssuedUsingLocalLicenseID"].ToString());
                    ApplicationID = int.Parse(reader["ApplicationID"].ToString());
                    IssueDate = DateTime.Parse(reader["IssueDate"].ToString());
                    ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());
                    IsActive = bool.Parse(reader["IsActive"].ToString());
                    CreatedByUserID = int.Parse(reader["CreatedByUserID"].ToString());
                    itExists = true;
                }
            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return itExists;


        }

        static public int AddNewInternationalLicense(int issuedUsingLocalLicenseID,int driverID , int applicationID,DateTime IssueDate,DateTime ExpirationDate,bool IsActive,int CreatedByUserID)
        {
            int PrimaryID = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "INSERT INTO InternationalLicenses (ApplicationID ,DriverID ,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID) VALUES (@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID ,@IssueDate,@ExpirationDate,@IsActive ,@CreatedByUserID); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@DriverID", driverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try { 
                connection.Open();
                object ID=command.ExecuteScalar();
                if(int.TryParse(ID.ToString(),out int result))
                {
                    PrimaryID=result;
                }
            
            }
            catch (Exception e) { }
            finally { connection.Close(); }





            return PrimaryID;
        }
      static public DataTable  GetAllInternationalLiceneses()
        {
            DataTable table = new DataTable();
            SqlConnection connection =new SqlConnection (dataAccessSettings.connectionString);
            string query = "SELECT InternationalLicenseID,ApplicationID,DriverID,IssuedUsingLocalLicenseID as LocalLicenseID,IssueDate ,ExpirationDate ,CreatedByUserID ,IsActive FROM InternationalLicenses;";
            SqlCommand command =new SqlCommand (query, connection);
            try {
                connection.Open();
            
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e) { }
            finally {connection.Close(); }
            return table;
        }


    }
}
