using System;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsDriversTable
    {
        static public bool DriverExistsByPersonID(int personID,ref int driverID,ref int createdByUserID,ref DateTime createdDate)
        {
       
            bool answer = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select DriverID,CreatedByUserID,CreatedDate from Drivers  where Drivers.PersonID =   @personID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    driverID = int.Parse(reader["DriverID"].ToString());
                    createdByUserID = int.Parse(reader["CreatedByUserID"].ToString());
                    createdDate = DateTime.Parse(reader["CreatedDate"].ToString()) ;
                    answer = true;
                }
                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return answer;
        }
        static public int AddRowInDriversTable(int personID,  int createdByUserID,  DateTime createdDate)
        {
            int ID=-1;
            SqlConnection connection =new SqlConnection(dataAccessSettings.connectionString);
            string query = "INSERT INTO Drivers(PersonID,CreatedByUserID,CreatedDate)VALUES (@PersonID, @CreatedByUserID, @CreatedDate); SELECT SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@CreatedDate", createdDate);
            try { 
                    connection.Open();
                    object returnedValue=command.ExecuteScalar();
                    if(int.TryParse(returnedValue.ToString(), out int result))
                {
                     ID=result;
                }
            
            }
            catch(Exception ex) { }
            finally { connection.Close(); }
            return ID;


        }

      static public bool  GetDriverByDriverID(int driverID,  ref int personID, ref int createdByUserID, ref DateTime createdDate)
        {
            bool answer = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select Drivers.PersonID,Drivers.CreatedByUserID,Drivers.CreatedDate  from Drivers where DriverID=@ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", driverID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                     personID= int.Parse(reader["PersonID"].ToString());
                    createdByUserID = int.Parse(reader["CreatedByUserID"].ToString());
                    createdDate = DateTime.Parse(reader["CreatedDate"].ToString());
                    answer = true;
                }
                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return answer;





        }






    }
}
