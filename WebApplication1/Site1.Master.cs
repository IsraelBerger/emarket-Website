using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.Web.Security;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            using (SqlDataReader r = SQLhelper.ExecuteQuery(query: "select * from dbo.Products"))
            {
                while (r.Read())
                {

                    //  HELLO.InnerHtml = (r[0]+" "+ r[1] + " " + r[2] + " " + r[3] );




                    //    Response.Write(r[0]);
                }
            }
        }

        //protected void Login1_LoggedIn(object sender, EventArgs e)
        //{

        //}

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
