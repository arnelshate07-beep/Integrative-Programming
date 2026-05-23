namespace Activity_Finals
{
    public partial class Form1 : Form
    {
        Administrator admin;

        public Form1()
        {
            InitializeComponent();

            admin = new Administrator(
                Program.CurrentAdminName,
                Program.CurrentUserId,
                Program.CurrentPassword
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserId.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "")
            {
                MessageBox.Show(
                    "User ID is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtAdminName.Focus();
                return;
            }

            if (pass == "")
            {
                MessageBox.Show(
                    "Password is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNewPassword.Focus();
                return;
            }

            if (admin.verifyLogin(user, pass))
            {
                MessageBox.Show(
                    "Login Successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Login.Visible = false;
                Dashboard.Visible = true;

                lblWelcome.Text = "Welcome, " + Program.CurrentAdminName;
                txtAdminName.Text = Program.CurrentAdminName;
            }
            else
            {
                MessageBox.Show(
                    "Invalid User ID or Password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newAdminName = txtAdminName.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (newAdminName == "")
            {
                MessageBox.Show(
                    "Admin name cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtAdminName.Focus();
                return;
            }

            if (newAdminName.Length < 5)
            {
                MessageBox.Show(
                    "Admin name must be at least 5 characters long.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtAdminName.Focus();
                return;
            }

            if (newPassword == "")
            {
                MessageBox.Show(
                    "New password is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNewPassword.Focus();
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNewPassword.Focus();
                return;
            }

            if (confirmPassword == "")
            {
                MessageBox.Show(
                    "Please confirm your password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtConfirmPassword.Focus();
                return;
            }

            if (!newPassword.Equals(confirmPassword))
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtConfirmPassword.Focus();
                return;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char c in newPassword)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }

                if (char.IsLower(c))
                {
                    hasLower = true;
                }

                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
            }

            if (!hasUpper)
            {
                MessageBox.Show(
                    "Password must contain at least one uppercase letter.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!hasLower)
            {
                MessageBox.Show(
                    "Password must contain at least one lowercase letter.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!hasNumber)
            {
                MessageBox.Show(
                    "Password must contain at least one number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            admin.updateAdminName(newAdminName);
            admin.updatePassword(newPassword);

            MessageBox.Show(
                "Administrator information updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Dashboard.Visible = false;
            Login.Visible = true;

            txtAdminName.Clear();
            txtNewPassword.Clear();

            txtAdminName.Focus();
        }
    }
}
