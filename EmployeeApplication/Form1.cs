using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EmployeeApplication.Form1;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {

       Employee employee = new Employee();
       DataTable table = new DataTable("table");


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmpId.Text == "" || textBoxFirstName.Text == "" ||
                textBoxLastName.Text == "" || textBoxPosition.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            
            employee.Id = textBoxEmpId.Text;
            employee.FirstName = textBoxFirstName.Text;
            employee.LastName = textBoxLastName.Text;
            employee.Position = textBoxPosition.Text;

            table.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.Position);

            textBoxEmpId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPosition.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Position", typeof(string));

            EmployeeList.DataSource = table; 

        }
    }
}
