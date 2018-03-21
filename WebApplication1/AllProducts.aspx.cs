using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection h = new SqlConnection(ConfigurationManager.ConnectionStrings["GearHostSqlServer"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            h.Open();
                 SqlDataAdapter j = new SqlDataAdapter("SELECT * FROM Products where ProductId = ProductId ",h);
            j.SelectCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
            j.Fill(dt);
            h.Close();
                   grid.DataSource =  dt  ;
                    grid.DataBind();



            StringBuilder table = new StringBuilder();


            string salquery = "SELECT * FROM Products where ProductId=ProductId ";
            using (SqlDataReader f = SQLhelper.ExecuteQuery(salquery))
            {
                string x = (string)Session["s"];
                table.Append("<div id=\"Div1\" runat=\"server\"  style=\"color: #33CC33; background-color: violet\">" + "enjoy browsing " + x);
                table.Append("<table border='1' bgcolor=\" #00ffff\" >");
                table.Append("<tr><th>ID</th><th>phone</th><th>Description</th><th>price</th><th>stock</th>");
                table.Append("</tr>");

                var sql = "<h1> ";
                while (f.Read())
                {
                    table.Append("<tr>");
                    table.Append("<td>" + f[0] + "</td>");
                    table.Append("<td>" + f[1] + "</td>");
                    table.Append("<td>" + f[2] + "</td>");
                    table.Append("<td>" + f[3] + "</td>");
                    table.Append("<td>" + f[4] + "</td>");

                    table.Append("</tr>");

                    sql += (f[0].ToString() + " " + f[1].ToString() + " " + f[2].ToString() + " " + "</h1>");

                }
                table.Append("</table></ div >");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
      
            }



        }

    }
        }
