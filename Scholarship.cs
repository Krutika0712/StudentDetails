using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
     class Scholarship
    {
        public decimal Merit(decimal marks, decimal fees)
        {
            decimal scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2m * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3m * fees;
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5m * fees;
            }

            return scholarshipAmount;
        }
    }
}
