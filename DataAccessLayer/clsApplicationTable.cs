using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public  class clsApplicationTable
    {

      static public bool FindAppointmentWithID(int appointmentID,ref int typeID,ref int LDLAID,ref DateTime AppointmentDate,ref float AppointmentFees,ref bool isLocked,ref int CreatorID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select * from TestAppointments where TestAppointmentID=@ID;";
            SqlCommand command =new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@ID", appointmentID);
            try {

                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.Read()) {

                    typeID = int.Parse(reader["TestTypeID"].ToString());
                    LDLAID = int.Parse(reader["LocalDrivingLicenseApplicationID"].ToString());
                    AppointmentDate = DateTime.Parse(reader["AppointmentDate"].ToString());
                    AppointmentFees = float.Parse(reader["PaidFees"].ToString());
                   CreatorID=int.Parse( reader["CreatedByUserID"].ToString());
                   isLocked=bool.Parse( reader["IsLocked"].ToString());
                    isFound=true;

                }
            
            
            }
            catch(Exception e) { }
            finally { connection.Close(); }
            return isFound;
        }
        static public bool ApplicationExists(int PersonID, int apptype, int licenseClassID, int appStatus, DateTime appDate)
        {
            bool answer = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "Select answer='Y' from Applications inner join LocalDrivingLicenseApplications  on Applications.ApplicationID=LocalDrivingLicenseApplications.ApplicationID where Applications.ApplicantPersonID = @personID and Applications.ApplicationStatus = @status and    Applications.ApplicationTypeID =  @appType and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID and Applications.ApplicationDate=@Date; ";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@personID", PersonID);
            command.Parameters.AddWithValue("@status", appStatus);
            command.Parameters.AddWithValue("@appType", apptype);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
            command.Parameters.AddWithValue("@Date", appDate);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) answer = true;

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return answer;


        }

        static public int AddNewApplication(int ApplicantPersonID,DateTime ApplicationDate,int ApplicationTypeID,int ApplicationStatus,DateTime LastStatusDate,float PaidFees,int CreatedByUserID)
        {
            int ApplicationID=-1;
            SqlConnection connection=new SqlConnection(dataAccessSettings.connectionString);
            string query = "INSERT INTO Applications(ApplicantPersonID,ApplicationDate, ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID) VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);SELECT SCOPE_IDENTITY();";
            SqlCommand command =new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID",ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try {
                connection.Open();
                object result= command.ExecuteScalar();
                if(int.TryParse(result.ToString(),out int ID))
                {
                    ApplicationID= ID;
                }
            
            
            
            }
            catch(Exception e) { }
            finally { connection.Close(); }
            return ApplicationID;





        }
        static public bool GetApplicationWithLicenseClassType(int appID, ref int ApplicantPersonID, ref DateTime ApplicationDate,   int ApplicationTypeID, ref int ApplicationStatus, ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select ApplicantPersonID,ApplicationDate,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID from Applications where ApplicationID=@ID and ApplicationTypeID= @appTypeID ;";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", appID);
            command.Parameters.AddWithValue("@appTypeID", ApplicationTypeID);
            try {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    ApplicantPersonID =  int.Parse( reader["ApplicantPersonID"].ToString());
                    ApplicationDate = DateTime.Parse( reader["ApplicationDate"].ToString());
                ApplicationStatus = int.Parse( reader["ApplicationStatus"].ToString());
                 LastStatusDate = DateTime.Parse( reader["LastStatusDate"].ToString());
                 PaidFees= float.Parse( reader["PaidFees"].ToString());
                 CreatedByUserID=   int.Parse(reader["CreatedByUserID"].ToString());

                    isFound = true;

                }
                reader.Close();
            
            }
            catch (Exception e) { }
            finally{ connection.Close(); }
            return isFound;


        }
        
        static public bool UpdateApplication(int  ApplicationsID,  int ApplicationStatus, DateTime lastStatusDate)
        {
            int affectedRow = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "UPDATE Applications SET ApplicationStatus = @ApplicationStatus, LastStatusDate = @LastStatusDate WHERE Applications.ApplicationID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ApplicationsID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            try
            {
                connection.Open();
                affectedRow= command.ExecuteNonQuery();
            }catch (Exception e) { }
            finally { connection.Close(); }
            return affectedRow >0;







        }
   
        static public bool GetApplicationWithID(int appID, ref int  ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool itExists = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "SELECT ApplicantPersonID,ApplicationDate,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID,ApplicationTypeID FROM Applications where ApplicationID=@ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", appID);
            try {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    
                    ApplicantPersonID = int.Parse(reader["ApplicantPersonID"].ToString());
              ApplicationDate   =  DateTime.Parse(reader ["ApplicationDate"]  .ToString());
               ApplicationStatus  = int.Parse (reader ["ApplicationStatus"].ToString());
                LastStatusDate = DateTime.Parse(reader ["LastStatusDate"].ToString());
                PaidFees = float.Parse (reader ["PaidFees"].ToString());
                 CreatedByUserID = int.Parse(reader ["CreatedByUserID"]  .ToString());
                ApplicationTypeID = int.Parse(reader ["ApplicationTypeID"].ToString());
                    itExists = true;


                }
            
            
            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return itExists;
        }

        static public bool DeleteApplicationRow(int applicationID)
        {


            int rowsAffected = -1;

            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "DELETE FROM Applications  WHERE Applications.ApplicationID=@ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", applicationID);
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
