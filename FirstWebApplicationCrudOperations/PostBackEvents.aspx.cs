using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class PostBackEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("hello world");
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Response.Write("<br/>button1 is clicked");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<br/> button2 clicked");
        }
    }
}