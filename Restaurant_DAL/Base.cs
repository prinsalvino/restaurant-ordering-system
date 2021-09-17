using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Diagnostics;

namespace Restaurant_DAL
{
    public abstract class Base
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        public Base()
        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["chapeau1819sdb02ConnectionString"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(String query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrorLogging(e);
                throw;
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                ErrorLogging(e);

                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected DataTable ExecuteEditOutputQuery(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
			DataTable dataTable;
			DataSet dataSet = new DataSet();

			try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
                //adapter.SelectCommand = command;
				//adapter.Fill(dataSet);
				dataTable = dataSet.Tables[0];

			}
            catch (SqlException e)
            {
                ErrorLogging(e);
				return null;
                throw;
            }
            finally
            {
                CloseConnection();
            }

			return dataTable;
        }



        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(String query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

			try
			{
				command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
			}
			catch (SqlException e)
			{
			    ErrorLogging(e);
			    return null;
			    throw;
			}
			finally
			{
			    CloseConnection();
			}
			return dataTable;
        }
        private static void ErrorLogging(Exception e)
        {
			Debug.WriteLine("=============Error Logging ===========");
			Debug.WriteLine("===========Start============= " + DateTime.Now);
			Debug.WriteLine("Error Message: " + e.Message);
			Debug.WriteLine("Stack Trace: " + e.StackTrace);
			Debug.WriteLine("===========End============= " + DateTime.Now + "\n");
		}
    }
}
