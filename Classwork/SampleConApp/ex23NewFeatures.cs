using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    internal class ex23NewFeatures
    {
        static Action<double> action;
        static void Main(string[] args)
        {
            //usingVar();
            //usingAnonymous();
            //actionEx();
            usingLambdainList();
        }

        private static void usingLambdainList()
        {
            var list = new List<Employee>
            {
                new Employee { EmpName="swar",EmpID=12 },
                new Employee{EmpName="wqe",EmpID=32}
            };
            int toFind = ConsoleUtil.GetInputInt("Enter ID of Employee to find: ");
            var res=list.Find((e)=>e.EmpID==toFind);
            Console.WriteLine(res.EmpName+" "+res.ealary);
        }

        private static void actionEx()
        {
            action = delegate (double x)//passing function as argument
            {
                Console.WriteLine("The number is : "+x);
            };
            action(23.3);
        }

        private static void usingAnonymous()
        {
            //anaonymous tytpes are objects created without an class definition. they are objects that contain only properties. they dont have methods , they behave like data carriers...
            var temp = new { name = "swar", Address = "blr" };
            Console.WriteLine($"the values are {temp.name}, from {temp.Address} and data type of this is: {temp.GetType}");
        }

        private static void usingVar()
        {
            var t = 123;
            var t2 = "swar";
            Console.WriteLine($"t={t.GetType} and t2={t2.GetType}");
        }
    }
}
