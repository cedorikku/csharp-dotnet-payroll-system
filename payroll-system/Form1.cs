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
            txtFirstName.Text = "First Name";
            txtLastName.Text = "Last Name";
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = "";
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.Text = "First Name";
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = "";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.Text = "Last Name";
            }
        }
    }
}
