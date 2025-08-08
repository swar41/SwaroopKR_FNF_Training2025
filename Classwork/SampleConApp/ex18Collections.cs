    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SampleConsoleApp1
    {
        internal class ex18Collections
        {
            //collections are used to store and manage groups of related objects. C# provides several built-in collection types, such as arrays, lists, dictionaries, and queues. 2 types of collections are: Generic and Non-Generic.
            static Hashtable creds=new Hashtable();
            public static void ArrayListExample()
            {
                ArrayList numbers = new ArrayList(); // ArrayList is a non-generic collection that can store any type of object.
                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(6543);
                numbers.Add(4);
                foreach (var number in numbers)
                {
                    Console.WriteLine(number); // Output: 1, 2, three, 4.5
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if ((int)numbers[i] == 2)
                    {
                        Console.WriteLine("Number founddd\n");
                    }
                }
            }
            public static void HashTableExample() { 
                Hashtable table=new Hashtable();
                table.Add(1, "apple");
                table.Add(2, "mango");
                table.Add(3, "pear");
                foreach(var key in table.Keys)
                {
                    Console.WriteLine($"keys: " + key + " values:"  + table[key]);
                }
            }

            public static void validateUser(string uname, string password)
            {
                if (uname == null || password == null)
                {
                    Console.WriteLine("Empty creds");
                    return;
                }
                else if (creds[uname].ToString()== password)
                {
                    Console.WriteLine("Welcome !!");
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong creds");
                    return;
                }
            }
            public static void registerUser(string uname, string password)
            {
                if (creds.ContainsKey(uname))
                {
                    Console.WriteLine("Invlid username");
                    return;
                }
                else if (uname == null || password == null)
                {
                    Console.WriteLine("Empty creds");
                    return;
                }
                else
                {
                    creds[uname]= password;
                }
            }
            public static void HT2()
            {

               bool f = true;
                do
                {
                    
                    Console.Clear();
                    Console.WriteLine("Welcome to the login system");
                    Console.WriteLine("Enter l for login , r for registering.. e for exit");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    char c = input[0];
                    string uname = ConsoleUtil.GetInputString("Enter the username");
                    string passw = ConsoleUtil.GetInputString("Enter the password");
                    switch (c)
                    {
                        case 'l': validateUser(uname, passw); break;
                        case 'r': registerUser(uname, passw); break;
                        case 'e': f=false; break;
                    }

                } while (f);
            }


            static void Main(string[] args)
            {
                //ArrayListExample();
                //HashTableExample();
                HT2();
            }
        }
    }
