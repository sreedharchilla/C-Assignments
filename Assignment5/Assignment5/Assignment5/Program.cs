using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
        {

        }
    }
    public class Bank
    {
        string Acc_Number;
        string Acc_Name;
        float Amount = 32230.00f;
        float Bal;
       
       

        public Bank()
        {
            Console.WriteLine("Enter the Account Number is : ");
            Acc_Number = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            Acc_Name = Console.ReadLine();

            Console.WriteLine($"The Account details is : AccountNum {Acc_Number}, Acount Name {Acc_Name}, Amount is {Amount}");

        }


        public void DepositeAmount()
        {
            Console.WriteLine("Enter the Deposite Amount : ");
            float DepAmount = Convert.ToSingle(Console.ReadLine());

            if (DepAmount == 0)
            {
                Console.WriteLine("Deposite the minimum amount above is 500.00 ");

            }
            else
            {
                Bal = Amount + DepAmount;
                Console.WriteLine("Your Account Balance  Remaining is After amount deposite is : " + Bal);
            }
        }

        public void Amount_Withdrawn()
        {

            Console.WriteLine("Enter the WithDraw Amount is : ");
            float Withdrawn_Amount = Convert.ToSingle(Console.ReadLine());


            if (Withdrawn_Amount > Bal)
            {
                throw (new WithdrawnException("Doesn't have Insufficent balance"));
            }
            else
            {
                Bal = Bal - Withdrawn_Amount;
                Console.WriteLine("Your Account Balance is After With Draw the amount :" + Bal);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            try
            {
                b.DepositeAmount();
                b.Amount_Withdrawn();

            }
            catch (WithdrawnException xe)
            {
                Console.WriteLine(xe.Message);
            }
            catch (FormatException cs)
            {
                Console.WriteLine("Enter  The only numbers is ", cs);
            }
            Console.Read();
        }
    }
}

