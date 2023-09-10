using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = "First Name";
            txtLastName.Text = "Last Name";
            txtFirstName.ForeColor = Color.Gray;
            txtLastName.ForeColor = Color.Gray;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.ForeColor = Color.Black;
                txtFirstName.Text = "";
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.ForeColor = Color.Gray;
                txtFirstName.Text = "First Name";
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.ForeColor = Color.Black;
                txtLastName.Text = "";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.ForeColor = Color.Gray;
                txtLastName.Text = "Last Name";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                MessageBox.Show("Please fill-in your first name", "Payroll System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
                return;
            }

            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Focus();
                MessageBox.Show("Please fill-in your last name", "Payroll System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}
