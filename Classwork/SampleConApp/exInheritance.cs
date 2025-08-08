using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//method overriding is a feature of OOP that allows a derived class to provide a specific implementation of a method that is already defined in its base class.
//child class can override a method of its parent class to provide a more specific implementation.base class method must be marked as "virtual or abstract" to allow overriding in derived classes and child class method must use the "override" keyword to indicate that it is overriding a base class method.

namespace SampleConsoleApp1
{
    enum payement
    {
        Cash,
        CreditCard,
        DebitCard,
        PayPal
    }
    class ParentClass
    {
        public virtual void payMet(double amount, payement PayementType)
        {
            if(PayementType == payement.Cash)
            {
                Console.WriteLine("Payment made in cash: " + amount);
            }
            else if (PayementType == payement.CreditCard)
            {
                Console.WriteLine("Payment made using Credit Card: " + amount);
            }
            else
            {
                Console.WriteLine("Payement Invalid");
            }
        }
        public void show()
        {
            Console.WriteLine("This is the Parent Class");
        }

    }
    class ChildClass : ParentClass
    {

        public override void payMet(double amount, payement PayementType)
        {
            if (PayementType == payement.DebitCard)
            {
                Console.WriteLine("Payment made using Debit Card: " + amount);
            }
            else if (PayementType == payement.PayPal)
            {
                Console.WriteLine("Payment made using PayPal: " + amount);
            }
            else
            {
                base.payMet(amount, PayementType);
            }
        }
    }
    internal class exInheritance
    {
        static ParentClass create()
        {
            Console.WriteLine("Enter P for Parent Class , S for Son Class ");
            string ch = Console.ReadLine();
            if(ch.ToUpper() == "P")
            {
                return new ParentClass();
            }
            else if (ch.ToUpper() == "S")
            {
                return new ChildClass();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return null;
            }
        }
        static void Main(string[] args)
        {
            ParentClass parent = create(); //Upcasting: Treating ParentClass as ParentClass
            if (parent == null)
            {
                Console.WriteLine("No object created, Exiting the program.");
                return;
            }
            parent.payMet(1000, payement.Cash);
            parent.payMet(2000, payement.CreditCard);
            parent.payMet(3000, payement.DebitCard);
            parent.payMet(9000, payement.PayPal);
            parent.show(); // Calls the method from ParentClass


            if (parent is ChildClass) //Downcasting: Treating ParentClass as ChildClass
            {
                //ChildClass child = (ChildClass)parent; // Explicit downcast
                ChildClass child2 = parent as ChildClass; // Safe downcast using 'as'
                Console.WriteLine("\nDowncasting to ChildClass:");
            }
            
        }
    }
}
