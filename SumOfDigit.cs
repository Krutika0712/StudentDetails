using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
     class SumOfDigit
    {
        public  void Digit()
        {
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;      // n=34 ,m=4   //n=3 ,m = 3  ---R
                sum = sum + m;    //sum=4        //sum=3+4=7
                n = n / 10;         // n= 3     //n=0-        ----Q
            }
            Console.Write("Sum is= " + sum);
        }
    }
}
