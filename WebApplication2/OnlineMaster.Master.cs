using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OnlineMaster : System.Web.UI.MasterPage
    {   
        protected void Page_Load2(object sender, EventArgs e)
        {
            //String ConString = "Server=DESKTOP-GLHDHL3\\SQLEXPRESS;Database=TestDatabase;Connection timeout=5;Integrated Security=SSPI;";
           
            String ConString = "Server=MIRIAM;Database=e_market;Connection timeout=50;Integrated Security=SSPI;";
             String Query = "Select * from dbo.Customers;";

            //online
           // String ConString = "Data Source=mssql6.gear.host;Initial Catalog=gadgetsdb1;Integrated Security=False;user id=emarket;password=Lr38O2TI~67-";
            //String Query = "Select * from dbo.products";

            using (SqlConnection conn = new SqlConnection(ConString))
            {
                try
                {
                    conn.Open();
                    // Console.WriteLine("Opened Connection");
                }
                catch (Exception ex)
                {
                    //  Console.WriteLine(ex.ToString());
                    Console.ReadKey();

                    return;
                }
                SqlCommand command = new SqlCommand(Query, conn);

                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        // Console.WriteLine(reader[1] + " " + reader[2]);

                        //string tohtml = reader[1];
                        // test4.InnerHtml = tohtml;
                 // form1.InnerHtml= (reader[1].ToString() + reader[2].ToString() + reader[3].ToString());
                        test4.InnerHtml = (reader[1].ToString() + reader[2].ToString() + reader[3].ToString());
                        // test4.InnerHtml = tohtml;
                        //test4.InnerHtml = ("get ready");

                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                    // Console.ReadKey();
                }

            }//end of uing

        }
    }
}