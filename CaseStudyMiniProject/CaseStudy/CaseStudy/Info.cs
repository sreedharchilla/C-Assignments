﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class info
    {
        public void display(Student student)
        {
            Console.WriteLine($"The student details is student id {student.Id}, student name {student.Name}, student dob {student.DOB}");

        }

        public void display(Course course)
        {
            Console.WriteLine($"the course id {course.Id}, course name {course.Name}, course duration is {course.duration}, course fee is {course.fees}");
        }

        public void displayEnrolldetails(Enroll enroll)
        {
            display(enroll._student);
            display(enroll._course);
            Console.WriteLine(enroll._dateTime);
        }
    }
}