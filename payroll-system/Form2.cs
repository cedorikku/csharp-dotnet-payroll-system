using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelper;

namespace payroll_system
{
    public partial class Form2 : Form
    {
        private string firstname, lastname;

        public Form2(UserInformation userInfo)
        {
            InitializeComponent();
            this.firstname = userInfo.Firstname; 
            this.lastname = userInfo.Lastname;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Welcome message
            LoadWelcomeMessage();
            LoadListItems();
            LoadDefaultValues();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Employee status not found", "Payroll System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbEmployeeStatus.Focus();
                return;
            }
            if (chkNonWorkDays.CheckedItems.Count == 6)
            {
                MessageBox.Show("Must not have all work days excluded. Please uncheck some boxes", "Payroll System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkNonWorkDays.Focus();
                return;
            }
            else if (chkNonWorkDays.CheckedItems.Count > 3)
            {
                MessageBox.Show("Minimum of 3 work days required. Please uncheck some boxes", "Payroll System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkNonWorkDays.Focus();
                return;
            }

            // int _difference = (dteEnd.Value - dteStart.Value).Days;
            // int _daysPerWeek = 6; // Sunday is excluded
            // foreach (var items in chkNonWorkDays.CheckedItems)
            // {
            //     _daysPerWeek--;
            // }
            /* COMMENTED FOR BACKUP PURPOSES */
        }

        private void dteStart_ValueChanged(object sender, EventArgs e)
        {
            // date1 = dteStart
            // date2 = dteEnd
            // checks to more than or equal 0 if date1 is later than or equal to date2
            if (DateTime.Compare(dteStart.Value, dteEnd.Value) >= 0)
            {
                dteEnd.Value = dteStart.Value;
                dteEnd.MinDate = dteStart.Value.AddDays(1);
            }
            // checks to less than 0 if date1 is earlier than date2
            else if (DateTime.Compare(dteStart.Value, dteEnd.Value) < 0)
            {
                dteEnd.MinDate = dteStart.Value.AddDays(1);
            }
        }

        private void LoadWelcomeMessage()
        {
            lblMessage.Text = "Welcome,";
            lblFullName.Text = firstname + " " + lastname;
        }

        private void LoadListItems()
        {
            var statusList = new List<string>()
            {
                "Permanent",
                "Probationary",
                "Contractual"
            };

            foreach (var item in statusList)
            {
                cmbEmployeeStatus.Items.Add(item);
            }
        }

        private void LoadDefaultValues()
        {
            // for the days worked controls
            dteStart.Value = DateTime.Now;
            dteEnd.Value = dteStart.Value.AddDays(1);
            dteEnd.MinDate = dteStart.Value.AddDays(1);

            var _nonworkdays = new ArrayList()
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            };

            foreach(var days in _nonworkdays)
            {
                chkNonWorkDays.Items.Add(days);
            }

            // for the payroll summary
            txtGrossPay.Text = "0.00";
            txtDeduction.Text = "0.00";
            txtNetPay.Text = "0.00";
        }
    }
}
