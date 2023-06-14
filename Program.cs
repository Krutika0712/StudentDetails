using System;
using System.Threading.Channels;

namespace StudentDetails
{
    class StudentDetails
    {   
        public static void Main()
        {
            Console.WriteLine("-- Enter Your Choice:");
            Console.WriteLine("1 Student Details");
            Console.WriteLine("2 Count of Upper,Lower,Digit Case Character");
            Console.WriteLine("3 Find the Current Age");
            Console.WriteLine("4 Sum of the digit");
            Console.WriteLine("5 Array");
            Console.WriteLine("6 Count the no.of occurrences ");
            Console.WriteLine("7 Scholarship amount");
            Console.WriteLine("8 Binary Or Not");
            Console.WriteLine("Enter Your Choice");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == '1')
            {
                Student student = new Student();
                student.StudentDetails();

            }
            else if (choice == '2')
            {
                UpperLower upperLower = new UpperLower();
                upperLower.Count();
            }
            else if (choice == '3')
            {
                CalculateAge age = new CalculateAge();
                age.Age();
            }
            else if (choice == '4')
            {
                SumOfDigit sumOfDigit = new SumOfDigit();
                sumOfDigit.Digit();
            }
            else if (choice == '5')
            {
                Array array = new Array();
                array.FindNumber();
            }
            else if (choice == '6')
            {
                NoOfOccurrences noOfOccurrences = new NoOfOccurrences();
                noOfOccurrences.CountOfString();
            }
            else if (choice == '7')
            {
                Console.WriteLine("Enter Marks");
                int marks=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Fees");
                int fees = Convert.ToInt32(Console.ReadLine());
               

                Scholarship scholarship = new Scholarship();
                decimal scholarshipAmount = scholarship.Merit(marks, fees);

                Console.WriteLine("Scholarship amount: " + scholarshipAmount);

            }
            else if (choice == '8')
            {
                Console.WriteLine("Enter the number");
                String input = Console.ReadLine();

                bool isBinary = BinaryChecker.IsBinary(input);
                Console.WriteLine("Is Binary: " + isBinary);
            }

        }


    }
}