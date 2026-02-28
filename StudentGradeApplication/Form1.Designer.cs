namespace StudentGradeApplication
{
    partial class frmStudentGradeProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.english = new System.Windows.Forms.TextBox();
            this.math = new System.Windows.Forms.TextBox();
            this.science = new System.Windows.Forms.TextBox();
            this.filipino = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Label();
            this.Average2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "English";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Math";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Science";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Filipino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "History";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 7;
            // 
            // english
            // 
            this.english.Location = new System.Drawing.Point(97, 104);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(100, 20);
            this.english.TabIndex = 8;
            // 
            // math
            // 
            this.math.Location = new System.Drawing.Point(97, 141);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(100, 20);
            this.math.TabIndex = 9;
            // 
            // science
            // 
            this.science.Location = new System.Drawing.Point(97, 178);
            this.science.Name = "science";
            this.science.Size = new System.Drawing.Size(100, 20);
            this.science.TabIndex = 10;
            // 
            // filipino
            // 
            this.filipino.Location = new System.Drawing.Point(97, 215);
            this.filipino.Name = "filipino";
            this.filipino.Size = new System.Drawing.Size(100, 20);
            this.filipino.TabIndex = 11;
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(97, 252);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(100, 20);
            this.history.TabIndex = 12;
            this.history.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Generate Average";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average.Location = new System.Drawing.Point(263, 165);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(75, 16);
            this.Average.TabIndex = 14;
            this.Average.Text = "passFailed";
            this.Average.Visible = false;
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // Average2
            // 
            this.Average2.AutoSize = true;
            this.Average2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average2.Location = new System.Drawing.Point(215, 183);
            this.Average2.Name = "Average2";
            this.Average2.Size = new System.Drawing.Size(73, 15);
            this.Average2.TabIndex = 15;
            this.Average2.Text = "nameGrade";
            this.Average2.Visible = false;
            // 
            // frmStudentGradeProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 379);
            this.Controls.Add(this.Average2);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.history);
            this.Controls.Add(this.filipino);
            this.Controls.Add(this.science);
            this.Controls.Add(this.math);
            this.Controls.Add(this.english);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentGradeProgram";
            this.Text = "frmStudentGradeProgram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox english;
        private System.Windows.Forms.TextBox math;
        private System.Windows.Forms.TextBox science;
        private System.Windows.Forms.TextBox filipino;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label Average2;
    }
}

