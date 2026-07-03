using System;
using System.Collections.Generic;
using System.Data;

using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace DataAccessLayer
{
    public static class clsUserTable
    {
        static  private DataTable _CreateUserTable()
        {
            DataTable table=new DataTable();
            DataColumn column;
            //Create the userID column
            column = new DataColumn();
            column.DataType = typeof(int);//type
            column.ColumnName = "UserID";//Name
            column.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            column.ReadOnly = true;
            column.Unique = true;
            column.AllowDBNull = false;
            column.ReadOnly=true;
            table.Columns.Add(column);
            //Create the personID column
            column = new DataColumn();
            column.DataType = typeof(int);//type
            column.ColumnName = "PersonID";//Name
            column.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            column.ReadOnly = true;
            column.Unique = true;
            column.AllowDBNull = false;
            column.ReadOnly = true;
            table.Columns.Add(column);
            //Create the personID column
            column = new DataColumn();
            column.DataType = typeof(string);//type
            column.ColumnName = "FullName";//Name
            column.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            column.ReadOnly = false;
            column.Unique = false;
            column.AllowDBNull = false;
            column.ReadOnly = false;
            table.Columns.Add(column);
            //Create the username column
            column = new DataColumn();
            column.DataType = typeof(string);//type
            column.ColumnName = "Username";//Name
            column.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            column.ReadOnly = false;
            column.Unique = true;
            column.AllowDBNull = false;
            column.ReadOnly = false;
            table.Columns.Add(column);
            //Create the isActive column
            //Create the username column
            column = new DataColumn();
            column.DataType = typeof(bool);//type
            column.ColumnName = "IsActive";//Name
            column.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            column.ReadOnly = false;
            column.Unique = false;
            column.AllowDBNull = false;
            column.ReadOnly = false;
            table.Columns.Add(column);
            return table;

        }
       static public  bool FindUserbyUsernameAndPassword(ref int userID,ref int personID ,string username, string password,ref bool isActive)
        {
           bool isFound = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select * from Users where Users.UserName=@username and Users.Password=@password;";
            SqlCommand command =new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) { 
                isFound = true;
                    userID= Convert.ToInt32(reader["UserID"]);
                    personID = Convert.ToInt32(reader["PersonID"]);
                    isActive = (bool)(reader["IsActive"]);
                
                }

            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return isFound;

        }
       static public bool FindUserbyID(int userID, ref int  personID, ref string username, ref string password, ref  bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select * from Users where Users.UserID=@user";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user", userID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    personID = Convert.ToInt32(reader["PersonID"]);
                    isActive = (bool)(reader["IsActive"]);
                    username =( reader["username"]).ToString();
                    password = (reader["password"]).ToString();

                }

            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return isFound;
        }
        static  public DataTable UserTable()
        {
            //Getting user table from data base that contains userID,personID,full name,username and  the user is Active  or is not 
            DataTable table = _CreateUserTable();
            SqlConnection connection =new SqlConnection(dataAccessSettings.connectionString);
            string query = "select Users.UserID,Users.PersonID,FullName=people.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName,Users.UserName,Users.IsActive from Users inner join People on People.PersonID=Users.PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();


            }
            catch(Exception e) { }
            finally{ connection.Close(); }
            return table;

        }
    
        static public int  AddNewUser(int PersonID, string  username, string  password, bool isActive)
        {
            int userID = -1;
            SqlConnection connection=new SqlConnection(dataAccessSettings.connectionString);

            string query = @"INSERT INTO Users (PersonID,UserName,Password,IsActive)VALUES (@PersonID,@UserName,@Password,@IsActive);SELECT SCOPE_IDENTITY();";
            SqlCommand command =new SqlCommand(query, connection);
            //initialle the values
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);
            try {
                connection.Open();
                object ID=command.ExecuteScalar();
                if(int.TryParse(ID.ToString(), out int result)){
                    userID = result;
                }
            }
            catch(System.Exception e) { }   
            finally { connection.Close(); }
            return userID;



        }

      static public  bool  UpdateUser(int userID,int PersonID, string username, string password, bool isActive)
        {
            int rowsAffected=-1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "UPDATE Users SET PersonID = @PersonID , UserName = @UserName , Password = @Password , IsActive = @IsActive WHERE Users.UserID = @userID ";
            SqlCommand command = new SqlCommand(query, connection);
            //initialle the values
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@userID", userID);
            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (System.Exception e) { }
            finally { connection.Close(); }
            return rowsAffected>0;
        }
   
        static public bool IsUser(int PersonID)
        {
            bool answer=false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "Select answer='Y' from Users  where Users.PersonID= @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            //initialle the values.
            command.Parameters.AddWithValue("@PersonID", PersonID);
            
            try
            {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                answer = reader.HasRows;
                reader.Close();
            }
            catch (System.Exception e) { }
            finally { connection.Close(); }
            return answer ;
        }
        //Create a method to check if a username exists or does not 
        static public bool UsernameExists(string username)
        {
            bool answer = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "Select answer='Y' from Users  where Users.UserName= @username;";
            SqlCommand command = new SqlCommand(query, connection);
            //initialle the values.
            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                answer = reader.HasRows;
                reader.Close();
            }
            catch (System.Exception e) { }
            finally { connection.Close(); }
            return answer;
        }
       static public int GetPersonWithUserID(int userID)
        {
            int personID = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = @"select Users.PersonID from Users where Users.UserID=@userID;";
            SqlCommand command = new SqlCommand(query, connection);
            //initialle the values
            command.Parameters.AddWithValue("@userID", userID);
            
            try
            {
                connection.Open();
                object ID = command.ExecuteScalar();
                if (int.TryParse(ID.ToString(), out int result))
                {
                    personID = result;
                }
            }
            catch (System.Exception e) { }
            finally { connection.Close(); }
            return personID;
        }

        static public bool DeleteUserWithUserID(int userID)
        {
            int rowsAffected = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = @"DELETE FROM Users WHERE Users.UserID=@user";
            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user", userID);
            try {
                connection.Open();
                rowsAffected= command.ExecuteNonQuery();
            }
            catch (System.Exception e) { }
            finally { connection.Close(); }
            return rowsAffected > 0;


        }

    }
}
