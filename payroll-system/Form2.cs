﻿using System;
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
                MessageBox.Show("Employee status not found");
                cmbEmployeeStatus.Focus();
                return;
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

            // for the payroll summary
            txtGrossPay.Text = "0.00";
            txtDeduction.Text = "0.00";
            txtNetPay.Text = "0.00";
        }

    }
}
