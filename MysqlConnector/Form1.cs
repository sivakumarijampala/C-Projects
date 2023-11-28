using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Digests.SkeinEngine;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.Common;
using System.Windows.Input;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System.Data.SqlClient;

namespace MysqlConnector
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        //insert student
        private void button2_Click(object sender, EventArgs e)
        {
           

            string connectionString = "server=localhost; port=33065;uid=root;password=root;database=sivakumari";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO stud (id,name, age) VALUES (@id,@name, @age)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(textBox3.Text));
                        command.Parameters.AddWithValue("@name", textBox1.Text);
                        command.Parameters.AddWithValue("@age", Convert.ToInt32(textBox2.Text));
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }


                GetStudentDetails();
                MessageBox.Show("Student data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }











        //update student
        private void button4_Click(object sender, EventArgs e)

        {
            string connectionString = "server=localhost; port=33065;uid=root;password=root;database=sivakumari";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string updatequery = "UPDATE stud set name=@name,age=@age WHERE id=@id";
                    using (MySqlCommand command = new MySqlCommand(updatequery, connection))
                    {
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(textBox3.Text));
                        command.Parameters.AddWithValue("@name", textBox1.Text);
                        command.Parameters.AddWithValue("@age", Convert.ToInt32(textBox2.Text));
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                GetStudentDetails();
                MessageBox.Show("Student data updated successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
    









        //delete Student
        private void button3_Click(object sender, EventArgs e)
        {
             
            string connectionString = "server=localhost; port=33065;uid=root;password=root;database=sivakumari";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM stud WHERE id = @id";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(textBox3.Text));

                        command.ExecuteNonQuery();
                       
                    }

                    connection.Close();
                }
               
                GetStudentDetails();


                MessageBox.Show("Student data deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentDetails();
        }


        //display student details
        MySqlConnection con;
        MySqlDataAdapter adap;
        DataSet ds;

        void GetStudentDetails()
        {
            string connectionString = "server=localhost; port=33065;uid=root;password=root;database=sivakumari";
            try 
            {
                con = new MySqlConnection(connectionString);
                con.Open();
                adap = new MySqlDataAdapter("SELECT * from stud",con);
                ds = new DataSet();
                adap.Fill(ds, "student_details");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            
        }
        private void idelete()
        {
            foreach(DataGridViewRow item in this.dataGridView1.Rows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



       