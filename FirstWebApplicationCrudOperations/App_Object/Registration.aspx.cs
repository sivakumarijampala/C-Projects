using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication.App_Object
{
    public partial class Registration : System.Web.UI.Page
    {
        public static int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["Id"]);
                string name = Request.QueryString["Name"];
                int age = Convert.ToInt32(Request.QueryString["Age"]);

                empText.Text = name;
                empAgeText.Text = Convert.ToString(age);
            }

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            string name = empText.Text;
            int age = Convert.ToInt32(empAgeText.Text);
            
            Employee emp1 = new Employee()
            {
                Name = name,
                Age=age

            };
           
            DBConnections conn = new DBConnections(emp1);
           
            if (id == 0)
            {
                conn.Insert(emp1);
            }
            else
            {
                conn.Update(emp1,id);
            }
            Response.Redirect("Data.aspx");
        }
    }
}