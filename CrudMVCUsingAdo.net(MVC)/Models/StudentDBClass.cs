using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CrudMVC.Models
{
    public class StudentDBClass
    {
        string connectionstring = "server=localhost;port=33065;password=root;user=root;database=sivakumari";
        public MySqlConnection connection;


        //constructor
        public StudentDBClass()
        {
            connection = new MySqlConnection(connectionstring);
        }

        //open connection method
        public void OpenConnection()
        {
            if ( connection.State!= ConnectionState.Open) 
            {
                connection.Open(); 
            }

        }


        //close connection method
        public void CloseConnection()
        {
            if (connection.State!=ConnectionState.Closed) 
            { 
            connection.Close();
            }
        }


        //create table method
        public void Create()
        {
            try
            {
                OpenConnection();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS student1 (Id INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(100), City VARCHAR(100),Address VARCHAR(100))";
                MySqlCommand cmd = new MySqlCommand(createTableQuery, connection);
                cmd.ExecuteNonQuery();

            }
            finally
            {
                CloseConnection();
            }
        }


        //insert student Method
        public void Insert(StudentModel student)
        {
            try
            {
                OpenConnection();
                string insertQuery = "insert into student1 (Name,City,Address) values(@name,@city,@address)";
                using (MySqlCommand cmd=new MySqlCommand(insertQuery,connection))
                {

                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@city", student.City);
                    cmd.Parameters.AddWithValue("@address", student.Address);
                    cmd.ExecuteNonQuery();

                }
            }
            finally
            {
                CloseConnection();
            }
        }

        //display student method
       public List<StudentModel> GetAll()
        {
            try
            {
                OpenConnection();
                List<StudentModel> students = new List<StudentModel>();
                string getDetailsQuery = "select * from student1";
                using (MySqlCommand cmd = new MySqlCommand(getDetailsQuery, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader.GetString(0));
                        string name = reader.GetString(1);
                        string city = reader.GetString(2);
                        string address = reader.GetString(3);


                        StudentModel stu = new StudentModel()
                        {
                            Id=id,
                            Name = name,
                            City=city,
                            Address=address

                        };
                        students.Add(stu);
                    }
                    return students;

                }
            }
            finally
            {
                CloseConnection();
            }
        }


        //get student by id

        public StudentModel GetStudentById( int id)
        {
            try
            {
                OpenConnection();
                string query = "select * from student1 where Id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                   MySqlDataReader reader= cmd.ExecuteReader();
                     if (reader.Read())
                    {
                        string name = reader.GetString(1);
                        string city = reader.GetString(2);
                        string address = reader.GetString(3);



                        StudentModel stu = new StudentModel()
                        {
                            Name=name,
                            City=city,
                            Address=address

                        };
                        return stu;
                    }
                    return null;
                }
            }
            finally
            {
                CloseConnection();
            }
        }


        //update student method

        public void Update(StudentModel student,int id)
        {
            try
            {
                OpenConnection();
                string updateQuery = "update student1 set Name=@name,City=@city,Address=@address where Id=@id";
                using (MySqlCommand cmd=new MySqlCommand(updateQuery,connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@city", student.City);
                    cmd.Parameters.AddWithValue("@address", student.Address);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }

        }

        //delete  student method
        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                string deleteQuery = "delete from student1 where Id=@id";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery,connection))
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
    }
}