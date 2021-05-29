using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(marks);
            if (marks > 100)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (marks > 80)
            {
                Console.WriteLine("You got A+");
            }
            else if (marks > 70 && marks <= 80)
            {
                Console.WriteLine("You got A");
            }
            else if (marks > 60 && marks <= 70)
            {
                Console.WriteLine("You got A-");
            }
            else if (marks <= 60)
            {
                Console.WriteLine("You are fail.");
            }

        }
    }
}
