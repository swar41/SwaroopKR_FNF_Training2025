using SampleConsoleApp.OperatorOverloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.OperatorOverloading
{
    class EMP
    {
        public  int EMP_ID {  get; set; }
        public string EMP_NAME {  get; set; }
        public  int EMP_SALARY {  get; set; }
        //overloading of operator is done by using static method using 'operator' keyword
        public static EMP operator + (EMP lhs,int rhs)
        {
            lhs.EMP_SALARY += rhs;
            return lhs;
        }
    }
}

namespace SampleConsoleApp.OperatorOverloading
{
    internal class ex25OperatorOverloading
    {
        //Operator overloading allows to have UR own opertors to be implemented for UR own classes. Usually we overload operators to make the code more readable. 
        static void Main(string[] args)
        {
            EMP e = new EMP { EMP_ID = 1, EMP_NAME = "swar", EMP_SALARY = 12000 };
            e += 3000;
            Console.WriteLine(e.EMP_SALARY);
        }

    }
}
