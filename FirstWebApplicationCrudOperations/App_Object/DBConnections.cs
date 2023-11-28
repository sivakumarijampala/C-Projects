using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace FirstWebApplication.App_Object
{
    public class DBConnections
    {
        string connectionstring = "server=localhost;port=33065;uid=root;pwd=root;database=sivakumari";
        MySqlConnection connection;
       
        public DBConnections()
        {
            connection = new MySqlConnection(connectionstring);
        }
        
        public DBConnections(Employee emp)
        {
            connection = new MySqlConnection(connectionstring);
        }

        //open connection
        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        //close connection
        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        //creating table
        public void CreateTable()
        {
            try
            {
                OpenConnection();
                string query = "CREATE TABLE IF NOT EXISTS Emp(Id INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(100),Age int)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }

        }

        //inserting

        public void Insert(Employee emp)
        {
            try
            {
                OpenConnection();
                string insertQuery = "insert into emp(Name,Age) values(@name,@age)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", emp.Name);
                    command.Parameters.AddWithValue("@age", emp.Age);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }

        }

        


       

        //get details

       /* public List<Employee> GetDetails()
        {
            try
            {
                OpenConnection();
                string getQuery = "SELECT * FROM emp";
                MySqlCommand cmd = new MySqlCommand(getQuery, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    List<Employee> listEmployee = new List<Employee>();
                    while (reader.Read())
                    {
                        Employee emp = new Employee()
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                             Name=reader["Name"].ToString(),
                             Age = Convert.ToInt32(reader["Age"].ToString())

                        };
                        listEmployee.Add(emp);
                    }
                    return listEmployee;
                       
                    
                }
               

            }
            finally
            {
                CloseConnection();
            }
        }
*/


        //get details from database

        public void GetData(GridView gridView)
        {
            try
            {
                OpenConnection();
                string query = "select * from emp";
                MySqlCommand cmd = new MySqlCommand(query,connection);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    gridView.DataSource = ds;
                    gridView.DataBind();

                }
            }
            finally
            {

            }
        }
            
        //delete employee

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                string query = "delete from emp  where Id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }


        //update employee

        public void Update(Employee e,int id)
        {
            try
            {
                OpenConnection();
                string updateQuery = "update emp set Name=@name,Age=@age where Id=@id";
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", e.Name);
                    cmd.Parameters.AddWithValue("@age", e.Age);

                    cmd.ExecuteNonQuery();

                };
            }
            finally
            {
                CloseConnection();
            }
        }
       

        
        

        }

    }



