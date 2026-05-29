using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            lstEmployees.Items.Clear();
            foreach (Payroll emp in EmployeeDatabase.Employees)
            {
                string type = emp is FullTime ? "[FT]" : "[PT]";
                lstEmployees.Items.Add(type + " " + emp.EmployeeName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string hoursText = txtHours.Text.Trim();
            string rateText = txtRate.Text.Trim();
            string extraText = txtExtra.Text.Trim();

            if (name == "" || hoursText == "" || rateText == "" || extraText == "")
            {
                MessageBox.Show("Please fill in all fields!", "Missing Info");
                return;
            }

            if (!rbFullTime.Checked && !rbPartTime.Checked)
            {
                MessageBox.Show("Please select Full Time or Part Time!", "Missing Info");
                return;
            }

            double hours = double.Parse(hoursText);
            double rate = double.Parse(rateText);
            double extra = double.Parse(extraText);

            if (rbFullTime.Checked)
            {
                EmployeeDatabase.Employees.Add(new FullTime(name, hours, rate, extra));
            }
            else
            {
                EmployeeDatabase.Employees.Add(new PartTime(name, hours, rate, extra));
            }

            MessageBox.Show("Employee added!", "Success");
            txtName.Clear();
            txtHours.Clear();
            txtRate.Clear();
            txtExtra.Clear();
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to delete!", "No Selection");
                return;
            }

            int index = lstEmployees.SelectedIndex;
            string empName = EmployeeDatabase.Employees[index].EmployeeName;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete " + empName + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                EmployeeDatabase.Employees.RemoveAt(index);
                MessageBox.Show("Employee deleted!", "Success");
                RefreshList();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
