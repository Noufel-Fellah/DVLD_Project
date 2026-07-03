using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDetainedLicenses
    {
        static public bool IsLicenseDentained(int licenseID)
        {
            bool answer = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select answer='Y' from DetainedLicenses where LicenseID=@ID and IsReleased =0;";
            SqlCommand command = new SqlCommand(query,connection) ;
            command.Parameters.AddWithValue("@ID", licenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                answer = (result !=null);

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return answer;


        }
    }
}
