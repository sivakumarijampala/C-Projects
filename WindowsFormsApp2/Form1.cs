using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //serialization in xml
        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                name = textBox1.Text,
                phone = textBox2.Text,
                dob = dateTimePicker1.Value,
                department=textBox4.Text,
                salary=Convert.ToInt32(textBox5.Text),
                additionalInfo="dont want to serialize",
            };


            //XmlSerializer xml = new XmlSerializer(typeof(Employee));

            BinaryFormatter bf = new BinaryFormatter();

            //FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);

            FileStream fsout = new FileStream("employee.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    //xml.Serialize(fsout, employee);
                    bf.Serialize(fsout, employee);
                    label6.Text = "serialized";
                }

            }
            catch
            {
                label6.Text = "erroe occur";
            }
        }

        //deserialization in xml
        private void button2_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            
            // XmlSerializer xml = new XmlSerializer(typeof(Employee));

            BinaryFormatter bf = new BinaryFormatter();
            
            //FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);

            FileStream fsin = new FileStream("employee.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    //employee =(Employee)xml.Deserialize(fsin);
                    employee = (Employee)bf.Deserialize(fsin);
                    label6.Text = "deserialized";
                    textBox1.Text = employee.name;
                    textBox2.Text = employee.phone;
                    dateTimePicker1.Value = employee.dob;
                    textBox4.Text = employee.department;
                    textBox5.Text = employee.salary.ToString();
                }
            }
            catch
            {
                label6.Text = "error occur";

            }

        }
    }
}
