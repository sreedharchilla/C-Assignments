using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // The student marks program details is:
            Student student = new Student(121, "pavan", "B.tech", "2ndsem", "ECE");
            student.displaydata();
            student.displayresult();

            //  The car program details is:

            Car car = new Car(9999, "Benz", "Honda");
            car.displaycardetails();
            Car car2 = new Car(800000);

            // the  Loan amount calculator details is:

            InterestAmount ia = new InterestAmount();
            ia.loanCalculator(200000);
            Console.ReadLine();

        }
    }
}
