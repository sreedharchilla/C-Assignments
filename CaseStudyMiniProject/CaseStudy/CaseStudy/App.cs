using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }

        public Student(int id, string name, string dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }

    }

    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public float fees;


        public Course(int id, string name, int dura, float fee)
        {
            this.Id = id;
            this.Name = name;
            this.duration = dura;
            this.fees = fee;
        }

    }
    class App
    {
        info info = new info();
        private static object std1;
        private static object std2;

        public void Scenerio1()
        {
            Student std = new Student(108, "Sreedhar", "27/07/1998");
            Student std1 = new Student(109, "Pavan", "06/06/2000");
            Student std2 = new Student(110, "kiran", "25/05/1999");

            info.display(std);
            info.display(std1);
        }

        public void Scenerio2()
        {
            Student[] stds = new Student[2];
            stds[0] = new Student(1111, "Raju", "5/01/2000");
            stds[1] = new Student(1112, "Manoj", "14/04/1998");
            stds[2] = new Student(1113, "Naveen", "21/10/1995");
            for (int i = 0; i < stds.Length; i++)
            {
                info.display(stds[i]);

            }
        }

        public void Scenerio3()
        {
            Console.WriteLine("please enter the no.of students you want");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] std = new Student[n];
            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine(" Please enter the Student Id,Name and Date of Birth");
                std[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            }
            for (int i = 0; i < std.Length; i++)
            {
                info.display(std[i]);
            }



        }
        static void Main(string[] args)
        {
            App app = new App();
            //app.Scenerio1();
            //app.Scenerio2();
            //app.Scenerio3();

            /* Student std1 = new Student(1, "Sreedhar", "27/03/1998");
             Student std2 = new Student(2, "Pavan", "06/06/2000");
             Student std3 = new Student(3,"Kiran", "25/05/1999");
             Course c1 = new Course(151,"java",60,34500.00f);
             Course c2 = new Course(152, "SqL",46,12000.00f);
             Course c3 = new Course(153, "DotNet",37,28000.00f);
            */
            AppEngine engine = new AppEngine();
            /*Console.WriteLine("Display the details using Arrays : ");
            Console.WriteLine();
            Console.WriteLine("The register Student Details is :");
            engine.register(std1);
            engine.register(std2);
            engine.register(std3);
            Console.WriteLine("******************************");
            Console.WriteLine();
            Console.WriteLine("The Course details is :");
            engine.introduce(c1);
            engine.introduce(c2);
            engine.introduce(c3);
            Console.WriteLine("*********************************");
            Console.WriteLine();
            AppEngine appEngine = new AppEngine();
            Console.WriteLine("The list of students is :");
            Student[] students = appEngine.listOfStudents();
            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Id}, {s.Name}, {s.DOB}");
            }
            Console.WriteLine("*********************************");
            Console.WriteLine();
            Console.WriteLine("The list of courses is :");
            Course[] courses = appEngine.listOfCourses();
            foreach (Course c in courses)
            {
                Console.WriteLine($"{c.Id}, {c.Name}, {c.duration},{c.fees}");
            }
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("the list of enrolls students and courses :");
            appEngine.enroll(std1, c1);
            appEngine.enroll(std2, c2);
            appEngine.enroll(std3, c3);
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Enroll[] enrolls = appEngine.listOfEnrollments();
            foreach (Enroll e in enrolls)
            {
                Info info = new Info();
                info.displayEnrolldetails(e);
            } */

            /*
            Console.WriteLine("Display the details using collections : ");
            Console.WriteLine();
            foreach(Student studentslist in engine.listOfStudents())
            {
                Console.WriteLine(studentslist.Id+" "+studentslist.Name+" "+studentslist.DOB);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            foreach (Course courselist in engine.listOfCourses())
            {
                Console.WriteLine(courselist.Id + " " + courselist.Name + " " + courselist.duration+" "+courselist.fees);
            }
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            var lists = from li in engine.listOfEnrollments()
                        select li;
            foreach (var s in lists)
            {
                Console.WriteLine(s._student.Id + " " + s._student.Name + " " + s._student.DOB);
                Console.WriteLine(s._course.Id + " " + s._course.Name + " " + s._course.duration + " " + s._course.fees);
                Console.WriteLine(s._dateTime);
            }
            */
            new UserInterFace().showFirstScreen();

            Console.Read();
        }
    }
}
