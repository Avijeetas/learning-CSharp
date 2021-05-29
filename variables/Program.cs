using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the username : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.Read());
            Console.WriteLine("Your username : " + userName);
            Console.WriteLine("Your age : " + age);
            Console.ReadLine();


        }
    }
}
