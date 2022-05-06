using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class InterestAmount
    {
        double rate;

        public void loanCalculator(double loanamount)
        {
            Console.WriteLine(" The Enter rate of interest is");
            rate = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamount * rate) / 100;
            Console.WriteLine(" The Rate of interest  " + rate + "%  is : " + interest);
        }
    }
}
