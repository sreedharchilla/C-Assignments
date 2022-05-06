using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        //1.Name,Stdid,grade Student is passed or not
        abstract class Grade
        {
            public string name;
            public int studid;
            public float grade;
            abstract public Boolean Ispassed(float grade);
        }
        class undergraduate : Grade
        {
            public override Boolean Ispassed(float grade)
            {
                Console.WriteLine("Enter Name of the Student is:");
                name = Console.ReadLine();
                Console.WriteLine("Student Name:{0}", name);
                Console.WriteLine("Enter Student Id is:");
                studid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StudentId:{0}", studid);
                grade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("grade:{0}", grade);
                if (grade >= 70.0)
                {
                    Console.WriteLine("Student Grade is: ");
                    return true;
                }
                else
                {
                    Console.WriteLine("Student Grade is: ");
                    return false;
                }
            }
        }
        class graduate : Grade
        {
            public override Boolean Ispassed(float grade)
            {
                Console.WriteLine("Enter Name of the Student is:");
                name = Console.ReadLine();
                Console.WriteLine("Student Name:{0}", name);
                Console.WriteLine("Enter Student Id:");
                studid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StudentId:{0}", studid);
                if (grade >= 80.0)
                {
                    Console.WriteLine("Student's Grade is: ");
                    return true;
                }
                else
                {
                    Console.WriteLine("Student's Grade is: ");
                    return false;
                }
            }
        }
        class Abstract
        {
            public static void Main()
            {
                undergraduate ungrd = new undergraduate();
                Console.WriteLine(ungrd.Ispassed(70.0f));
                graduate grd = new graduate();
                Console.WriteLine(grd.Ispassed(80.0f));
            }


            //2.Create a emp class empId int,empName,string,salary float
            public class Employee
            {
                public int empId;
                public string empName;
                public float sal;

                public Employee(int empId, string empName, float sal)
                {
                    this.empId = empId;
                    this.empName = empName;
                    this.sal = sal;
                }
                public void dispDetails()
                {
                    Console.WriteLine(" The empName {empName} with empid {empId} gets salary of {sal}");
                }
            }
            public class PartTimeemployee
            {
                public int wages = 4500;

                public void showDetails()
                {
                    Console.WriteLine($"The parttime employee gets is " + wages);

                }
                static void Main(string[] args)
                {
                    Employee emp = new Employee(436, "pavan", 23500.9f);
                    emp.dispDetails();
                    PartTimeemployee pte = new PartTimeemployee();
                    pte.showDetails();
                }
            }
        }

        //3.create a class student and the child classes datscholar and hosteller
        public class Students
        {
            public int std_Id;
            public string std_Name;
            public double exam_fees;


            public void displayDetails()
            {
                Console.WriteLine("The student {std_Name} with id {std_Id} paid {exam_fees}");
            }
            public void payFees()
            {
                Console.WriteLine("Enter student id: ");
                std_Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student name: ");
                std_Name = Console.ReadLine();
                Console.WriteLine("The exam fees: is" + 1500);
                Console.WriteLine("Enter the amount  pay examfees");
                exam_fees = int.Parse(Console.ReadLine());
                double sem_fees = 1500 - exam_fees;
                if (exam_fees == 1500)
                {
                    Console.WriteLine(" Fees paid no dues");
                }
                else
                {
                    Console.WriteLine("The remaining fees: " + sem_fees);
                }
            }
        }
        class DayScholar
        {
            public double transport_fees;

            public DayScholar(double transport_fees)
            {
                this.transport_fees = transport_fees;
                double sem1_fees = 10000 - transport_fees;

                Console.WriteLine("The transport fees: " + 10000 + "per year ");


                Console.WriteLine("the dayscholar  paid {transport_fees} & remaining fee is {sem1_fees}");
                Console.ReadLine();
            }

        }
        public class Hosteller
        {
            public double hostel_fees;

            public Hosteller(double hostel_fees)
            {

                this.hostel_fees = hostel_fees;

                double sem2_fee = 52500 - hostel_fees;
                Console.WriteLine("The hostel  fees: " + 52500 + "per year ");

                Console.WriteLine("The dayscholar  paid {hostel_fees} & remaining fees is {sem2_fee} ");
                Console.ReadLine();
            }
        }



        static void Main(string[] args)
        {
            Students students = new Students();
            students.payFees();
            students.displayDetails();
            Console.WriteLine("Enter the tranport fees you to pay: ");
            DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the hostel fee you to pay: ");
            Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));

        }


    }
}
        
    

