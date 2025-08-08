
//LINQ is a library for performing queries on objects, XML and other kinds of data. It has been extended to even SQL server. 
//If U can get a collection of data from an external source, U can perform database kind of queries(Reading) from the collection instead of reading the whole collection all the time. LINQ help in optimizing the search in the collection and returns the specific data from the master collection. 
//LINQ was introduced in .NET 3.5 and made full fledged in .NET 4.0.
//LINQ comes with a set of keywords(from, group, order, by, where, select) as well as Extension methods that is applicable on all Collection classes. 
//A Collection class is one that implements IEnumerable<T> interface. 
//Extension methods are methods that are added at runtime to the instance without breaking the class. 
//LINQ Extension methods are available under System.Linq. 
using Samplelib;
using Samplelib.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
namespace SampleWinApp
{
    
    static class Ex27LINQ
    {
        /// <summary>
        /// Example on Method extended to String clas
        /// </summary>
        /// <param name="input">The String type to which this method is extended.</param>
        /// <returns>The no of words</returns>
        public static int GetWords(this string input)
        {
            //Every extension method must be static. It can return types. The arg list must have the 1st arg as this followed by the class and its variable to which this method is extended. 
            var words = input.Split(' ', ',', ';');
            return words.Length;
        }
    }

    class CsvHelper
    {
        public static List<Product> GetAllProducts()
        {
            var fileName = "C:\\Users\\6152774\\Downloads\\SampleData.csv";
            var lines = File.ReadAllLines(fileName);
            var products = new List<Product>();
            foreach (var line in lines)
            {
                var words = line.Split(',');
                var product = new Product();
                product.Id = Convert.ToInt32(words[0]);
                product.Description = words[1];
                product.Amount = Convert.ToDouble(words[2]);
                product.Date = DateTime.ParseExact(words[3], "M/d/yyyy", null);
                products.Add(product);
            }
            return products;
        }

    }

    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

    }

    internal class Ex04linqExample
    {
        
        static void Main(string[] args)
        {
            //var s = "once upon a time , there lived a ghost ..";
            //Console.WriteLine( s.GetWords()); //extension method for string class to count words;
            //readDescFromAmount(1.89);
            //readDescAndAmount();
            //readNamesAndAddress();
            //getEmployeesByGroup();
            //GroupEmployeesByAlpha();
            GetAllDep();
            joinEx();

        }

        private static void readDescAndAmount()
        {
            var masterData = CsvHelper.GetAllProducts();
            var results = from rec in masterData
                          orderby rec.Amount descending
                          select new { rec.Id, rec.Description, rec.Amount, rec.Date };
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
        private static void readDescFromAmount(double m)
        {
            var masterData = CsvHelper.GetAllProducts();
            var results = from rec in masterData where rec.Amount == m select new { rec.Id, rec.Description, rec.Date };
            //Note: LINQ executes only in foreach statement , not before it
            Console.WriteLine($"count: {results.Count()}");
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }

        private static void readNamesAndAddress()
        {
            EmpDB empDB = new EmpDB();
            List<emp> res = empDB.GetAllEmployees();
            
            var results = from rec in res
                          select new { rec.EmpName, rec.EmpAddress };
            foreach (var result in results)
            {
                Console.WriteLine($"{result.EmpName} on {result.EmpAddress}");
            }
        }
        private static void getEmployeesByGroup()
        {
            EmpDB empDB = new EmpDB();
            List<emp> res = empDB.GetAllEmployees();

            var results = from emp in res
                          orderby emp.EmpName
                          group emp.EmpAddress by emp.EmpAddress
                          into gr
                          orderby gr.Key
                          select gr;
            foreach (var gr in results)
            {
                Console.WriteLine("Employees in: "+gr.Key);
                foreach(var item in gr)
                {
                    Console.WriteLine($"{item}, ");

                }
                Console.WriteLine("\n\n");
            }
        }
        private static void GroupEmployeesByAlpha()
        {
            EmpDB empDB = new EmpDB();
            List<emp> res = empDB.GetAllEmployees();

            var results = from emp in res
                          group emp by emp.EmpName.Substring(0, 1).ToUpper() into gr
                          orderby gr.Key
                          select gr;

            foreach (var gr in results)
            {
                Console.WriteLine($"Employees starting with: {gr.Key}");
                foreach (var item in gr)
                {
                    Console.WriteLine($"{item.EmpName} - {item.EmpAddress}");
                }
                Console.WriteLine("\n");
            }
        }
        private static void GetAllDep()
        {
            EmpDB empDB = new EmpDB();
            List<Dept> res =empDB.GetAllDepts();

            var results = from Dept in res select new {Dept.DeptID, Dept.DeptName};

            foreach (var result in results)
            {
                Console.WriteLine($"Dept ID: {result.DeptID} and Name: {result.DeptName}");
            }
        }

        private static void joinEx()
        {
            EmpDB empDB = new EmpDB();
            List<emp> resE = empDB.GetAllEmployees();
            List<Dept> resd=empDB.GetAllDepts();

            var results = from emp in resE
                          join dept in resd
                          on emp.DeptID equals dept.DeptID
                          group new { emp, dept } by dept.DeptName
                          into gr
                          orderby gr.Key ascending select gr;
            foreach(var gr in results)
            {
                Console.WriteLine("Employees under :"+ gr.Key);
                foreach (var item in gr)
                {
                    Console.WriteLine($"{item.emp.EmpName} earns {item.emp.EmpSalary}");
                }
            }

        }
    }
}