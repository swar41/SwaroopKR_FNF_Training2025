using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LINQ to SQL is used to query databases using LINQ syntax. This was the first ORM (Object Relational Mapping) technology introduced by Microsoft. Currently, it is not actively developed, and Entity Framework is the recommended ORM technology. However, LINQ to SQL is still supported in .NET Core and .NET 5+. LINQ to SQL works with SQL Server databases and allows you to map database tables to C# classes, enabling you to work with data in a more object-oriented way.
//Server Explorer is configured with UR Database. 
//Add LINQ to SQL Classes item to the project.
//In the designer, drag and drop the tables you want to work with.
// This will generate the necessary classes and context for LINQ to SQL.
//DataContext is the class that represents the database connection and provides access to the tables in the form of properties. Every table in the database will have a corresponding property in the DataContext class in a pluralized name.

namespace SampleWinApp
{
    using SampleWinApp.Data;
    internal class ex28LINQtoSqlDemo
    {
        static void Main(string[] args)
        {
            //InsertEmp();
            //displayEmpInfo();
            //UpdateEmpInfo();
            UpdateNullDeptID();
        }
        private static void UpdateNullDeptID()
        {
            var context = new DataClasses1DataContext(); 
            Console.Write("Enter the name of the employee to update DeptID: ");
            string empName = Console.ReadLine();

            Console.Write("Enter the new Department ID: ");
            int newDeptID = Convert.ToInt32(Console.ReadLine());

            // Find the employee with matching name and null DeptID
            var emp = context.Employees.FirstOrDefault(e => e.EmpName.ToLower() == empName.ToLower() && e.DeptID == null);

            if (emp != null)
            {
                emp.DeptID = newDeptID;
                context.SubmitChanges();
                Console.WriteLine("DeptID updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found or DeptID is already set.");
            }
        }



        private static void UpdateEmpInfo()
        {
            var content = new DataClasses1DataContext(); // LINQ to SQL DataContext

            Console.Write("Enter the name of the employee to update: ");
            string searchName = Console.ReadLine();

            // Find the employee by name
            var emp = content.Employees.FirstOrDefault(e => e.EmpName == searchName);

            if (emp != null)
            {
                Console.Write("Enter new name: ");
                emp.EmpName = Console.ReadLine();

                Console.Write("Enter new address: ");
                emp.EmpAddress = Console.ReadLine();

                Console.Write("Enter new salary: ");
                emp.EmpSalary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter new department ID: ");
                emp.DeptID = Convert.ToInt32(Console.ReadLine());

                // Submit changes to the database
                content.SubmitChanges();
                Console.WriteLine("Employee information updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        private static void InsertEmp()
        {
            var emp = new Employee
            {
                EmpName = "new Emp",
                EmpAddress = "RNR",
                EmpSalary = 98200,
                DeptID = 2
            };
            var content = new DataClasses1DataContext(); //linq to sql file created in folder data
            content.Employees.InsertOnSubmit(emp);
            content.SubmitChanges();
        }

        private static void displayEmpInfo()
        {
            var content = new DataClasses1DataContext(); //linq to sql file created in folder data
            var res = from r in content.Employees where r.EmpSalary > 10000 select r;
            foreach (var item in res)
            {
                Console.WriteLine("Emp with more than 10000 salary: ");
                Console.WriteLine("Emp :" + item.EmpName + " Salary: " + item.EmpSalary);
            }
        }
    }
}
