using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class PostBackEventsEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("page load event fired <br/>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("cached event of text box:<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("post back event of button fires");
        }
    }
}