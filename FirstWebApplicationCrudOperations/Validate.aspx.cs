using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class Validate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name=Request.Form["userNameText"];
            string password = Request.Form["passwordText"];

            Response.Write(name);
            Response.Write(password);
            /*if(name=="admin" && password =="admin")
            {
                Response.Write("valid user");
            }
            else
            {
                
                Response.Write("invalid user");
            }*/
        }
    }
}