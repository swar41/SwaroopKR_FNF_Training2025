using Samplelib;
using Samplelib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SampleWinApp
{
    //using LINQ on XML is called XLINQ
    internal class XLINQDemo
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Create XML");
                Console.WriteLine("2. Display XML Data");
                Console.WriteLine("3. Add Element into XML");
                Console.WriteLine("4. Update Element in XML");
                Console.WriteLine("5. Delete Element from XML");
                Console.WriteLine("6. Read XML to Document");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        createXML();
                        break;
                    case "2":
                        displayXMLdata();
                        break;
                    case "3":
                        addElementintoXML();
                        break;
                    case "4":
                        updateElementinxml();
                        break;
                    case "5":
                        delElementinxml();
                        break;
                    case "6":
                        readXmlByName();
                        break;
                    case "0":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }


        private static void displayXMLdata()
        {
            var doc = XDocument.Load("EmpList.xml");
            Console.WriteLine(doc);
        }

        private static void delElementinxml()
        {
            Console.WriteLine("Enter the Name to delete");
            var name = Console.ReadLine();
            var doc = XDocument.Load("EmpList.xml");
            var found = (from rec in doc.Descendants("Employee")
                         where rec.Element("Name").Value == name
                         select rec).FirstOrDefault();//Every LINQ query returns an IEnumerable<T> collection. So  from it, U should select the first record.
            if (found != null)
            {
                found.Remove();
                doc.Save("EmpList.xml");//It overwrites the existing file.
                Console.WriteLine($"Record with Name {name} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"No record found with Name {name}.");
            }
        }
        

        private static void updateElementinxml()
        {
           
                // Load the XML document
                XDocument doc = XDocument.Load("EmpList.xml");

                // Get user input
                Console.Write("Enter the name of the employee to update: ");
                string searchName = Console.ReadLine();

                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();

                Console.Write("Enter new address: ");
                string newAddress = Console.ReadLine();

                Console.Write("Enter new salary: ");
                string newSalary = Console.ReadLine();

                Console.Write("Enter new department ID: ");
                string newDeptID = Console.ReadLine();

                // Find the employee element
                var employee = doc.Descendants("Employee")
                                  .FirstOrDefault(e => (string)e.Element("Name") == searchName);

                if (employee != null)
                {
                    employee.Element("Name").Value = newName;
                    employee.Element("Address").Value = newAddress;
                    employee.Element("Salary").Value = newSalary;
                    employee.Element("DeptID").Value = newDeptID;

                    // Save the updated document
                    doc.Save("EmpList.xml");
                    Console.WriteLine("Employee record updated successfully.");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            
       }

        private static void addElementintoXML()
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Department ID: ");
            int deptId = Convert.ToInt32(Console.ReadLine());

            var emp = new emp
            {
                EmpName = name,
                EmpAddress = address,
                EmpSalary = salary,
                DeptID = deptId
            };
            //Create an Xml Element with Details.
            var element = new XElement("Employee",
                new XElement("Name", emp.EmpName, new XAttribute("Gender", "Female")),
                new XElement("Address", emp.EmpAddress),
                new XElement("Salary", emp.EmpSalary),
                new XElement("DeptId", emp.DeptID));
            //Select the Doc where U need to insert the element.
            var doc = XDocument.Load("EmpList.xml");

            // Insert element at the beginning (after root but before other children)
            doc.Root.AddFirst(new XElement(element));

            // Insert the element before a specific employee (middle)
            var found = doc.Descendants("Employee")
                           .FirstOrDefault(e => (string)e.Element("Name") == "qwerty3");

            if (found != null)
            {
                found.AddBeforeSelf(new XElement(element));
            }
            else
            {
                Console.WriteLine("Employee with name 'qwerty3' not found.");
            }

            // Insert element at the end
            doc.Root.Add(new XElement(element));

            //Save the document.
            doc.Save("EmpList.xml");

        }

        public static void readXmlByName()
        {
            var doc = XDocument.Load("EmpList.xml");
            var empNames = from xelement in doc.Descendants("Employee")
                           select xelement.Element("Name").Value;
            foreach (var name in empNames)
            {
                Console.WriteLine(name);
            }
        }
        private static void createXML()
        {
            var data = new EmpDB().GetAllEmployees();
            XDocument xDocument = new XDocument(new XElement("EmpList", from emp in data
                                                                        select
                                                                        new XElement("Employee",
                                                                        new XElement("Name", emp.EmpName),
                                                                        new XElement("Address", emp.EmpAddress),
                                                                        new XElement("Salary", emp.EmpSalary),
                                                                        new XElement("DeptId", emp.DeptID))));
            xDocument.Save("EmpList.xml");
        }
    }
}
