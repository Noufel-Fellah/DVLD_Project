using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    public static class clsPeopleTable
    {
        private static DataTable _CreatePeopleTable()
        {
            DataTable dtPeopleTable = new DataTable();
            DataColumn dtColumn;//declare the variable
            //Create PersonID column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "PersonID";//Name
            dtColumn.AutoIncrement = true;//auto number we usually use it in Primary key attribute
            dtColumn.AutoIncrementSeed = 1;//which number the auroIncrmenet starts from
            dtColumn.AutoIncrementStep = 1;//The number of increment between two consecutive values

            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);//Adding The above column to a data table
            //create NationalNo
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "NationalNo";//Name
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //create FirstName
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "FirstName";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create SecondName

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "SecondName";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create ThirdName
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "ThirdName";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create LastName
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "LastName";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create dateOfBirth
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);//type
            dtColumn.ColumnName = "DateOfBirth";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create Gender
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "Gender";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create Address
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "Address";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create Phone
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "Phone";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create Email
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "Email";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.AllowDBNull = true;
            dtPeopleTable.Columns.Add(dtColumn);
            //Create Nationality
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "CountryName";//Name
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.AllowDBNull = false;
            dtPeopleTable.Columns.Add(dtColumn);
            return dtPeopleTable;
        }
        public static DataTable GetPeopleTable()
        {
            //This function imports all rows of People table from DVLD database.
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "SELECT People.PersonID,People.NationalNo,People.FirstName,People.SecondName,People.ThirdName,People.LastName ,People.DateOfBirth,Gender=\r\nCASE\r\n    WHEN People.Gendor=0 THEN 'male'\r\n    WHEN People.Gendor=1 THEN 'female'\r\n   \r\nEND\r\n,Address,Phone,Email,Countries.CountryName  FROM People inner join Countries on People.NationalityCountryID=Countries.CountryID;";
            SqlCommand command=new SqlCommand(query, connection);
            DataTable dtPeopleTable= _CreatePeopleTable();
            
            
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows) {
                    dtPeopleTable.Load(reader);
                
                }
                reader.Close();
            }
           
            catch (Exception e){ 
            
            }
           
            finally { connection.Close(); }

            return dtPeopleTable;

        }
        public static bool DoesNationalNumExist(string nationalNum)
        {
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = @"Select A='Y' from People  where People.NationalNo=@nationalNum;";
            SqlCommand command = new SqlCommand(query,connection);
            object result=null;
            command.Parameters.AddWithValue("@nationalNum",nationalNum);

            try {
                connection.Open();
                 result= command.ExecuteScalar();


            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return result != null;
        }
        public static bool PersonWithThisIDExist( int personID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string Gender, ref string Address, ref DateTime DateOfBirth, ref string Phone, ref string Email, ref string NationalityCountryID, ref string ImagePath)
        {
            SqlConnection connection=new SqlConnection(dataAccessSettings.connectionString);
            string query = "SELECT People.PersonID,People.NationalNo,People.FirstName,People.SecondName,People.ThirdName,People.LastName ,People.DateOfBirth,Gender= CASE   WHEN People.Gendor=0 THEN 'male'  WHEN People.Gendor=1 THEN 'female' END,Address,Phone,Email,Countries.CountryName,ImagePath  from People inner join Countries on  People.NationalityCountryID=Countries.CountryID where People.PersonID=@PersonID; ";
            SqlCommand command = new SqlCommand(query,connection);
            bool Exist = false;
            command.Parameters.AddWithValue("@PersonID",personID);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Exist = true;
                    NationalNo=reader["NationalNo"].ToString();
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName = reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();
                  DateTime.TryParse( reader["DateOfBirth"].ToString(),out DateOfBirth);
                    Gender = reader["Gender"].ToString();
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();
                    Email = (reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "");
                    NationalityCountryID = reader["CountryName"].ToString();
                    ImagePath = (reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : "");





                }

                reader.Close();



            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return Exist;
        }

        public static bool PersonWithThisNationalNumExist(ref int personID,  string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string Gender, ref string Address, ref DateTime DateOfBirth, ref string Phone, ref string Email, ref string NationalityCountryID, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "SELECT People.PersonID,People.FirstName,People.SecondName,People.ThirdName,People.LastName ,People.DateOfBirth,Gender= CASE   WHEN People.Gendor=0 THEN 'male'  WHEN People.Gendor=1 THEN 'female' END,Address,Phone,Email,Countries.CountryName,ImagePath  from People inner join Countries on  People.NationalityCountryID=Countries.CountryID where  People.NationalNo=@NationalNum; ";
            SqlCommand command = new SqlCommand(query, connection);
            bool Exist = false;
            command.Parameters.AddWithValue("@NationalNum", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Exist = true;
                    //NationalNo = reader["NationalNo"].ToString();
                    personID = int.Parse( reader["PersonID"].ToString());
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName = reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();
                    DateTime.TryParse(reader["DateOfBirth"].ToString(), out DateOfBirth);
                    Gender = reader["Gender"].ToString();
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();
                    Email = (reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "");
                    NationalityCountryID = reader["CountryName"].ToString();
                    ImagePath = (reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : "");





                }

                reader.Close();



            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return Exist;
        }
        public static int AddNewPerson ( string NationalNo,  string FirstName,  string SecondName,  string ThirdName,  string LastName,  string Gender,  string Address,  DateTime DateOfBirth,  string Phone,  string Email,  string Country,  string ImagePath)
        {
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath,Gender)VALUES(@NationalNo,@FirstName, @SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath,@Gender);SELECT SCOPE_IDENTITY();";
            int CountryID = 0, PersonID=-1;//the -1 to match the add mode in clsPerson.
            SqlCommand command=new SqlCommand(query, connection);
           //Start filling commands
            //Fill GetCountryIDQuery command
            //Fill addNewPerson command
            command.Parameters.AddWithValue("@NationalNo",NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            //Third name accepts null value
            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }else { command.Parameters.AddWithValue("@ThirdName", DBNull.Value); }
                
            command.Parameters.AddWithValue("@LastName", NationalNo);
            if (!_GetPrimaryKeyOFCountry(Country,ref  CountryID)) { return -1; }
            command.Parameters.AddWithValue("@NationalityCountryID", CountryID);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            //1->female,0->male
            if (Gender == "male")
            {
                command.Parameters.AddWithValue("@Gendor", 0);
            }else command.Parameters.AddWithValue("@Gendor", 1);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            //Email field accepts null value.
            if(Email!="")command.Parameters.AddWithValue("@Email", NationalNo);
            else command.Parameters.AddWithValue("@Email", DBNull.Value);
           
            
           if(ImagePath!="") command.Parameters.AddWithValue("@ImagePath", ImagePath);
           else command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            if (Gender == "male")
            {
                command.Parameters.AddWithValue("@Gender", "M");
            }
            else command.Parameters.AddWithValue("@Gender", "W");
         
            //End
            try
            {
                connection.Open();
              
              

                object ID = command.ExecuteScalar();
                int.TryParse(ID.ToString(), out  PersonID);

                



            }
            catch (Exception e) { }
            finally { connection.Close(); }
            return PersonID;
        }
       

       private static bool  _GetPrimaryKeyOFCountry(string Country,ref  int  CountryID )
        {
            bool countryExist = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string GetCountryIDQuery = "select Countries.CountryID from Countries where Countries.CountryName=@CountryName";
            SqlCommand cmdGetCountryID = new SqlCommand(GetCountryIDQuery, connection);
            cmdGetCountryID.Parameters.AddWithValue("@CountryName", Country);


            try
            {
                connection.Open();
                SqlDataReader reader = cmdGetCountryID.ExecuteReader();

                if (reader.Read())
                {
                    CountryID = int.Parse(reader["CountryID"].ToString());
                    countryExist = true;
                }
                reader.Close();
            }
            catch (Exception e) { }
            finally {connection.Close(); }
            return   countryExist;
        }
        public static bool UpdatePerson(int personID,  string NationalNo,  string FirstName,  string SecondName,  string ThirdName,  string LastName,  string Gender,  string Address,  DateTime DateOfBirth,  string Phone,  string Email,  string NationalityCountryID,  string ImagePath)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "UPDATE People   SET NationalNo = @NationalNo ,FirstName = @FirstName , SecondName= @SecondName ,  ThirdName= @ThirdName , LastName= @LastName , DateOfBirth= @DateOfBirth  , Gendor = @Gendor , Address= @Address, Phone = @Phone , Email = @Email      , NationalityCountryID = @Country , ImagePath = @ImagePath , Gender  = @Gender WHERE  PersonID= @ID; ";

            SqlCommand command=new SqlCommand(query, connection);
            //Fill the query.
            command.Parameters.AddWithValue("@NationalNo",NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "") { command.Parameters.AddWithValue("@ThirdName", ThirdName); }
            else { command.Parameters.AddWithValue("@ThirdName", DBNull.Value); }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            if (Gender == "male") { command.Parameters.AddWithValue("@Gendor", 0); }
            else { command.Parameters.AddWithValue("@Gendor", 1); }
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email ", Email);
            }
            else { command.Parameters.AddWithValue("@Email ", DBNull.Value); }
                //Get the primary key of country
                int country = 0;
            if (!_GetPrimaryKeyOFCountry(NationalityCountryID, ref country)) return false;
            command.Parameters.AddWithValue("@Country", country);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            if (Gender == "male")
            {
                command.Parameters.AddWithValue("@Gender", "M");
            }
            else
            {
                command.Parameters.AddWithValue("@Gender", "W");
            }
            command.Parameters.AddWithValue("@ID", personID);
            try
            {
                connection.Open();
                rowAffected=command.ExecuteNonQuery();

            }
           catch(Exception e) { }
            finally { connection.Close(); }


            return rowAffected > 0;



        }


        public static bool DeletePerson(int personID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "DELETE FROM People WHERE People.PersonID=@ID;";
            SqlCommand command=new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", personID);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();

            }catch(Exception e) { }
            finally{ connection.Close(); }

            return rowAffected > 0;

        }





    }

}

