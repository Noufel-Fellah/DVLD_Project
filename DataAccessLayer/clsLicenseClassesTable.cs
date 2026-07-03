using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsLicenseClassesTable
    {
        static private DataTable _CreateLicenseClassesTable()
        {
            DataTable table = new DataTable();
            DataColumn dtColumn;//declare the variable
            //Create LicenseClassesID column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "LicenseClassesID";//Name
           
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create ClassName column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "ClassName";//Name

            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create ClassDescription column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "ClassDescription";//Name

            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table

            //Create MinimumAllowedAge column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "MinimumAllowedAge";//Name

            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create DefaultValidityLength column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "DefaultValidityLength";//Name

            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create ClassFees column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(float);//type
            dtColumn.ColumnName = "ClassFees";//Name

            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table

            return table;


        }
        static public bool  GetDrivingClass(ref int LicenseClassesID,ref string ClassName,ref string ClassDescription,ref int MinimumAllowedAge,ref int DefaultValidityLength,ref float ClassFees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "Select * from LicenseClasses  where LicenseClasses.LicenseClassID=@ID or LicenseClasses.ClassName=@ClassName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", LicenseClassesID);
            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
            
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {

                    LicenseClassesID = int.Parse(reader["LicenseClassID"].ToString());
                    ClassName = reader["ClassName"].ToString();
                    ClassDescription = reader["ClassDescription"].ToString();
                    MinimumAllowedAge =int.Parse( reader["MinimumAllowedAge"].ToString());
                    DefaultValidityLength =int.Parse( reader["DefaultValidityLength"].ToString());
                    ClassFees =float.Parse( reader["ClassFees"].ToString());
                    isFound = true;


                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;

        }


        static public List<string> GetAllClasses()
        {
            List <string> lsClasses=new List<string>();

            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "Select LicenseClasses.ClassName from LicenseClasses;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    lsClasses.Add(reader["ClassName"].ToString());



                }

            }
            catch (Exception ex) { lsClasses = null; }
            finally { connection.Close(); }

            return lsClasses;


        }









    }
}
