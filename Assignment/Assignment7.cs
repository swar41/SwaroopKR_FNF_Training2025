using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1.Assignment
{
    internal class Assignment7
    {
        static bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            int n = (int)Math.Sqrt(num);
            for (int i = 3; i <= n; i += 2){
                if (num % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {

            int[] testNumbers = Console.ReadLine().Split('\t').Select(s => int.TryParse(s.Trim(),out int num)?num:0).ToArray();
            foreach (int num in testNumbers){
                string result = IsPrimeNumber(num) ? "prime number" : "not prime number";
                Console.WriteLine($"{num} is  {result}");
            }
        }
    }
}
