using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
     internal class Program
    {
        static void Main(string[] args)
        {

            // The numbers  are equal or not equal is

            Console.WriteLine("Enter first number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            if (a1 == a2)
            {
                Console.WriteLine(a1 + " and " + a2 + "is equal");
            }
            else if (a1 != a2)
            {
                Console.WriteLine(a1 + " and " + a2 + "is not equal");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();




            // Either +ve or -ve number are:-
            Console.WriteLine("Enter  the number is");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(a + " is positive number");
            }
            else if (a < 0)
            {
                Console.WriteLine(a + " is negative number ");
            }
            Console.ReadLine();


            // operations


            int num1, num2, Result;
            char operation;
            Console.Write("Enter the first number  is :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number is :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the operation");
            Console.WriteLine("1:- +");
            Console.WriteLine("2:- - ");
            Console.WriteLine("3:- * ");
            Console.WriteLine("4:- % ");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    Result = num1 + num2;
                    Console.WriteLine("The addition of two number is : {0}", Result);
                    break;
                case '2':
                    Result = num1 - num2;
                    Console.WriteLine("The subtraction of two number is : {0}", Result);
                    break;
                case '3':
                    Result = num1 * num2;
                    Console.WriteLine("The multiplication of two number is : {0}", Result);
                    break;
                case '4':
                    Result = num1 / num2;
                    Console.WriteLine("The division of two number is : {0}", Result);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;


            }
            Console.ReadLine();
        }
    }
}
        
    

