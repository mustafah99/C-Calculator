using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a C# Calculator!");

            while (true)
            {
                int num1 = 0; int num2 = 0;

                Console.WriteLine("Type the first number and then press enter.");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now type the second value and press enter.");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now choose an operand to start calculating the two given values.");
                Console.WriteLine("1.Addition \r\n2.Subtraktion \r\n3.Multiplication \r\n4.Division \r\n5.Modulus \r\n6.Exit");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine($"Your result: {num1} % {num2} = " + (num1 % num2));
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Console.WriteLine("Shutting down.");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
