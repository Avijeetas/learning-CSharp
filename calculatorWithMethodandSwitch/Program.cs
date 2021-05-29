using System;

namespace calculatorWithMethodandSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of operation : ");
            string op = Console.ReadLine();

            int res = gocalculate(num1, num2, op);
            Console.WriteLine("The result is : " + res);
        }

        static int gocalculate(int num1, int num2, string op)
        {
            int res = 0;
            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    break;

                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                        res = 0;
                    else
                        res = num1 / num2;
                    break;
                case "%":
                    res = num1 % num2;
                    break;
            }
            return res;


        }
    }

}
