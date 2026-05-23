namespace Activity_Finals
{
    partial class Form1
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
            Login = new Panel();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtUserId = new TextBox();
            Dashboard = new Panel();
            button2 = new Button();
            label13 = new Label();
            label14 = new Label();
            txtConfirmPassword = new TextBox();
            buttonUpdate = new Button();
            label5 = new Label();
            label6 = new Label();
            txtNewPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblWelcome = new Label();
            label1 = new Label();
            txtAdminName = new TextBox();
            Login.SuspendLayout();
            Dashboard.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Controls.Add(button1);
            Login.Controls.Add(label7);
            Login.Controls.Add(label8);
            Login.Controls.Add(txtPassword);
            Login.Controls.Add(label9);
            Login.Controls.Add(label10);
            Login.Controls.Add(label11);
            Login.Controls.Add(label12);
            Login.Controls.Add(txtUserId);
            Login.Location = new Point(0, 0);
            Login.Name = "Login";
            Login.Size = new Size(354, 338);
            Login.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(119, 227);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 17;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLogin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(42, 175);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 16;
            label7.Text = "Password*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(227, 183);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 172);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 23);
            txtPassword.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(138, 178);
            label9.Name = "label9";
            label9.Size = new Size(0, 17);
            label9.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(48, 124);
            label10.Name = "label10";
            label10.Size = new Size(59, 17);
            label10.TabIndex = 12;
            label10.Text = "User ID*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(130, 46);
            label11.Name = "label11";
            label11.Size = new Size(99, 32);
            label11.TabIndex = 11;
            label11.Text = "ADMIN";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(229, 129);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 10;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(120, 121);
            txtUserId.Multiline = true;
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(192, 23);
            txtUserId.TabIndex = 9;
            // 
            // Dashboard
            // 
            Dashboard.Controls.Add(button2);
            Dashboard.Controls.Add(label13);
            Dashboard.Controls.Add(label14);
            Dashboard.Controls.Add(txtConfirmPassword);
            Dashboard.Controls.Add(buttonUpdate);
            Dashboard.Controls.Add(label5);
            Dashboard.Controls.Add(label6);
            Dashboard.Controls.Add(txtNewPassword);
            Dashboard.Controls.Add(label4);
            Dashboard.Controls.Add(label3);
            Dashboard.Controls.Add(lblWelcome);
            Dashboard.Controls.Add(label1);
            Dashboard.Controls.Add(txtAdminName);
            Dashboard.Location = new Point(0, 0);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(354, 333);
            Dashboard.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(189, 278);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 21;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnLogout_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(6, 226);
            label13.Name = "label13";
            label13.Size = new Size(126, 17);
            label13.TabIndex = 20;
            label13.Text = "Confirm Password*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(229, 231);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 19;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(138, 223);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(174, 23);
            txtConfirmPassword.TabIndex = 18;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(46, 278);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(119, 23);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(27, 175);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 16;
            label5.Text = "New Password*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 183);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 15;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(138, 172);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(174, 23);
            txtNewPassword.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(138, 178);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(34, 124);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 12;
            label3.Text = "Admin Name*";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(129, 46);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(99, 32);
            lblWelcome.TabIndex = 11;
            lblWelcome.Text = "ADMIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 129);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            // 
            // txtAdminName
            // 
            txtAdminName.Location = new Point(137, 121);
            txtAdminName.Multiline = true;
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(175, 23);
            txtAdminName.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(355, 336);
            Controls.Add(Login);
            Controls.Add(Dashboard);
            Name = "Form1";
            Text = "Form1";
            Login.ResumeLayout(false);
            Login.PerformLayout();
            Dashboard.ResumeLayout(false);
            Dashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Login;
        private Button button1;
        private Label label7;
        private Label label8;
        private TextBox txtPassword;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtUserId;
        private Panel Dashboard;
        private Label label13;
        private Label label14;
        private TextBox txtConfirmPassword;
        private Button buttonUpdate;
        private Label label5;
        private Label label6;
        private TextBox txtNewPassword;
        private Label label4;
        private Label label3;
        private Label lblWelcome;
        private Label label1;
        private TextBox txtAdminName;
        private Button button2;
    }
}
