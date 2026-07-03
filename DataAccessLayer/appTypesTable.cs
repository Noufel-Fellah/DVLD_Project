using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class appTypesTable
    {
        static private DataTable _CreateAppTypesTable()
        {
            DataTable table = new DataTable();
            DataColumn dtColumn;
            //Create appTypeID
            dtColumn=new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "ApplicationTypeID";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create appTypeID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "ApplicationTypeTitle";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create 
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(float);//type
            dtColumn.ColumnName = "ApplicationFees";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table

            return table;
        }
        static public DataTable GetAllAppTypes()
        {
            DataTable table =_CreateAppTypesTable() ;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select *from ApplicationTypes;";
            SqlCommand command=new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) {
                    table.Load(reader);
                
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return table;
        }
    
        static public bool FindApp(int appTypeID,  ref string appTypeTitle, ref float appTypeFees)
        {

            bool answer=false;
            
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            
            string query = "select * from ApplicationTypes  where ApplicationTypes.ApplicationTypeID=@ID;";

            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID",appTypeID);
            try {
            connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    appTypeTitle = reader["ApplicationTypeTitle"].ToString();
                    appTypeFees = float.Parse(reader["ApplicationFees"].ToString());
                    answer= true;
                }
            
            }
            catch (Exception ex) { }
            finally{ connection.Close(); }
            return answer;
        }

        static public bool SaveChanges(int  appTypeID, string appTypeTitle, float appTypeFees )
        {

            int rowsAffcted = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "UPDATE ApplicationTypes  SET ApplicationTypeTitle = @ApplicationTypeTitle , ApplicationFees = @ApplicationFees  WHERE ApplicationTypes.ApplicationTypeID=@ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", appTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", appTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", appTypeFees);

            try
            {
                connection.Open();
                rowsAffcted= command.ExecuteNonQuery();               

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffcted>0;



        }









    }
}
