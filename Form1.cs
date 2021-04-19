using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        int attempt = 0;

        BudgetPlanner testing = new BudgetPlanner();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String[] Username = { "user1" };
            String[] Password = { "pass1" };

            if (Username.Contains(txtUsername.Text) && Password.Contains(txtPassword.Text))
            {
                testing.Show();
                this.Hide();
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Text = "";
                txtUsername.Focus();
                attempt += 1;

                if(attempt == 1)
                {
                   MessageBox.Show("You entered incorrect details \n Please try again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
