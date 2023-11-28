using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form2 : Form
    {
        public static Form2 form2;
        public Form2()
        {
            form2 = this;
            InitializeComponent();
            
        }

        //add student button
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            
            form1.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Implement the logic for the Form2_Load event handler
            // This method is called when Form2 is being loaded
            DBConnection db = new DBConnection(dataGridView1);
            db.getStudentData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //delete button
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id=Convert.ToInt32(row.Cells["id"].Value);
                DBConnection db = new DBConnection(dataGridView1);
                db.DeleteStudent(id);
                db.getStudentData();
            }
        }

        //update
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                int columnIndex = selectedCell.ColumnIndex;
                string newValue = selectedCell.Value.ToString(); // Assuming the cell value is a string

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedCell.RowIndex];
                int rowId = Convert.ToInt32(selectedRow.Cells["Id"].Value); // Replace "Id" with the actual column name of your row ID

                DBConnection db = new DBConnection(dataGridView1); // Pass the DataGridView instance to the constructor
                db.UpdateStudent(rowId, columnIndex, newValue);
                db.getStudentData();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
