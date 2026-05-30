using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll.EmployeeNamespace;

namespace Payroll
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "" || txtLastName.Text == "" || txtDepartment.Text == "" || 
                txtJobTitle.Text == "" || txtRatePerHour.Text == "" || txtTotalHours.Text == "")
                {
                MessageBox.Show("Fields cannot be null!", "Error");
                return;
                }

            String fName = txtFirstName.Text;

            String lName = txtLastName.Text;

            String dept = txtDepartment.Text;

            String job = txtJobTitle.Text;

            Double rate = double.Parse(txtRatePerHour.Text);

            int hours = int.Parse(txtTotalHours.Text);

            PartTimeEmployee emp = new PartTimeEmployee(fName, lName, dept, job);

            emp.computeSalary(hours, rate);


            lblFirstName.Text = "First name:  " +emp.FirstName;

            lblLastName.Text = "Last name:  "  + emp.LastName;

            lblBasicSalary.Text = "Basic Salary:  " +emp.BasicSalary.ToString("F2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDepartment.Clear();
            txtJobTitle.Clear();
            txtRatePerHour.Clear();
            txtTotalHours.Clear();

            lblFirstName.Text = "First name: < first name here>";
            lblLastName.Text = "Last name:   < last name here>";
            lblBasicSalary.Text = "Basic Salary:  00.00";

        }
    }
}
