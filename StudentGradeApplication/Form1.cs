using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double english = double.Parse(this.english.Text);
            double math = double.Parse(this.math.Text);
            double science = double.Parse(this.science.Text);
            double history = double.Parse(this.history.Text);
            double filipino = double.Parse(this.filipino.Text);
            double total = (english + math + science + history + filipino) / 5;

            if (total >= 75)
            {
                Average.Text = $" The Student passed";
                Average2.Text = $"The general average of {name} is {total:F2}";
            }
            else
            {
                Average.Text = $" The Student failed";
                Average2.Text = $"The general average of {name} is {total:F2}";
            }
            Average.Visible = true;
            Average2.Visible = true;
        }

        private void Average_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
