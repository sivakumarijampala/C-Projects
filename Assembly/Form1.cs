using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerUser;

//private assembly 
namespace Assembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.AuthenticateUser(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show(user.Hellouser(textBox1.Text));
            }
            else
            {
                MessageBox.Show("invalid user");
            }

                    

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
