using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dayBox.Items.Add("-Day-");
            for (int day = 1; day <= 31; day++)
            {
                dayBox.Items.Add(day);
            }
            dayBox.SelectedIndex = 0;

            monthBox.Items.Add("-Month-");

            string[] months = { "January", "February", "March", "April", "May", "June",
                    "July", "August", "September", "October", "November", "December" };

            foreach (string month in months)
            {
                monthBox.Items.Add(month);
            }
            monthBox.SelectedIndex = 0;

            yearBox.Items.Add("-Year-");
            for (int year = 1900; year <= DateTime.Now.Year; year++)
            {
                yearBox.Items.Add(year);
            }
            yearBox.SelectedIndex = 0;

            courseBox.Items.Add("-Program-");
            string[] courses = { "BS Computer Science", "BS Information Technology", "BS Information Systems ", "BS Computer Engineering" };

            foreach (string course in courses)
            {
                courseBox.Items.Add(course);
            }
            courseBox.SelectedIndex = 0;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameBox.Text) ||
                string.IsNullOrWhiteSpace(firstNameBox.Text) ||
                string.IsNullOrWhiteSpace(middleNameBox.Text) ||
                dayBox.SelectedIndex == 0 ||
                monthBox.SelectedIndex == 0 ||
                yearBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill in all fields and select options.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lastName = lastNameBox.Text;
            string firstName = firstNameBox.Text;   
            string middleName = middleNameBox.Text;
            string birth = $"{dayBox.SelectedItem} {monthBox.SelectedItem}, {yearBox.SelectedItem}";
            String gender = male.Checked ? "Male" : female.Checked ? "Female" : "N/A";
            string course = courseBox.SelectedItem.ToString();

            Student(firstName, lastName, middleName, gender, birth, course);
            Student(firstName, lastName, middleName, course);
            Student(firstName, lastName, course);

        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();   

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        public void Student(string firstName, string lastName, string middleName, string gender, string birth, string course)
        {
            String message = $"Student Name: {lastName}, {firstName} {middleName}\n" +
                             $"Gender: {gender}\n" +
                             $"Birth Date: {birth}\n" +
                             $"Course: {course}\n";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Student(string firstName, string lastName, string middleName, string course)
        {
            String message = $"Student Name: {lastName}, {firstName} {middleName}\n" +
                             $"Course: {course}\n";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Student(string firstName, string lastName, string course)
        {
            String message = $"Student Name: {lastName}, {firstName}\n" +
                             $"Course: {course}\n";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
