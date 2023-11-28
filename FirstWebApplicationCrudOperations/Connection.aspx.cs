using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class Connection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string connectionstring = "server=localhost;port=33065;uid=root;pwd=root;database=sivakumari";
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    string query = "create table e (id int,ename varchar(50),salary double)";
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }


                }

            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}