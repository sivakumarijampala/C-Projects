using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class postback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //isPostBack is a property available in page class
            //if it is first request it return false otherwise it returns true
            Response.Write(this.IsPostBack+"</br>");
           
            if (this.IsPostBack == true)
            {
                Response.Write("value of text box:" + TextBox.Text);
            }
        }

        //event handlier 
        protected void Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}