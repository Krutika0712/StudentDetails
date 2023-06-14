using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class CalculateAge
    {
        public void Age()
        {
            Console.Write("Enter your birthdate (MMDDYYYY): ");
            string birthdateString = Console.ReadLine();

            DateTime birthdate = ParseBirthdate(birthdateString);
            DateTime currentDate = DateTime.Now;

            int age = CalculateAge(birthdate, currentDate);

            Console.WriteLine($"Your current age is {age} years.");
            static DateTime ParseBirthdate(string birthdateString)
            {
                int month = int.Parse(birthdateString.Substring(0,2));
                int day = int.Parse(birthdateString.Substring(2,2));
                int year = int.Parse(birthdateString.Substring(4));

                return new DateTime(year, month, day);
            }

            static int CalculateAge(DateTime birthdate, DateTime currentDate)
            {
                int age = currentDate.Year - birthdate.Year; //23
                //age = 2023-2000 =23
                if (currentDate.Month < birthdate.Month || (currentDate.Month == birthdate.Month && currentDate.Day < birthdate.Day))
                {   //6<12 -- T || F
                    age--;   //23-1 =22
                }

                return age;   // 22
            }



        }
    }
}
