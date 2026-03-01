namespace StudentRegistrationApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personInformation = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.stuHeader = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.Label();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.genderBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.ComboBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.genderBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // personInformation
            // 
            this.personInformation.AutoSize = true;
            this.personInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personInformation.Location = new System.Drawing.Point(4, 4);
            this.personInformation.Name = "personInformation";
            this.personInformation.Size = new System.Drawing.Size(145, 18);
            this.personInformation.TabIndex = 1;
            this.personInformation.Text = "Personal Information";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(19, 137);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(77, 16);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last Name*";
            // 
            // stuHeader
            // 
            this.stuHeader.AutoSize = true;
            this.stuHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuHeader.Location = new System.Drawing.Point(5, 4);
            this.stuHeader.Name = "stuHeader";
            this.stuHeader.Size = new System.Drawing.Size(262, 25);
            this.stuHeader.TabIndex = 0;
            this.stuHeader.Text = "Student Registration Form";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.header.Controls.Add(this.stuHeader);
            this.header.Location = new System.Drawing.Point(58, 34);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(270, 34);
            this.header.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.personInformation);
            this.panel1.Location = new System.Drawing.Point(15, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 26);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(110, 135);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(251, 20);
            this.lastNameBox.TabIndex = 5;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(19, 170);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(77, 16);
            this.firstName.TabIndex = 6;
            this.firstName.Text = "First Name*";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(110, 169);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(251, 20);
            this.firstNameBox.TabIndex = 7;
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleName.Location = new System.Drawing.Point(19, 207);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(93, 16);
            this.middleName.TabIndex = 8;
            this.middleName.Text = "Middle Name*";
            // 
            // middleNameBox
            // 
            this.middleNameBox.Location = new System.Drawing.Point(110, 206);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(251, 20);
            this.middleNameBox.TabIndex = 9;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(19, 245);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(57, 16);
            this.gender.TabIndex = 10;
            this.gender.Text = "Gender*";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(4, 4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 11;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(58, 4);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 12;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.male);
            this.genderBox.Controls.Add(this.female);
            this.genderBox.Location = new System.Drawing.Point(80, 240);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(121, 27);
            this.genderBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date of Birth*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dayBox
            // 
            this.dayBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(5, 4);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(70, 21);
            this.dayBox.TabIndex = 15;
            // 
            // monthBox
            // 
            this.monthBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(81, 4);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(90, 21);
            this.monthBox.TabIndex = 16;
            // 
            // yearBox
            // 
            this.yearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(177, 4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(90, 21);
            this.yearBox.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dayBox);
            this.panel2.Controls.Add(this.yearBox);
            this.panel2.Controls.Add(this.monthBox);
            this.panel2.Location = new System.Drawing.Point(22, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 29);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Course*";
            // 
            // courseBox
            // 
            this.courseBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Location = new System.Drawing.Point(22, 368);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(272, 21);
            this.courseBox.TabIndex = 20;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Crimson;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(22, 404);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(145, 36);
            this.registerButton.TabIndex = 21;
            this.registerButton.Text = "Register Student";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.lastName);
            this.Name = "Form1";
            this.Text = "frmStudentRegistration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label personInformation;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label stuHeader;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Panel genderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox courseBox;
        private System.Windows.Forms.Button registerButton;
    }
}

