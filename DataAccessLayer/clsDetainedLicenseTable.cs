using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public  class clsDetainedLicenseTable
    {
        static private DataTable InitialleAllDetainedLicenses()
        {
   
            DataTable table=new DataTable();
            DataColumn dtColumn;
            //DetainID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "DetainID";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //LicenseID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "LicenseID";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //DetainDate
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);//type
            dtColumn.ColumnName = "DetainDate";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //IsReleased
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(bool);//type
            dtColumn.ColumnName = "IsReleased";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //FineFees
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(float);//type
            dtColumn.ColumnName = "FineFees";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //ReleaseDate
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);//type
            dtColumn.ColumnName = "ReleaseDate";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //FullName
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "FullName";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //NationalNo
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "NationalNo";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //ReleaseApplicationID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "ReleaseApplicationID";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            return table;
        }
        static   public bool IsLicenseDetained(int licenseID)
        {
            bool answer=false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = @"Select ANSWER='Y' from DetainedLicenses
                                where DetainedLicenses.LicenseID=@ID and DetainedLicenses.IsReleased=0;";
            SqlCommand command = new SqlCommand (query,connection);
            command.Parameters.AddWithValue("@ID",licenseID);
            try { 
            
                connection.Open ();
                SqlDataReader reader= command.ExecuteReader();
                answer = reader.HasRows;
                reader.Close ();
            }
            catch(Exception   ex) { }
            finally {connection.Close(); }  

            return answer;
        }
        static public bool  GetDetainedLicenseByLicenseID(ref int  DetainID, int licenseID,ref DateTime  DetainDate,ref float  FineFees,ref int CreatedByUserID,ref bool IsReleased,ref DateTime ReleaseDate,ref int ReleasedByUserID,ref int ReleaseApplicationID)
        {
            bool answer = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = @"SELECT DetainID,DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID FROM DetainedLicenses
                            where DetainedLicenses.LicenseID=@ID  and IsReleased=0;";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            try { 
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.Read())
                {
                    
                    DetainID =int.Parse( reader["DetainID"].ToString());
                    DetainDate=DateTime.Parse( reader["DetainDate"].ToString());
                    FineFees =float.Parse( reader["FineFees"].ToString());
                    CreatedByUserID =int.Parse( reader["CreatedByUserID"].ToString());
                    IsReleased = false;
                    ReleaseDate =( reader["ReleaseDate"]!=DBNull.Value?DateTime.Parse(reader["ReleaseDate"].ToString()) : DateTime.MinValue);
                    ReleasedByUserID = (reader["ReleasedByUserID"] != DBNull.Value ? int.Parse(reader["ReleasedByUserID"].ToString()) : -1);
                    ReleaseApplicationID = (reader["ReleaseApplicationID"] != DBNull.Value ? int.Parse(reader["ReleaseApplicationID"].ToString()) : -1);
                    answer = true; 
                }
            reader.Close ();
            
            }
            catch(Exception ex) { }
            finally {connection.Close(); }
            return answer;


        
        }
        static public bool UpdateDetainedLicenseRow(int detainID, DateTime ReleaseDate, int  ReleasedByUserID, int ReleaseApplicationID)
        {
           int  rowsAffcted = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = @"UPDATE DetainedLicenses
                             SET 
                                IsReleased = 1,
                                ReleaseDate = @ReleaseDate,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID
                                WHERE DetainedLicenses.DetainID=@ID;";

            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ID", detainID);
            try
            {
                connection.Open();
                rowsAffcted = command.ExecuteNonQuery();
            }catch(Exception ex) { }   
            finally {connection.Close(); }
            return rowsAffcted > 0;



        }

        static public int    ADDNewDetainedLicense(int LicenseID, DateTime DetainDate,float FineFees,int CreatedByUserID)
        {
            int detainedLicenseID = -1;
            SqlConnection connection =new SqlConnection(dataAccessSettings.connectionString);
            string query = @"INSERT INTO DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID) VALUES (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID);
                                        SELECT SCOPE_IDENTITY();";
            SqlCommand command= new SqlCommand (query,connection);
            command.Parameters.AddWithValue("@LicenseID",LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", 0);
            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            try
            {
                connection.Open ();
                object result= command.ExecuteScalar();
                if(int.TryParse(result.ToString(), out int ID)){
                    detainedLicenseID = ID;
                }
            }catch(Exception ex) { }
            finally {connection.Close(); }
            return detainedLicenseID;



        }
        static public DataTable GetAllDetainedLicenses()
        {
            DataTable table =InitialleAllDetainedLicenses() ;
            SqlConnection connection =new SqlConnection (dataAccessSettings.connectionString);
            string query = @"Select   DetainedLicenses.DetainID,DetainedLicenses.LicenseID,DetainedLicenses.DetainDate,DetainedLicenses.IsReleased,
                                DetainedLicenses.FineFees,DetainedLicenses.ReleaseDate,vwDrivers.FullName,vwDrivers.NationalNo,DetainedLicenses.ReleaseApplicationID
                                from Licenses inner join vwDrivers on Licenses.DriverID=vwDrivers.DriverID
                                inner join DetainedLicenses on DetainedLicenses.LicenseID=Licenses.LicenseID;";
           
            SqlCommand command = new SqlCommand (query,connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally {  connection.Close(); }

            return table;
        }
    }
}
