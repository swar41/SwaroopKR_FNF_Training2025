using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    /*Scenarios that disrupt the normal execution of a program are called exceptions.
     * ex:file not found, divide by zero, netwrokk issue, access issue etc.
     * c# does exception handling using try-catch-finally block.
     * try block contains the code that may throw an exception.
     * catch block contains the code that handles the exception(can be multiple).
     * finally block contains code that will always execute, regardless of whether an exception was thrown or not(is optional).
     * throw keyword is used to throw an exception manually.
     */

    /* apart from system exception, we can create our own custom exceptions by inheriting from the Exception class.
     * all exceptions in C# are derived from the System.Exception class.
     * custom exceptions should have suffix "Exception" in their class name.
     */
    /*internal class ex13ExceptionHandling
    {
        static void Main(string[] args)
        {
        RETRY:
            try
            {
                Console.WriteLine("Enter the n1 :");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter n2");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The result is" + (n1 / n2));
            }
            catch (OverflowException m1)
            {
                Console.WriteLine($"System exception message:{m1.Message}");
                Console.WriteLine($"Number should be in between {int.MinValue} and {int.MaxValue}");
                goto RETRY;

            }
            catch (ArithmeticException m2)
            {
                Console.WriteLine($"Arithmetic exception message:{m2.Message}");
                goto RETRY;
            }
            catch (FormatException m3)
            {
                Console.WriteLine($"Format exception message:{m3.Message}");
                Console.WriteLine("Invalid input value type ");
                goto RETRY;
            }
            //finally
            //{
            //    Console.WriteLine("This block always executes, regardless of an exception.");
            //}
        }
    }
    */
    internal class ex13ExceptionHandling
    {

        [Serializable]
        public class MyException : Exception
        {
            public MyException() { }
            public MyException(string message) : base(message) { }
            public MyException(string message, Exception inner) : base(message, inner) { }
            
        }
        public static void ThrowCustomException()
        {
            bool isDbConnected; // Simulating a database connection failure
            isDbConnected = bool.Parse(Console.ReadLine()); // Simulating a failed connection
            Console.WriteLine("My db connection started");

            if (!isDbConnected)
            {
                throw new MyException("db connection failed.");

            }
            Console.WriteLine("my db connnected");
        }
        static void Main(string[] args)
        {
            try
            {
                ThrowCustomException();
            }
            catch (MyException ex)// Catching custom exceptions. these are exceptions that are derived from the Exception class.
            {
                Console.WriteLine($"Custom Exception caught: {ex.Message}");
            }
            catch (Exception ex)// Catching general exceptions. these are exceptions that are not caught by the specific catch blocks above.
            {
                Console.WriteLine($"General Exception caught: {ex.Message}");
            }


        }
    }
}
