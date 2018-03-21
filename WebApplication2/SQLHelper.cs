using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2
{
  
        public static class SQLHelper
        {
            //"GearHostSqlServer";
            //"LocalSqlServer";
            //based on https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand(v=vs.110).aspx

            private static String ConnString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MIRIAM"].ConnectionString;

            public static SqlDataReader ExecuteQuery(String query, CommandType commandType = CommandType.Text, params SqlParameter[] sqlParams)
            {
                SqlConnection conn = new SqlConnection(ConnString);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(sqlParams);

                    conn.Open();
                    // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                    // IDataReader is closed.
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    return reader; //must be closed
                }
            }

        }
    }