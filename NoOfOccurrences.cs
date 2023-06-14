using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class NoOfOccurrences
    {
        public  void CountOfString()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter a letter to count: ");
            char letter = Console.ReadLine()[0];

            int count = CountOccurrences(inputString, letter);

            Console.WriteLine($"The letter '{letter}' appears {count} times in the string.");
        }

        static int CountOccurrences(string inputString, char letter)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                if (c == letter)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
