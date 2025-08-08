using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    class SuperClass
    {
        //public SuperClass()//default constructor
        //{
        //    Console.WriteLine("Super class default constructor called");
        //}
        public SuperClass(int x)//parameterized constructor
        {
            Console.WriteLine("Super class constructor with parameter called. partameter value is "+x);
        }
    }
    class BaseClass : SuperClass
    {
        //public BaseClass() : base(5) //calling the parameterized constructor of SuperClass
        //{
        //    Console.WriteLine("Base class default constructor called");
        //}
        
        public BaseClass(int x1) : base(x1)
        {
            Console.WriteLine("Base class constructor. the value is "+x1);
        }
    }
    internal class ex14Constructors
    {
        /*
         * Constructors are special methods that are invoked automatically when an object of that class is created.They have  same name as the class and do not have a return type.
         * when constructors are not defined, C# provides a default constructor that initializes fields to their default values(int to 0, reference type to null).
         * Constructors can be used to initialize fields or properties of a class.
         * If no constructor is defined, C# provides a default constructor that initializes fields to their default values.
         * You can define multiple constructors with different parameters (constructor overloading).
         */
        static void Main(string[] args)
        {
            //Creating an object of BaseClass will invoke
            BaseClass baseClass = new BaseClass(10);
        }
    }

}
