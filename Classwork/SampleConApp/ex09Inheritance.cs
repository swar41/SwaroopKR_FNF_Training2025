using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{

    class Base//this class is internal , accessible only within the same assembly/project. if you want to make it public, change the keyword to public.
    {
               public virtual void Display()
        {
            Console.WriteLine("Base class display method");
        }

    }
    //derived class inherits from Base classif u want to add new functionality or override existing functionality, use the 'override' keyword.. any class is immutable by default, to make it mutable, use the 'virtual' keyword in the method.
    //C# doesnt support multiple inheritance, so a class can only inherit from one base class. However, it can implement multiple interfaces.
    class Derived : Base 
    {
        public override void Display()
        {
            Console.WriteLine("Derived class display method");
        }
        public void AdditionalMethod()
        {
            Console.WriteLine("This is an additional method in the Derived class.");
        }
    }
     class ex09Inheritance
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.Display(); // Calls the overridden method in Derived class
            derived.AdditionalMethod(); // Calls the additional method in Derived class
        }
    }
}
