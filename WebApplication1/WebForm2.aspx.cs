using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    { public int productid;
        public string Price;
        protected void Page_Load(object sender, EventArgs e)
        {        
            StringBuilder table = new StringBuilder();
            string RequestQueryString = Request.QueryString["Id"];
          
            string salquery = "SELECT * FROM Products where ProductId  =@ProductId";
            using (SqlDataReader f = SQLhelper.ExecuteQuery(salquery, CommandType.Text, new SqlParameter(parameterName: "@ProductId", value: (RequestQueryString))))
            {
               string x  = (string)Session[name: "s"];
                //table.Append(value: "< div >x</ div >");
                string twenty = string.Empty;
                table.Append("<table border='1'>");
                table.Append("<tr><th>ID</th><th>phone</th><th>Description</th><th>price</th><th>stock</th></tr>");
                var sql = "<h1> ";
                while (f.Read())
                {
                if (f[5].ToString() != string.Empty)
                {
                    table.Replace("<tr><th>ID</th><th>phone</th><th>Description</th><th>price</th><th>stock</th></tr>", "<tr><th>ID</th><th>phone</th><th>Description</th><th>price</th><th>stock</th><th>image</th></tr>");

                }
                    productid = (int)f[0];
                    Price = f[2].ToString();
                    table.Append("<tr>");
                    table.Append("<td>" + f[0] + "</td>");
                    table.Append("<td>" + f[1] + "</td>");
                    table.Append("<td>" + f[2] + "</td>");
                    table.Append("<td>" + f[3] + "</td>");
                    table.Append("<td>" + f[4] + "</td>");
                  if(f[5].ToString()!=string.Empty)
                    {

                        table.Append("<td>" + f[5] + "</td>");

                        Image1.ImageUrl = f[5].ToString();
                       

                     //twenty = " <table border='1'> < asp:Image id = \"Image1\" runat=\"server\" ImageUrl = \"~" + f[5] + " \"/></table>";
                    }//AlternateText = "Image text"ImageAlign = "left"+" < img src =\"" + f[5].ToString() +"\" width=100  />"
                    table.Append("</tr>");
                
                 //   sql += (f[0].ToString() +" "+ f[1].ToString() +" "+ f[2].ToString() +" "+ "</h1>");
                     
                }
                table.Append("</table>");
                PlaceHolder2.Controls.Add(new Literal { Text = table.ToString()  });
              PlaceHolder2.Controls.Add(new Literal {Text=twenty });
               // PlaceHolder2.Controls.Add(new Literal { Text = sql.ToString() });
            }



        }
              public void Button2_Click(object sender, EventArgs e)
        {
                List<Purchase> shoppingcart = new List<Purchase>();
            string name = (string)Session["s"];
            if (name!=null)
            {
                 if (Session["cart"] == null)
            {//int.Parse(Quantity.Text), double.Parse(price),  name)productid,1, double.Parse(Price),  name
                    
                shoppingcart.Add(new Purchase(  productid, 1));
                    Session.Add("cart", shoppingcart);
                }
                else
                {
                    shoppingcart = (List<Purchase>)Session["cart"];
                    shoppingcart.Add(new Purchase(productid, 1));
                    Session["cart"] = shoppingcart;
                }
            }
            else
            {//if the user did not log in and wants to add an item it redirects to the login page
                Session["ProductId"] = productid;
                Session["BackToCart"]="true";
                Button3.Visible = true;
                Message.Visible = true;
                Message.InnerText = " Please Log In To Load \n     The Cart";
               
            }
               
            
        }
    }
}
    