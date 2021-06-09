using System;

namespace Lab1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for exercise 1,3
            Tocheck();
            
            //****************************************************//
            
            //for exercise 4
            ToChekBalance();
        }

        //To check for sum, prod, sub, and div, include the Switch case to get the arithmetic choice from the user.
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
        
        //Wap to accept user's choice to check balance, withdraw or deposit / change pin- if the user selects check balance,
        //display the default cash value 1000Rs; for withdraw, deduct the balance and show the total balance; for deposit,
        //add the balance and show the total amount. Include the pin of the user to be validated.
        public static void ToChekBalance()
        {
            int cash = 1000;

            Console.WriteLine("Enter 1 if you want to check the balance,");
            Console.WriteLine();
            Console.WriteLine("Enter 2 if you want to withdraw,");
            Console.WriteLine();
            Console.WriteLine("Enter 3 if you want to deposit/change pin..");
            Console.WriteLine();

            string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    Console.WriteLine($"YOU HAVE {cash} SAR.");
                    break;

                case "2":
                    Console.WriteLine("what much the deduct balance?");
                    int d = Convert.ToInt32(Console.ReadLine());
                    if (cash > d)
                    {
                        cash = cash - d;
                    }
                    else
                    {
                        Console.WriteLine("This amount is greater than the basic amount");
                    }

                    Console.WriteLine();
                    Console.WriteLine($"YOU HAVE NOW {cash} SAR.");
                    break;

                case "3":
                    Console.WriteLine("what much the money you want to add? ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    cash = cash + b;

                    Console.WriteLine();
                    Console.WriteLine($"YOU HAVE NOW {cash} SAR.");
                    break;
                
                default:
                    Console.WriteLine($"YOU HAVE {cash} SR.");
                    break;
            }
        }
    }
}
