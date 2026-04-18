using System.Text.RegularExpressions;

namespace StudentInfoApplication
{
    public partial class FrmStudentInfo : Form
    {
        List<Student> students = new List<Student>();

        public FrmStudentInfo()
        {
            InitializeComponent();

            students.Add(new Student("02000420421", "Peralta", "Janella"));
            students.Add(new Student("02000401891", "Hate", "Arnel"));

        }

        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {

            DisplayAllStudents();
            UpdateTotalStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxStuNum.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(textBoxStuNum.Text, @"^02000\d{6}$"))
            {
                MessageBox.Show("Student ID must start with 02000 followed by 6 digits.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxStuNum.Clear();
                return;
            }

            Student student = new Student(
                textBoxStuNum.Text,
                textBoxLastName.Text,
                textBoxFirstName.Text
            );

            // Add to list
            students.Add(student);

            // Display in listboxes
            listBoxStuNum.Items.Add(student.StudentID);
            listBoxLastName.Items.Add(student.StudentLastName);
            listBoxFirstName.Items.Add(student.StudentFirstName);

            UpdateTotalStudents();

            FieldHelper.ClearFields(this);
        }

        private void DisplayAllStudents()
        {
            listBoxStuNum.Items.Clear();
            listBoxLastName.Items.Clear();
            listBoxFirstName.Items.Clear();

            foreach (Student student in students)
            {
                listBoxStuNum.Items.Add(student.StudentID);
                listBoxLastName.Items.Add(student.StudentLastName);
                listBoxFirstName.Items.Add(student.StudentFirstName);
            }
        }

        private void UpdateTotalStudents()
        {
            TotalStudent.Text = students.Count.ToString();
        }

        private void btnClearRecords_Click(object sender, EventArgs e)
        {
            students.Clear();
            DisplayAllStudents();
            TotalStudent.Text = "0";
        }

        class Student
        {
            private string id, lastName, firstName;

            public Student()
            {
                id = "";
                lastName = "";
                firstName = "";
            }

            public Student(string id, string lastName, string firstName)
            {
                this.id = id;
                this.lastName = lastName;
                this.firstName = firstName;
            }

            public string StudentID
            {
                get { return id; }
                set { id = value; }
            }

            public string StudentLastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string StudentFirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
        }

        class FieldHelper
        {
            public static void ClearFields(Control parent)
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is TextBox)
                        ((TextBox)control).Clear();

                    if (control.HasChildren)
                        ClearFields(control);
                }
            }
        }
    }
}
