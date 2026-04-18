namespace StudentInfoApplication
{
    partial class FrmStudentInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxStuNum = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            button1 = new Button();
            listBoxStuNum = new ListBox();
            listBoxFirstName = new ListBox();
            listBoxLastName = new ListBox();
            TotalStudent = new Label();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 72);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Number*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(114, 20);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 149);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 110);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "First Name*";
            // 
            // textBoxStuNum
            // 
            textBoxStuNum.BackColor = Color.FromArgb(255, 192, 192);
            textBoxStuNum.Location = new Point(131, 68);
            textBoxStuNum.Name = "textBoxStuNum";
            textBoxStuNum.Size = new Size(176, 23);
            textBoxStuNum.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.FromArgb(255, 192, 192);
            textBoxLastName.Location = new Point(131, 145);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(176, 23);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(255, 192, 192);
            textBoxFirstName.Location = new Point(131, 106);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(176, 23);
            textBoxFirstName.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(25, 198);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBoxStuNum
            // 
            listBoxStuNum.BackColor = Color.FromArgb(255, 192, 192);
            listBoxStuNum.FormattingEnabled = true;
            listBoxStuNum.Location = new Point(372, 70);
            listBoxStuNum.Name = "listBoxStuNum";
            listBoxStuNum.Size = new Size(120, 94);
            listBoxStuNum.TabIndex = 8;
            // 
            // listBoxFirstName
            // 
            listBoxFirstName.BackColor = Color.FromArgb(255, 192, 192);
            listBoxFirstName.FormattingEnabled = true;
            listBoxFirstName.Location = new Point(498, 70);
            listBoxFirstName.Name = "listBoxFirstName";
            listBoxFirstName.Size = new Size(120, 94);
            listBoxFirstName.TabIndex = 9;
            // 
            // listBoxLastName
            // 
            listBoxLastName.BackColor = Color.FromArgb(255, 192, 192);
            listBoxLastName.FormattingEnabled = true;
            listBoxLastName.Location = new Point(624, 70);
            listBoxLastName.Name = "listBoxLastName";
            listBoxLastName.Size = new Size(120, 94);
            listBoxLastName.TabIndex = 10;
            // 
            // TotalStudent
            // 
            TotalStudent.AutoSize = true;
            TotalStudent.ForeColor = Color.White;
            TotalStudent.Location = new Point(449, 171);
            TotalStudent.Name = "TotalStudent";
            TotalStudent.Size = new Size(13, 15);
            TotalStudent.TabIndex = 11;
            TotalStudent.Text = "0";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(131, 198);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 12;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnClearRecords_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(372, 171);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 13;
            label5.Text = "Total Student:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(372, 52);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 14;
            label6.Text = "Student Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(498, 52);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 15;
            label7.Text = "Student First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(624, 52);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 16;
            label8.Text = "Student Last Name";
            // 
            // FrmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(770, 241);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(TotalStudent);
            Controls.Add(listBoxLastName);
            Controls.Add(listBoxFirstName);
            Controls.Add(listBoxStuNum);
            Controls.Add(button1);
            Controls.Add(textBoxFirstName);
            Controls.Add(label4);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(textBoxStuNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmStudentInfo";
            Text = "FrmStudentInfo";
            Load += FrmStudentInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxStuNum;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Button button1;
        private ListBox listBoxStuNum;
        private ListBox listBoxFirstName;
        private ListBox listBoxLastName;
        private Label TotalStudent;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
