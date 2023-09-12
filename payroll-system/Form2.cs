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
using System.Xml;
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
            LoadLabels();
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

            int _min = 4;
            if (chkNonWorkDays.CheckedItems.Count == 6)
            {
                MessageBox.Show("Must not have all work days excluded. Please uncheck some boxes", "Payroll System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkNonWorkDays.Focus();
                return;
            }
            else if (chkNonWorkDays.CheckedItems.Count > 6 - _min)
            {
                MessageBox.Show("Minimum of "+ _min +" work days per week required. Please uncheck some boxes", "Payroll System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkNonWorkDays.Focus();
                return;
            }

            // disable user controls
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            btnCompute.Enabled = false;

            btnReset.Visible = true;

            OutputPayroll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reenable user controls
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnCompute.Enabled = true;

            // reset payroll summary
            txtGrossPay.Text = "0.00";
            txtDeduction.Text = "0.00";
            txtNetPay.Text = "0.00";
            boxDaysOfWork.Text = "";
            txtWorkDays.Text = "0";

            btnReset.Visible = false;
        }

       
        private void OutputPayroll()
        {
            DataAccess _dataAccess = new DataAccess();

            string _employeeStatus = cmbEmployeeStatus.SelectedItem.ToString();
            int daysWorked = _dataAccess.getDaysWorked(dteStart, dteEnd, chkNonWorkDays);

            switch (_employeeStatus)
            {
                case "Permanent": 
                    _dataAccess.employeePermanent(daysWorked, chkNonWorkDays); break;
                case "Probationary": 
                    _dataAccess.employeeProbationary(daysWorked, chkNonWorkDays); break;
                case "Contractual": 
                    _dataAccess.employeeContractual(daysWorked, chkNonWorkDays); break;
                default: 
                    return;
            }

            txtGrossPay.Text = _dataAccess.GrossPay.ToString("#,###.00");
            txtDeduction.Text = _dataAccess.Deduction.ToString("#,###.00");
            txtNetPay.Text = _dataAccess.NetPay.ToString("#,###.00");

            txtWorkDays.Text = daysWorked.ToString();
            foreach (var days in chkNonWorkDays.Items) 
            {
                if (!chkNonWorkDays.CheckedItems.Contains(days))
                {
                    boxDaysOfWork.AppendText(days.ToString() + "\n");
                }
            }
        }

        private void dteStart_ValueChanged(object sender, EventArgs e)
        {
            // date1 = dteStart
            // date2 = dteEnd
            // checks to more than or equal 0 if date1 is later than or equal to date2
            if (DateTime.Compare(dteStart.Value, dteEnd.Value) >= 0)
            {
                dteEnd.Value = dteStart.Value;
                dteEnd.MinDate = dteStart.Value.AddDays(7);
            }
            // checks to less than 0 if date1 is earlier than date2
            else if (DateTime.Compare(dteStart.Value, dteEnd.Value) < 0)
            {
                dteEnd.MinDate = dteStart.Value.AddDays(7);
            }
        }
        private void LoadLabels()
        {
            lblMessage.Text = "Laging Lugi";
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
            dteEnd.Value = dteStart.Value.AddDays(7);
            dteEnd.MinDate = dteStart.Value.AddDays(7);

            // for the checkboxlist control
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


            // for the work days output
            boxDaysOfWork.Text = "";
            txtWorkDays.Text = "0";
        }
    }
}
