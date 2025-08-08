using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1.Assignment
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            // Integral types
            Console.WriteLine("Range of short: ");
            Console.WriteLine($"Min: {short.MinValue}, Max: {short.MaxValue}");
            Console.WriteLine("Range of int:");
            Console.WriteLine($"Min: {int.MinValue}, Max: {int.MaxValue}");
            Console.WriteLine("Range of long: ");
            Console.WriteLine($"Min: {long.MinValue}, Max: {long.MaxValue}");

            // Floating point types..
            Console.WriteLine("Range of float:");
            Console.WriteLine($"Min: {float.MinValue}, Max: {float.MaxValue}");
            Console.WriteLine("Range of double: ");
            Console.WriteLine($"Min: {double.MinValue}, Max: {double.MaxValue}");
            Console.WriteLine("Range of decimal:");
            Console.WriteLine($"Min: {decimal.MinValue}, Max: {decimal.MaxValue}");
        }
    }
}
