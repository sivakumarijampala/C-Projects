using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class CrosspostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                userNameText.Focus();
            }
        }

        protected void resetButton_Click(object sender, EventArgs e)
        {
            userNameText.Text = passwordText.Text = "";
            userNameText.Focus();
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}