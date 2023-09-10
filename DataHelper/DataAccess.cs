using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
