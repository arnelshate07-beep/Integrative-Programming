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
       private BindingList<Employee> employeeList = new BindingList<Employee>();

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

            Employee employee = new Employee();
            textBoxEmpId.Text.Trim();
            textBoxFirstName.Text.Trim();
            textBoxLastName.Text.Trim();
            textBoxPosition.Text.Trim();

            employeeList.Add(employee);

            textBoxEmpId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPosition.Clear();

        }
    }
}
