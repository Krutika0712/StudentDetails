using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
     class UpperLower
    {
        public void Count()
        {
            int uppercaseCount = 0;
            int lowercaseCount = 0;
            int digitCount = 0;

            Console.WriteLine("Enter String");
            String line = Console.ReadLine();

            foreach (char c in line)
            {
                if (char.IsUpper(c))
                {
                    uppercaseCount++;
                }
                else if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }
            Console.WriteLine("Upper case letters : " + uppercaseCount);
            Console.WriteLine("Lower case letters : " + lowercaseCount);
            Console.WriteLine("digit Count : " + digitCount);


        }
    }
}
