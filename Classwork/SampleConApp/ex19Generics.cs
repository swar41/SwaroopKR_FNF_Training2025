using System;
using System.Collections.Generic;


namespace SampleConsoleApp1.CustomCollection
{
    /*Generics is a feature of .NET that can allow to create classes , method and interface that can work on any kind of data type
     *Generics provide a way to define a class or method with a placeholder for the data type, which can be specified when the class or method is used.
     *They are said to be type safe, because they can enforce type constraints at compile time, reducing runtime errors. We don't have to unbox the data for operations.
    * List allows dupllicates and hashset doesnt.. hashset values are set to be unique.
     */
    internal class ex19Generics
    {
        private static void hashSetEx()
        {
            //HashSet<string> hash= new HashSet<string> ();
            //hash.Add("alice");
            //hash.Add("bob");
            //hash.Add("rsamesh");
            //hash.Add("shash");

            //if (!hash.Add("shash")) { 
            //    Console.WriteLine("name already in the hashset");
            //}
            //foreach(string name in hash)
            //{
            //    Console.WriteLine(name);
            //}

            HashSet<Employee> employees = new HashSet<Employee>();
            employees.Add(new Employee { EmpID = 1, EmpName = "Swar", ealary = 12000 });
            employees.Add(new Employee { EmpID = 2, EmpName = "Swer", ealary = 18000 });
            employees.Add(new Employee { EmpID = 3, EmpName = "wars", ealary = 32900 });
            employees.Add(new Employee { EmpID = 1, EmpName = "Swar", ealary = 12000 });
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmpName} earns a salary of {emp.ealary:C}");
            }

        }
        private static void listEx()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Insert(2, 5); // Insert 5 at index 2
            numbers.Remove(3); // Remove the number 3
            numbers.Sort(); // Sort the list in ascending order
            

            Console.WriteLine("Numbers in the list:");
            foreach (var number in numbers) {
                Console.WriteLine(number);
            }
            int toFind=ConsoleUtil.GetInputInt("Enter a number to find in the list");
            if (numbers.Contains(toFind))
            {
                Console.WriteLine("Number " + toFind + " found in the list." + numbers.IndexOf(toFind));
                
            }
            else
            {
                Console.WriteLine("Number " + toFind + " not found in the list.");
            }
        }

        private static void DictionaryEx()
        {
            //Similar to hashtable, it is type safe and doesnt allow null key ,stores data in key-value pair,
            Dictionary<string, string> creds= new Dictionary<string,string>();
            creds.Add("swar", "pass123");
            creds.Add("fnf", "test123");
            creds["swar"] = "123pass";//another way to add keyvalue data ,,but if key already exists then it updates new value..
            creds["akarsh"] = "qwer";
        retry:
            var uname = ConsoleUtil.GetInputString("Enter the username: ");
            var pass = ConsoleUtil.GetInputString("Enter the password: ");
            if(uname==null || pass == null)
            {
                Console.WriteLine("values cant be null ..");
                goto retry;
            }
            if (!creds.ContainsKey(uname))
            {
                Console.WriteLine("username doesnt exist..Register");
            }
            else if (creds[uname] == pass)
            {
                Console.WriteLine("Login Successfull");
            }
            else
            {
                Console.WriteLine("invalid");
                goto retry;
            }

        }
        static void Main(string[] args)
        {
            //listEx();
            //hashSetEx();
            DictionaryEx();
        }
    }
}
