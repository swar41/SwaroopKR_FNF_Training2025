using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    internal class ex15Parameters
    {
        /*
                 * Parameters are used to pass values to methods. different types of parameters can be used in C# methods are ref,out, params and normal parameters.
                 * By default, parameters are passed by value, meaning a copy of the value is passed to the method.
                 * If you want to modify the original value, you can use the 'ref' or 'out' keywords.
                 * 'ref' allows you to pass a variable by reference, meaning changes made in the method will affect the original variable.
                 * 'out' is similar to 'ref', but it is used when you want to return multiple values from a method.
                 * difference between ref and out is that ref requires the variable to be initialized before passing it to the method, while out does not require initialization.
                 * params is used to pass a variable number of arguments to a method, allowing you to pass an array of values without explicitly creating an array.
                 */
        public static void pbref(int x)
        {
            x += 10; 
            Console.WriteLine("Inside pbref: " + x);
        }
        public static void outEx(int x,int y,out int res)//out parameter is used to return multiple values from a method.
        {
            res= x + y; // This will change the value of res in Main. when using out, the variable must be assigned before 
        }
        public static void refEx(int a,int b,ref int sub,  ref int mul) 
        {
            sub = a - b; // This will change the value of sub in Main.
            mul = a * b; // This will change the value of mul in Main.
        }
       
        public static void paramsEx(params int[] numbers) //params allows passing a variable number of arguments
        {
            int sum = 0;
            //Console.WriteLine($"Count:{numbers.Length}");
            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("\nSum of numbers: " + sum);
        }
        static void Main(string[] args)
        {
            int a = 20;
            pbref(a);
            Console.WriteLine("outside pbref: " + a); // a remains 10, as it was passed by value

            int b = 5, c = 15, result; //= 0;no need of initialising result here, as it will be assigned in the addd method
            outEx(b, c, out result);
            Console.WriteLine("\n addd: " + result); // result will be 20, as it was passed by reference using out

            int sub = 0, mul = 0;
            refEx(b, c, ref sub, ref mul);
            Console.WriteLine("\n calc: sub = " + sub + ", mul = " + mul);

            paramsEx(1, 2, 3, 4, 5); // passing variable number of arguments to paramsEx method
        }
    }
}
