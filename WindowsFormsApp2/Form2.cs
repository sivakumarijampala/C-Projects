using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        employee1 emp;
        public Form2()
        {
            InitializeComponent();
            emp = new employee1();
        }

        //serialization json object

        private void button1_Click(object sender, EventArgs e)
        {
            //get values from textbox
            emp.Name=textBox1.Text;
            emp.Age=Convert.ToInt32(textBox2.Text);
            emp.Email = textBox3.Text;
            
           //create department object 
            var department = new Department();
            department.Name = textBox4.Text;
            department.Location = textBox5.Text;
            emp.department = department;
            string json=JsonSerializer.Serialize(emp);

            textBox6.Text = json;

            

        }

        //deserialization

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                emp = JsonSerializer.Deserialize<employee1>(textBox6.Text);
                textBox1.Text = emp.Name;
                textBox2.Text = emp.Age.ToString();
                textBox3.Text = emp.Email;
                textBox4.Text = emp.department.Name;
                textBox5.Text = emp.department.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
