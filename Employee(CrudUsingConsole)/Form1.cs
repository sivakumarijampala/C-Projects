using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            form1 = this;
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            string studentName = textBoxName.Text;
            string gender = string.Empty;
            if (radioButton1.Checked)
            {
                gender = "Male";
                
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }

            if (DateTime.TryParse(dateTime.Text, out DateTime date))
                {
                    Student student = new Student(studentName, gender, date);
                    DBConnection dbConnection = new DBConnection(student);
                    dbConnection.CreateTable();
                    dbConnection.InsertData(student);
                    form1.Close();
                    form2.Show();
                }
                else
                {
                    // Handle invalid date format
                    MessageBox.Show("Invalid date format");
                }
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
