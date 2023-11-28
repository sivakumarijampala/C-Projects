using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlConnector
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            try
            {

                string connectionString = "server=localhost; port=33065;uid=root;password=root;database=sivakumari";


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string createTableQuery = "CREATE TABLE STUD (id INT PRIMARY KEY AUTO_INCREMENT, name VARCHAR(50), age INT)";
                    using (MySqlCommand command = new MySqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message.ToString());
            }
        }
    }
}
