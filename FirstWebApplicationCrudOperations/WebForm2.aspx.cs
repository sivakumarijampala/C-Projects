using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this method is used to focus on textboxwhen the form loaded
            TextBox2.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s="hello " +TextBox2.Text;
            Response.Write(s);
        }
    }
}