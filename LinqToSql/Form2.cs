using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql
{
    public partial class Form2 : Form
    {
       public static  Form2 f2;
         public Form1 f1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }


        //save 
        private void Save_Click(object sender, EventArgs e)
        {
            EmployeeDataContext context = new EmployeeDataContext();
            
            if (idText.ReadOnly==false)
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(idText.Text);
                employee.Name = NameText.Text;
                employee.Age = AgeText.Text;
                context.Employees.InsertOnSubmit(employee);
                context.SubmitChanges();
                MessageBox.Show("inserted");
                
                f1.Show();

               
               
               

            }
            else
            {
                Employee employee = context.Employees.SingleOrDefault(e1 => e1.Id ==int.Parse( idText.Text));
                employee.Name = NameText.Text;
                employee.Age = AgeText.Text;
                context.SubmitChanges();
                MessageBox.Show("updated");
                
                f1.Show();
            }
                
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox tb=ctrl as TextBox;
                    tb.Clear();
                }
                NameText.Focus();
            }
        }
    }
}
