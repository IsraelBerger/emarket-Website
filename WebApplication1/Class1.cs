using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace WebApplication1
{
    public class SQLhelper
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GearHostSqlServer"].ConnectionString);
        public static SqlDataReader ExecuteQuery(String query, CommandType commandType = CommandType.Text, params SqlParameter[] sqlParams)

        {   // SqlConnection conn = new SqlConnection(con);

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(sqlParams);


                con.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                // IDataReader is closed.
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
                return reader; //must be closed7

            }
        }


        public static SqlDataReader ExecuteQuery2(String query, CommandType commandType = CommandType.Text, params SqlParameter[] sqlParams)
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(sqlParams);


                con.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                // IDataReader is closed.

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //cmd.ExecuteNonQuery();
                con.Close();
                return reader;
            }
        }

        
    }
public class Purchase
        {
            int productid;
            int quantity;
            double price;
            public int Productid { get { return productid; } set { productid = value; } }
            public int Quantity { get { return quantity; } set { quantity = value; } }
           // public double Price { get { return price; } set { price = value; } }
            public Purchase(int productid, int quantity)
            {
                this.productid = productid;
                this.quantity = quantity;
           // this.price = Price;
            }
        }
}