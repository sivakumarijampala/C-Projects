using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                userNameText.Focus();
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
           if(userNameText.Text=="admin" && passwordText.Text == "admin")
            {
                Server.Transfer("Success.aspx");
            }
            else
            {
                Response.Redirect("Failure.aspx?Name="+userNameText.Text);

            }
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            userNameText.Text = passwordText.Text = "";
            userNameText.Focus();

        }
    }
}