using System;

namespace Lab1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tocheck();
        }

        //To check for sum, prod, sub, div nclude the Switch case to get the arithmetic choice from the user.
        public static void Tocheck()
        {
            int num1, num2;
            char operand;

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0)
            {
                while (num1 == 0)
                {
                    Console.WriteLine("Please re-enter the first number:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                while (num2 == 0)
                {
                    Console.WriteLine("Please re-enter the second number:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Enter the operand you want:");
            operand = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The result is:");
            switch (operand)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;

                default:
                    break;
            }


        }
    }
}
