using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    /* class is universal datatype , which involves set of oops features like encapsulationl,Inheritance, polymorphism, abstraction.   
    // Classes are user defined data types that can contain fields, methods, properties, events, and other members.
      *object is an instance of a class.
     */
    class Employee
    {
        //fields
        public string Name;
        int id;
        private long _salary;
        public int EmpID
        {
            get { return id; }
            set { id = value; }
        }
        public string EmpName
        {
            get { return Name; }
            set { Name = value; }
        }
        public long ealary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        //GetHashCode() is used to get a hash code for the object. It is used in collections like HashSet, Dictionary etc. The hash value is used to quickly locate the object in the collection.
        public override string ToString()
        {
            return EmpID.ToString();
        }
        public override int GetHashCode()
        {
            return EmpID;
        }
        //Implement the logical Equivalence for the Employee class.
        public override bool Equals(object? obj)
        {
            //If 2 EmpIds are same, then the objects are considered equal.
            if (obj is Employee emp)
            {
                if (this.EmpID == emp.EmpID)
                    return true;
                else return false;
            }
            return false; 
        }
    }
    class EmployeeRepo
    {
        List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            Console.WriteLine("Employee added successfully");
        }

        public Employee GetEmployee(int empId)
        {
            return employees.Find(emp => emp.EmpID == empId);
        }
        public void UpdateEmployee(Employee emp)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmpID == emp.EmpID)
                {
                    employees[i] = new Employee();
                    employees[i].EmpID = emp.EmpID;
                    employees[i].EmpName = emp.EmpName;
                    employees[i].ealary = emp.ealary;
                    Console.WriteLine($"Employee {emp.EmpName} updated successfully.");
                    return;
                }
            }
            Console.WriteLine("No Employee found to Update");
        }
        public void DeleteEmployee(int empId)
        {
            var rec = employees.Find(emp => emp.EmpID == empId);
            if (rec == null)
            {
                Console.WriteLine($"No Employee {empId} to delete.");
                return;
            }
            employees.Remove(rec); 
            Console.WriteLine($"ID {empId} deleted successfully.");
        }
        public Employee[] GetAllEmployees()
        {
            return employees.ToArray(); 
        }
    }
    internal class Ex08ClassesAndObjects
    {
        static EmployeeRepo employeeRepo = new EmployeeRepo();
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                Console.WriteLine("Enter the Choice as 1 to Add, 2 to find, 3 to Display All, 4 to Update and 5 to Delete");
                int choice = Convert.ToInt32(Console.ReadLine());
                processing = processMenu(choice);
            } while (processing);
        }
        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1: addEmployee(); return true;
                case 2: findEmployee(); return true;
                case 3: displayAllEmployees(); return true;
                case 4: updateEmployee(); return true;
                case 5: removeEmployee(); return true;
                default: Console.WriteLine("Invalid Choice"); return false;
            }
        }
        private static void removeEmployee()
        {
            int emptoremove = ConsoleUtil.GetInputInt("Enter employee id to remove");
            employeeRepo.DeleteEmployee(emptoremove);
        }

        private static void updateEmployee()
        {
            int emptoupdate = ConsoleUtil.GetInputInt("Enter employee id to update:");
            employeeRepo.UpdateEmployee(new Employee { EmpID = emptoupdate });
        }

        private static void displayAllEmployees()
        {
            var records = employeeRepo.GetAllEmployees();
            foreach (Employee emp in records)
            {
                Console.WriteLine($"ID={emp.EmpID}, Name={emp.EmpName}, Salary={emp.ealary} ");
            }
            Console.WriteLine("All Records are displayed");
        }

        private static void findEmployee()
        {
            Console.WriteLine("Enter the Employee ID to find");
            int empId = Convert.ToInt32(Console.ReadLine());
            Employee emp = employeeRepo.GetEmployee(empId);
            if (emp != null)
            {
                Console.WriteLine($"Employee Found: ID={emp.EmpID}, Name={emp.EmpName}, Salary={emp.ealary}");
            }
            else
            {
                Console.WriteLine($"No Employee found with ID {empId}");
            }
        }
        private static void addEmployee()
        {
            Employee emp = new Employee();
            emp.EmpID = ConsoleUtil.GetInputInt("Enter Employee ID");
            emp.EmpName = ConsoleUtil.GetInputString("Enter Employee Name");
            emp.ealary = ConsoleUtil.GetInputInt("Enter Employee Salary");
            employeeRepo.AddEmployee(emp);
        }
    }
    static class ConsoleUtil
    {
        public static string GetInputString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetInputInt(string question)
        {
            int val = 0;
            Console.WriteLine(question);
            int.TryParse(Console.ReadLine(), out val);//if any exception occurs while getting input , it returns default val as 0
            return val;
        }

        //public static double GetInputDouble(string question) => double.Parse(GetInputString(question));
        public static double GetInputDouble(string question)
        {
            double val= 0;
            Console.WriteLine(question);
            double.TryParse(Console.ReadLine(), out val);
            return (val);
        }
        public static char GetInputChar(string question)=> char.Parse(GetInputString(question));
    }
}
