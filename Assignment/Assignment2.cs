using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1.Assignment
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1); 
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine("Odd numbers in array: "); 
            foreach (var number in numbers)
            {
                if ((int)number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine("\nEven numbers in array: ");
            foreach (var number in numbers)
            {
                if ((int)number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
