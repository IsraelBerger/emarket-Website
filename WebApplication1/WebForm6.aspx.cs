using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { string cf;
            try
            {
                    cf = (string)Session["BackToCart"];
                if (cf=="true")//Session[].ToString()=="true")
            {
                Button2.Visible = true;
            }
            }
            catch (Exception)
            {

                throw;
            }
            


            //            made this code whilst  id column was = "not null" is true to be able to insert it { even though is identity(1, 1) it started at 0 when starting to fill in the database}
            //            int lastid = 0;
            //            using (SqlDataReader n = SQLhelper.ExecuteQuery("SELECT [CustomerId] FROM [dbo].[Customers] WHERE CustomerId = (SELECT MAX(CustomerId) FROM [Customers])"))
            //                while (n.Read())
            //                {
            //                    lastid = Convert.ToInt32((n[0])) + 1;

            //                }
            //            will only need above code if id column = "not null" is true
            //            [CustomerId],lastid +, also need to add to next line if   id column = "not null" is true
            //              string salquery = "SELECT * FROM Products where ProductId  =@ProductId";
            //            using (SqlDataReader f = SQLhelper.ExecuteQuery(salquery, CommandType.Text, new SqlParameter(parameterName: "@ProductId", value: (RequestQueryString))))
        }



        protected void SubmitForm(object sender2, EventArgs e2)
        {
            SqlConnection InsertConnection = new SqlConnection((ConfigurationManager.ConnectionStrings["GearHostSqlServer"].ConnectionString));



            if (name.Text.Length == 0)
            {
                Response.Write("enter your name");
                Div2.InnerHtml = "no one Logged in  "; 
                
                  LoginButton.Enabled = false;
                Div2.InnerHtml = "Welcome To This Website You did not log in!";
            }
            if (name.Text.Length != 0)
            {

                string test = " ";
                string Command = "INSERT INTO [dbo].[Customers]" +
                   " ( [name] , [Adrress] , [PostCode] , [Country])" +
                   " VALUES( @name , @TextAdrress  , @TextPostCode  , @TextCountry  ) ";
                
                SqlDataAdapter data = new SqlDataAdapter(Command, InsertConnection);

                data.InsertCommand = new SqlCommand("INSERT INTO [dbo].[Customers] ( [name] , [Adrress] , [PostCode] , [Country]) VALUES( @name + @TextAdrress +  + @TextPostCode +  + @TextCountry  ) \")");
                data.SelectCommand.Parameters.AddWithValue("@name", name.Text);
                data.SelectCommand.Parameters.AddWithValue("@TextAdrress", Adrress.Text);
                data.SelectCommand.Parameters.AddWithValue("@TextPostCode", PostCode.Text);
                data.SelectCommand.Parameters.AddWithValue("@TextCountry", Country.Text);


                InsertConnection.Open();

                data.SelectCommand.ExecuteNonQuery();
                Session["s"] = name.Text;

               
                InsertConnection.Close();
            Div2.InnerHtml = "Welcome " + name.Text + " To This Website";
            }
            Response.Write("data stored");


        }
        protected void Veiw_Click(object sender3, EventArgs eventArgs3)
              {
    Response.Redirect("~/ViewItems.aspx");
              }

        protected void Button2_Click(object sender, EventArgs e)
        {
          string ProductId = Session["ProductId"].ToString();
            Button2.PostBackUrl =$"~/WebForm2.aspx?id={ ProductId.ToString()} ";
        }
    }
}

//    }

//}
//}
