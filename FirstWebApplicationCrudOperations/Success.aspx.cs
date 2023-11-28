using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //previouspage property provide access to the success class
          Page pp= PreviousPage;

            //controll is parent of all controlls
          Control ctrl = pp.FindControl("userNameText");

            //the data is in the form of controll
            //we have to convert that into textbox text
            TextBox tb = (TextBox)ctrl;
            string Name=tb.Text;
            Response.Write("hello " + Name);


        }
    }
}