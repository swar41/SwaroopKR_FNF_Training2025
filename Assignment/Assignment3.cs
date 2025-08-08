using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1.Assignment
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double num1 = ConsoleUtil.GetInputDouble("ENter the First Number :");
                double num2 = ConsoleUtil.GetInputDouble("ENter the Second Number :");

                Console.WriteLine("Enter operator (+, -, *, /):");
                string op = Console.ReadLine();

                double result;
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero.");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                Console.WriteLine("Do you want to continue? (y/n):");
                string cont = Console.ReadLine();
                if (cont.ToLower() != "y")
                    break;
            }
        }
    }
}
