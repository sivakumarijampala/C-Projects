using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Connection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connectionString = "server=localhost;port=33065;uid=root;pwd=root;database=sivakumari";
            MySqlConnection conneection = new MySqlConnection(connectionString);
            conneection.Open();
            string query = "create table siva (id int,name varchar(10))";
            MySqlCommand cmd = new MySqlCommand(query, conneection);
            cmd.ExecuteReader();
            conneection.Close();
        }
    }
}