using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    internal class ex17DelegatesAndEvents
    {
        /*
         * Delegates are type-safe function pointers that used to pass methods as parameters, store methods in variables, and define callback methods.
         * it is signature of a method that can be used to call that method. it is maore like function type
         * delegates are type-safe, meaning they ensure that the method being called matches the delegate's signature.
         * 
         * func is a built-in delegate type in C# that can represent a method with a specific signature. 
         *func is generic delegate type that can take any number of parameters and return a value.and perform different operations based on the parameters passed to it.
         *different types of func delegates are available, such as Func<T>, Func<T1, T2>, Func<T1, T2, T3>, etc.
         *difference between func and delegate is that func is a built-in delegate type that can represent a method with a specific signature, while delegate is a user-defined type that can represent any method with a specific signature.
         */

        delegate double myDel(double x, double y);

        static void func(Func<double, double, double> someFunc)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double r = someFunc(a, b);
            Console.WriteLine("Result of the function is: " + r);
        }

        static void fun(myDel someFunc)
        {

            int a =int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r= (int)someFunc(a, b);
            Console.WriteLine("Result of the function is: " + r);
        }
        static double add(double x, double y)
        {
            Console.WriteLine("add called");
            return x + y;
        }
        static double sub(double x, double y)
        {
            Console.WriteLine("\nsub called");
            return x - y;
        }
        static void Main(string[] args)
        {
            fun(add);
            fun(sub); //or also can be given as fun((x, y) => x - y);
            func((x, y) => x * y); // using lambda expression to define the function inline
        }
    }
}
