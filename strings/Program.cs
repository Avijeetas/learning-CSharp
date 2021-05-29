using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string a = Console.ReadLine();
            Console.WriteLine("The length of the string : " + a.Length);
            Console.WriteLine("The uppercase of input :" + a.ToUpper());
            Console.WriteLine("The lowercase of input :" + a.ToLower() + "\n");
            Console.WriteLine("The first chatacter of input : " + a[0]);
            Console.Write("\nInput a character to check : ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine("\n" + c + " is at index : " + a.IndexOf(c));

            Console.WriteLine(a.GetType());
        }
    }
}
