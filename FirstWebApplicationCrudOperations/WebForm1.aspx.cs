using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //we can directly access asp server controlls in our code
            string str1=TextBox1.Text;
            Response.Write(str1);
            Response.Write("***");
           
            //but html controlls can not access directly in our code
            //if we want to access the data in the code we use following code
            string str2=Request.Form["Textbox2"];

            Response.Write(str2);
        }
    }
}