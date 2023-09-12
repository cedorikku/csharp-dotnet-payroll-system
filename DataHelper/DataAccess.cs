using System;
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

        public void employeePermanent(DateTimePicker startDate, DateTimePicker endDate, CheckedListBox nonWorkDays)
        {
            int days = getDaysWorked(startDate, endDate, nonWorkDays);
            double ratePerDay = 850;
            double sss = 500;
            double medicare = 350;
            double taxRate = 0.25;

            grossPay = computeGrossPay(days, ratePerDay);
            tax = computeTax(taxRate);
            deduction = computeDeduction(sss, medicare);
            netPay = computeNetPay();

            computeAll(days, ratePerDay, sss, medicare, taxRate);
        }

        public void employeeProbationary(DateTimePicker startDate, DateTimePicker endDate, CheckedListBox nonWorkDays)
        {
            int days = getDaysWorked(startDate, endDate, nonWorkDays);
            double ratePerDay = 550;
            double sss = 400;
            double medicare = 250;
            double taxRate = 0.15;

            grossPay = computeGrossPay(days, ratePerDay);
            tax = computeTax(taxRate);
            deduction = computeDeduction(sss, medicare);
            netPay = computeNetPay();

            computeAll(days, ratePerDay, sss, medicare, taxRate);
        }

        public void employeeContractual(DateTimePicker startDate, DateTimePicker endDate, CheckedListBox nonWorkDays)
        {
            int days = getDaysWorked(startDate, endDate, nonWorkDays);
            double ratePerDay = 350;
            double sss = 100;
            double medicare = 100;
            double taxRate = 0.1;

            computeAll(days, ratePerDay, sss, medicare, taxRate);
        }

        // executes everything with the right values
        private void computeAll(int days, double ratePerDay, double sss, double medicare, double taxRate)
        {
            grossPay = computeGrossPay(days, ratePerDay);
            tax = computeTax(taxRate);
            deduction = computeDeduction(sss, medicare);
            netPay = computeNetPay();
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
