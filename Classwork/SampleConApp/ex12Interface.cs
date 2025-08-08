using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    // An interface is a contract that defines a set of methods and properties that a class must implement.
    //interface is a reference type that defines a set of methods, properties, events, or indexers that a class or struct must implement.
    // Interfaces are used to achieve abstraction and multiple inheritance in C#.
    //cannot contain any implementation details, only method signatures and properties.
    //cannot have access modifiers (like public, private, etc.) on its members.

    //one or more classes can implement an interface, and a class can implement multiple interfaces.
    interface IEmpRepo
    {
        void AddEmployee(int id, string name, int age);
        void GetEmployee(int id);
        void RemoveEmployee(int id);
        void Show1();
    }
    interface IEmpRepo2
    {
        void GetAllEmployees();
        void Show1();

    }
    class Employeetype
    {
        public int Id;
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class empRepo : IEmpRepo, IEmpRepo2//Multiuple inheritance of interfaces
    {
        List<Employeetype> employees = new List<Employeetype>();
        public void AddEmployee(int id,string name, int age)
        {
            employees.Add(new Employeetype { Id =id, Age = age, Name = name }); 
            Console.WriteLine("Added");
        }

        public void GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void RemoveEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine($"Employee with ID {id} removed.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        public void GetAllEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}");
            }
        }
        //Explicit interface implementation
        void IEmpRepo.Show1()
        {
            Console.WriteLine("This is Show1 method from IEmpRepo interface.");
        }
        void IEmpRepo2.Show1()
        {
            Console.WriteLine("This is Show1 method from IEmpRepo2 interface.");
        }
    }
    internal class ex12Interface
    {
        static void Main(string[] args)
        {
            empRepo repo = new empRepo();
            repo.AddEmployee(1,"John Doe", 30);
            repo.AddEmployee(2, "Jane Smith", 25);
            repo.AddEmployee(3, "Alice Johnson", 28);
            repo.RemoveEmployee(2);
            repo.GetEmployee(1);

            repo.GetAllEmployees();
            //Explicit interface implementation
           // Calls the Show1 method from IEmpRepo2

            IEmpRepo empRepo1 = repo;
            empRepo1.Show1(); // Calls IEmpRepo.Show1()

            IEmpRepo2 empRepo2 = repo;
            empRepo2.Show1(); // Calls IEmpRepo2.Show1()
        }
    }
}
