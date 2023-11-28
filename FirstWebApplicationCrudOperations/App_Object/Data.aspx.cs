using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace FirstWebApplication.App_Object
{
    public partial class Data : System.Web.UI.Page
    {
        public List<Employee> EmployeeList = new List<Employee>();
        DBConnections db;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            db=new DBConnections();
            db.CreateTable();
            db.GetData(GridView1);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        

        protected void Row_Command(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex=Convert.ToInt32(e.CommandArgument);
            GridViewRow gridView = GridView1.Rows[rowIndex];
            if (e.CommandName == "Edit")
            {
                int id=Convert.ToInt32(gridView.Cells[0].Text);
                string name = Convert.ToString(gridView.Cells[1].Text);
                int age = Convert.ToInt32(gridView.Cells[2].Text);
                Response.Redirect("Registration.aspx?Id="+id+"&Name="+name+"&Age="+age);


            }
            else if(e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(gridView.Cells[0].Text);
                db.Delete(id);
            }
        }

        protected void Row_Deleting(object sender, GridViewDeleteEventArgs e)
        {
            Page_Load(sender, e);
        }

       
    }
}