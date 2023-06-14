using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
   class Array
    {
        public void FindNumber()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 2, 3, 1, 0, 5 };

            int missingNumber = FindMissingNumber(array1, array2);

            Console.WriteLine("The missing number is: " + missingNumber);
        }

        static int FindMissingNumber(int[] array1, int[] array2)
        {
            foreach (int num in array1)
            {
                if (!array2.Contains(num))
                {
                    return num;
                }
            }

            return -1; // No missing number found  //false
        }
    }
}
