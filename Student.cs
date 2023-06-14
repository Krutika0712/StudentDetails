using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
     class Student
    {
        public void StudentDetails()
        {
            Console.WriteLine("*STUDENT DETAILS*");
            String studentName = Console.ReadLine();
            Console.WriteLine("Enter Your Roll No:");
            int rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter You Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Birth Date");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Your Phone number:");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you in division?");
            bool division = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine(studentName);

            Console.WriteLine("Student Name - {0} and Roll No - {1} ", name, rollno);
            if (division == true)
            {
                Console.WriteLine("{0} is in Divison A", name);
            }
            else if (division == false)
            {
                Console.WriteLine("{0} is in Divison B", name);
            }
            Console.WriteLine("Age is " + age);
            Console.WriteLine("Your Birth Date - " + dob.ToShortDateString());
            Console.WriteLine("Your Phone number - " + phone);
        }

    }
}
