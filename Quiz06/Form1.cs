using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] classmates = { "Patrick ", "Clark ", "Sulit ", "Bantigue ", "Jhirro ", "Rain " };

            foreach (string classmate in classmates)
            {
                Classmates.Items.Add(classmate);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

    }

        private void button1_Click(object sender, EventArgs e)
        {
            String textBox = textBox1.Text;
            if (textBox == "hello")
            {
                MessageBox.Show("You said hello =) ");
            }
            else
            {
                MessageBox.Show("You didn't say hello =( ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
