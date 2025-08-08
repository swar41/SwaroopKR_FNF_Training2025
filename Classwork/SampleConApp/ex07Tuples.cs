using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    //  Tuples are datatype that contain elements of different datatypes in structure.
    internal class ex07Tuples
    {
        static void Main(string[] args)
        {
            var t = (1, 98.7, "swa");
            Console.WriteLine(t);
            //named tuples(key - value data )
            var details = (Name: "swar", age: 32);
            Console.WriteLine(details.Name);

            var (longit, latit) = getCordinates();
            Console.WriteLine("The co-ordinates: " + longit);
        }
        static (double, double) getCordinates()
        {
            return (12.7, 32.8);
        }
    }
}
