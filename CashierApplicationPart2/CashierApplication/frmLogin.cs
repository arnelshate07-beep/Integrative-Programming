using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users user = new Users(Program.CurrentUserId, Program.CurrentPassword);

            if (user.verifyLogin(txtUsername.Text.Trim(), txtPassword.Text))
            {
                MessageBox.Show("Welcome " + Program.CurrentUserName,
                    "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem(this);
                this.Hide();
                purchaseForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
