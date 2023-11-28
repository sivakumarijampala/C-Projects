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
    public partial class Form1 : Form
    {
        private List<Employee> employees;
        public EmployeeDataContext edb;
        public static Form1 f1;
        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
        }
        public void LoadForm()
        {

             edb = new EmployeeDataContext();
            employees = edb.Employees.ToList();
            dataGridView1.DataSource = employees;
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            LoadForm();
            f1.Close();

        }


        //update
        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Form2 form2 = new Form2();
                form2.idText.ReadOnly = true;
                form2.idText.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                form2.NameText.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                form2.AgeText.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                form2.ShowDialog();
                LoadForm();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Employee emp = edb.Employees.SingleOrDefault(m => m.Id == id);
                edb.Employees.DeleteOnSubmit(emp);
                edb.SubmitChanges();
                LoadForm();
            }
            else
            {
                MessageBox.Show("select row to delete");
            }

        }
    }
}
