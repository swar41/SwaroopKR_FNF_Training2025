using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    internal class ex01ConsoleIODemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            string age = Console.ReadLine();
            Console.WriteLine($"The name is :{name} and age is : {age}");
        }
    }
}
