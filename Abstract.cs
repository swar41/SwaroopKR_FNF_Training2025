using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    abstract class AbstractClass
    {
        // Abstract classes cannot be instantiated directly.
        public void ConcreteMethod()
        {
            Console.WriteLine("This is a concrete method in an abstract class.");
        }
        public abstract void AbstractMethod();


    }
    class DerivedClass : AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("This is an implementation of the abstract method.");
        }
    }
    internal class Abstract
    {
        static void Main(string[] args)
        {
            // AbstractClass ac = new AbstractClass(); // This line will cause a compile-time error because you cannot instantiate an abstract class.
            DerivedClass dc = new DerivedClass();
            dc.ConcreteMethod(); // Calling the concrete method from the abstract class
            dc.AbstractMethod(); // Calling the overridden abstract method
        }
    }
}
