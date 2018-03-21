using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
           // string x= "SELECT * FROM [dbo].[Products] inner join [dbo].[ProductCatagory]on Products.ProductId=ProductCatagory.ProductId and ProductCatagory.CategoryId= @CatId ";
            string x = "SELECT * FROM [dbo].[Products] inner join [dbo].[ProductCatagory] on ProductCatagory.CategoryId= @CatId  and Products.ProductId=ProductCatagory.ProductId";

            string CatId = Request.QueryString["Id"];
           
            using (SqlDataReader k = SQLhelper.ExecuteQuery(x, CommandType.Text, new SqlParameter("@CatId", Int32.Parse(CatId))))
            {
                string y = (string)Session["s"];
               
                while (k.Read() )     //&& Session["s"] != null
                {
                    Div1.InnerHtml += $"<div  background-color: violet>";
                   Div1.InnerHtml += $"<a href=WebForm2.aspx?id={k["ProductId"].ToString()}><big>{k["Name"]}</big></a><br>";
                    Div1.InnerHtml += $"<div/>";
                 
                   
                }

            }
        }
    }
}