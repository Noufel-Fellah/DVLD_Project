using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public  static class clsCountryTable
    {
        static public List<string> GetAllCountries()
        {
            List<string> ltCountries = new List<string>();
            SqlConnection connection=new SqlConnection(dataAccessSettings.connectionString);
            string query = "Select  countryName from Countries";
            SqlCommand command=new SqlCommand (query, connection);
            try {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                while (reader.Read()) {
                    ltCountries.Add(reader["CountryName"].ToString());
                }
            reader.Close();
            }
            catch ( Exception e) { }
            finally {  connection.Close(); }
            return ltCountries;
        }
        
    }
}
