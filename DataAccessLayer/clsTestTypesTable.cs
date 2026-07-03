using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsTestTypesTable
    {

        static private DataTable _CreateTestTypesTable()
        {
            DataTable table = new DataTable();
            DataColumn dtColumn;
            //Create TestTypeID
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);//type
            dtColumn.ColumnName = "TestTypeID";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create TestTypeTitle
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "TestTypeTitle";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create TestTypeDescription
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);//type
            dtColumn.ColumnName = "TestTypeDescription";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table
            //Create TestTypeFees
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(float);//type
            dtColumn.ColumnName = "TestTypeFees";//Name
            dtColumn.AutoIncrement = false;//auto number we usually use it in Primary key attribute
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            table.Columns.Add(dtColumn);//Adding The above column to a data table

            return table;
        }
        static public DataTable GetAllTestTypes()
        {
            DataTable table = _CreateTestTypesTable();
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);
            string query = "select * from TestTypes ;";
            SqlCommand command = new SqlCommand(query, connection);
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
            finally { connection.Close(); }
            return table;
        }


        static  public bool FindTest(int testTypeID, ref string  TestTypeTitle, ref string TestTypeDescription, ref float TestTypeFees)
        {
            bool answer = false;

            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "select * from TestTypes where TestTypes.TestTypeID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", testTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TestTypeTitle = reader["TestTypeTitle"].ToString();
                    TestTypeDescription = reader["TestTypeDescription"].ToString();

                    TestTypeFees = float.Parse(reader["TestTypeFees"].ToString());

                    answer = true;
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return answer;
        }

        static public bool Save(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
        {
            int rowsAffcted = -1;
            SqlConnection connection = new SqlConnection(dataAccessSettings.connectionString);

            string query = "UPDATE TestTypes SET TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription, TestTypeFees = @TestTypeFees WHERE TestTypes.TestTypeID=@ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);


            try
            {
                connection.Open();
                rowsAffcted = command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return rowsAffcted > 0;
        }








    }
}
