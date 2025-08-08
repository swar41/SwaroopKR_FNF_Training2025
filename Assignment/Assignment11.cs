using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleConsoleApp1.Assignment
{
    internal class Assignment11
    {
        public static void Interest(double p, double r, double t, out double SI)
        {
            SI = (p * r * t) / 100;
        }
        public static (double, double, double) inp()
        {
            Console.WriteLine("Enter Principal Amount:");
            double pri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest:");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time in Years:");
            double time = Convert.ToDouble(Console.ReadLine());
            return (pri, rate, time);
        }
        static void Main(string[] args)
        {
            double principal, rate, time, SI;
            (principal, rate, time) = inp();
            Interest(principal, rate, time, out SI);
            Console.WriteLine($"Total amount is: {SI + principal}");

        }
    }
}
