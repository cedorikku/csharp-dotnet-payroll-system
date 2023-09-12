﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataHelper
{
    public class DataAccess
    {
        private double grossPay;
        private double tax;
        private double deduction;
        private double netPay;

        public double GrossPay { get => grossPay; set => grossPay = value; }
        public double Tax { get => tax; set => tax = value; }
        public double Deduction { get => deduction; set => deduction = value; }
        public double NetPay { get => netPay; set => netPay = value; }

        private void employeePermanent(int days)
        {
            double ratePerDay = 850;
            double sss = 500;
            double medicare = 350;
            double taxRate = 0.25;

        }

        private void employeeProbationary(int days)
        {
            double ratePerDay = 550;
            double sss = 400;
            double medicare = 250;
            double taxRate = 0.15;

        }

        private void employeeContractual(int days)
        {
            double ratePerDay = 350;
            double sss = 100;
            double medicare = 100;
            double taxRate = 0.1;

        }

        private double computeGrossPay(int days, double rate)
        {
            return days * rate;
        }

        private double computeTax(double taxRate)
        {
            return grossPay * taxRate;
        }

        private double computeDeduction(double sss, double medicare)
        {
            return sss + medicare + tax;
        }

        private double computeNetPay()
        {
            return grossPay - deduction;
        }

        private int getDaysWorked(DateTimePicker startDate, DateTimePicker endDate, CheckedListBox nonWorkDays)
        {
            int daysWorked = 0;
            for (DateTime dtStart = startDate.Value; dtStart <= endDate.Value; dtStart = dtStart.AddDays(1))
            {
                if (dtStart.DayOfWeek != DayOfWeek.Sunday && !nonWorkDays.CheckedItems.Contains(dtStart.DayOfWeek.ToString()))
                {
                    daysWorked++;
                }
            }
            return daysWorked;
        }

    }
}
