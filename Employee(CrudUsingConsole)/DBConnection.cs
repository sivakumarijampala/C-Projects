using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee
{
    public class DBConnection
    {
        private DataGridView dataGridView1;
        string connectionString = "server=localhost; port=33065;uid=root;password=root;database=sivakumari";
        MySqlConnection mySqlConnection;
       
        public DBConnection(Student student)
        {           
            mySqlConnection = new MySqlConnection(connectionString);
        }
        

        public DBConnection(DataGridView dataGridView)
        {
            this.dataGridView1 = dataGridView;
            mySqlConnection = new MySqlConnection(connectionString);
            // Rest of the constructor code
        }



        //opening connection method
        public void OpenConnection()
        {
            if (mySqlConnection.State !=ConnectionState.Open)
            {
                mySqlConnection.Open();
            }
        }

        //closing connection method
        public void CloseConnection()
        {
            if (mySqlConnection.State !=ConnectionState.Closed)
            {
                mySqlConnection.Close();
            }

        }


        //create table
        public void CreateTable()
        {
            try
            {
                OpenConnection();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS student (Id INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(100), Gender VARCHAR(300), DateOfBirth DATE)";

                using (MySqlCommand command = new MySqlCommand(createTableQuery, mySqlConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        //insert method
        public void InsertData(Student student)
        {
            try
            {
                OpenConnection();
                string insertQuery="insert into student (Name,Gender,DateOfBirth) values(@name,@gender,@dateOfBirth)";
                using (MySqlCommand command = new MySqlCommand(insertQuery,mySqlConnection))
                {
                   // command.Parameters.AddWithValue("id", student.Id);
                    command.Parameters.AddWithValue("@name", student.Name);
                    command.Parameters.AddWithValue("@gender", student.Gender);
                    command.Parameters.AddWithValue("@dateOfBirth", student.DateOfBirth);
                    command.ExecuteNonQuery();
                }

            }
            finally
            {
                CloseConnection();
                
            }

        }


        //fetch the data from database
        MySqlDataAdapter adap;
        DataSet ds;

        public void getStudentData()
        {
            try
            {
                OpenConnection();
                adap = new MySqlDataAdapter("SELECT * FROM student", mySqlConnection);
                DataTable dt = new DataTable();
                adap.Fill(dt);

              
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        //delete the data

        public void DeleteStudent(int id) {

            try
            {
                OpenConnection();
                string deleteQuery = "delete from student where id=@id;";
                using (MySqlCommand command = new MySqlCommand(deleteQuery, mySqlConnection))
                {
                    
                    command.Parameters.AddWithValue("@id",id);
                    
                    command.ExecuteNonQuery();
                }


            }
            finally
            {
                CloseConnection();
            }

        }

        //update student
        public void UpdateStudent(int rowId, int columnIndex, string newValue)
        {
            try
            {
                OpenConnection();

                // Assuming you have a column name associated with the columnIndex
                string columnName = dataGridView1.Columns[columnIndex].Name;

                string updateQuery = $"UPDATE student SET {columnName} = @NewValue WHERE Id = @RowId";
                using (MySqlCommand command = new MySqlCommand(updateQuery, mySqlConnection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@RowId", rowId);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }

        }


    }
}

