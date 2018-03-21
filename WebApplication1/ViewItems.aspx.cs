using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;



namespace WebApplication1
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = (string)(Session["s"]);
            if (Session["s"] == null)
            {
                Label1.Text = "hello your not logged in";

            }
            else
            {
                Label1.Text = "Hello " + a+"You are logged in";
                LogIn.Enabled = false;
                LogIn.Visible = false;
            }

        }



        protected void LogIn_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //protected void LinkButton1_Click(object sender, EventArgs e)
        //{

        //}

        protected void Veiw_Click(object sender, EventArgs e)
        {

            using (SqlDataReader k = SQLhelper.ExecuteQuery("SELECT [Id],[CatagoryName] FROM [dbo].[ Catagory]"))
            {
                string test = " ";
                string txt2 = (string)Session["s"];
                while (k.Read())
                {
                    test += $"<div runat=\"server\" style=\"background-color:cadetblue\">" +
                   $"<a href=WebForm3.aspx?id=" + k["Id"] + " ><big>" + k["CatagoryName"] + "</big></a><br>" +
                     $"<div/>";
                    if (HttpContext.Current.Session["s"] != null)
                    {
                        Div2.InnerHtml = "Currently Logged User is  " + txt2.ToString() + "<br><div></div>";
                        //LogIn.Enabled = false;
                    }
                    else
                    {
                        Div2.InnerHtml = "No one Logged in" + "<br><div></div>";
                    }
                    Div4.InnerHtml = $"<a href=AllProducts.aspx><big>all products</big></a><br>";
                }
                PlaceHolder2.Controls.Add(new Literal { Text = test });

            }
        }

        protected void CartButton_Click(object sender, EventArgs e)
        {
            List<Purchase> shoppingcart;
            if (Session["cart"] == null)
            {
               
                   Cart.InnerHtml = "<h1>Your Shopping Cart is Empty</h1>";

            }
            else
            {
                OrderButton.Visible = true;
                shoppingcart = (List<Purchase>)Session["cart"];
                Cart.InnerHtml = " ";

                foreach (Purchase p in shoppingcart)
                {       var price="0.0";
                    decimal dec;
                    string ProductId = p.Productid.ToString();
                    string salquery = "SELECT * FROM Products where ProductId  =@ProductId";
                    using (SqlDataReader f = SQLhelper.ExecuteQuery(salquery, CommandType.Text, new SqlParameter(parameterName: "@ProductId", value: (ProductId))))
                    {
                       
                        while (f.Read())
                        {
                            dec = Convert.ToDecimal(f[3]);
                            price = f[3].ToString() ;
                               Cart.InnerHtml += f[1].ToString()+ dec;
                        }
                        
                    }
                    Cart.InnerHtml += "     Total price is:£"+ price+"    " ;
                }

            }
        }

    }
}



