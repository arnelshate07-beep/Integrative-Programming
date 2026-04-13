using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastName_StudentGradeAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Student
        {
            public string StuNumber;
            public string StuName;
            public double prelim;
            public double midterm;
            public double preFinal;
            public double final;
            public double average;
            public string result;
        }

        double ComputeAverage(double p, double m, double pf, double f)
        {
            return (p * 0.20) + (m * 0.20) + (pf * 0.20) + (f * 0.40);
        }
        double ComputeAverage(double p, double m)
        {
            return (p + m) / 2;
        }

        void DisplayStudent(Student s)
        {
            listBoxOutput.Items.Add("----------------------------------------------------------");
            listBoxOutput.Items.Add("Student Number: " + s.StuNumber);
            listBoxOutput.Items.Add("Student Name: " + s.StuName);
            listBoxOutput.Items.Add("Prelim: " + s.prelim);
            listBoxOutput.Items.Add("Midterm: " + s.midterm);
            listBoxOutput.Items.Add("Pre-Final: " + s.preFinal);
            listBoxOutput.Items.Add("Final: " + s.final);
            listBoxOutput.Items.Add("Average (20/20/20/40): " + s.average.ToString("F2"));
            listBoxOutput.Items.Add("Remarks: " + s.result);
            listBoxOutput.Items.Add("----------------------------------------------------------");
        }

        string ComputeResult(double average)
        {
            if (average >= 60)
            {
                return "Passed";
            }
            else
            {
                return "Failed";
            }
        }

        private void buttonCompute_Click_1(object sender, EventArgs e)
        {
            if (textStuNum.Text == "" || textStuName.Text == "" ||
                textPrelim.Text == "" || textMidterm.Text == "" ||
                textPreFinal.Text == "" || textFinal.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string stuNum = textStuNum.Text.Trim();

            if (string.IsNullOrWhiteSpace(stuNum))
            {
                MessageBox.Show("Student Number cannot be empty.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textStuNum.Focus();
                return;
            }

            if (stuNum.Length > 11)
            {
                MessageBox.Show("Student Number is too long. Maximum 11 characters only.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textStuNum.Focus();
                return;
            }
            foreach (char c in stuNum)
            {
                if (!char.IsDigit(c) && c != '-')
                {
                    MessageBox.Show("Student Number must contain numbers only.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textStuNum.Clear();
                    textStuNum.Focus();
                    return;
                }
            }

                double p, m, pf, f;

            if (!double.TryParse(textPrelim.Text, out p) ||
                !double.TryParse(textMidterm.Text, out m) ||
                !double.TryParse(textPreFinal.Text, out pf) ||
                !double.TryParse(textFinal.Text, out f))
            {
                MessageBox.Show("Please enter valid numeric values for grades.");
                return;
            }

            if (p < 0 || p > 100 || m < 0 || m > 100 || pf < 0 || pf > 100 || f < 0 || f > 100)
            {
                MessageBox.Show("Grades must be between 0 and 100.");
                return;
            }

            Student s = new Student();

            s.StuNumber = textStuNum.Text;
            s.StuName = textStuName.Text;
            s.prelim = p;
            s.midterm = m;
            s.preFinal = pf;
            s.final = f;

            s.average = ComputeAverage(s.prelim, s.midterm, s.preFinal, s.final);
            s.result = ComputeResult(s.average);

            DisplayStudent(s);


        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textStuNum.Clear();
            textStuName.Clear();
            textPrelim.Clear();
            textMidterm.Clear();
            textPreFinal.Clear();
            textFinal.Clear();
            listBoxOutput.Items.Clear();
        }
    }
}
