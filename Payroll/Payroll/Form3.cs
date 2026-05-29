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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text.Trim();
            Payroll found = null;

            foreach (Payroll emp in EmployeeDatabase.Employees)
            {
                if (emp.EmployeeName.ToLower() == searchName.ToLower())
                {
                    found = emp;
                    break;
                }
            }

            if (found == null)
            {
                MessageBox.Show("Employee not found!", "Search Result");
                return;
            }

            rtbOutput.Clear();
            rtbOutput.AppendText("===== PAYROLL DETAILS =====\n");
            rtbOutput.AppendText("Name: " + found.EmployeeName + "\n");
            rtbOutput.AppendText("Hours Worked: " + found.HoursWorked + "\n");
            rtbOutput.AppendText("Hourly Rate: ₱" + found.HourlyRate + "\n");

            if (found is FullTime)
            {
                FullTime ft = (FullTime)found;
                rtbOutput.AppendText("Employee Type: Full Time\n");
                rtbOutput.AppendText("Monthly Bonus: ₱" + ft.MonthlyBonus + "\n");
            }
            else if (found is PartTime)
            {
                PartTime pt = (PartTime)found;
                rtbOutput.AppendText("Employee Type: Part Time\n");
                rtbOutput.AppendText("Deduction: ₱" + pt.Deduction + "\n");
            }

            rtbOutput.AppendText("===========================\n");
            rtbOutput.AppendText("TOTAL SALARY: ₱" + found.ComputeSalary() + "\n");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
