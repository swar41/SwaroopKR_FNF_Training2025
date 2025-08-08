using SampleConApp;
using SampleConsoleApp1p;
using System;
using System.IO;

namespace SampleConsoleApp1
{
    internal class ex21FileIO
    {
        const string filepath = "Customer.csv";
        static void Main(string[] args)
        {
            //GetFiles();
            //dire_creation();
            createCSV();
            var data = ReadCSV(filepath);
            foreach (var item in data)
            {
                Console.WriteLine(item.CustomerName);
            }
        }
        private static List<Customer> ReadCSV(string filepath)
        {
            Console.WriteLine("Read the file....");
            var text=File.ReadAllLines(filepath);
            var result = new List<Customer>();
            foreach (var item in text)
            {
                var words = item.Split(',');
                Customer customer = new Customer();
                customer.CustomerId = Convert.ToInt32(words[0]);
                customer.CustomerName = Convert.ToString(words[1]);
                customer.BillAmount = Convert.ToDouble(words[2]);
                result.Add(customer);
            }
            return result;
        }
        private static void createCSV()
        {
            Console.WriteLine("Creating csv...");
            var customer = new Customer
            {
                CustomerId = 1,
                CustomerName = "swar",
                BillAmount = 12000
            };
            
            var content=$"{ customer.CustomerId },{ customer.CustomerName},{ customer.BillAmount}\n";
            File.WriteAllText(filepath,content);
        }
        private static void dire_creation()
        {
            Console.WriteLine("Displaying Directories and its Info");
            var directorys = Directory.GetDirectories("C:\\Users\\phani\\OneDrive\\Documents");
            foreach (var dirPath in directorys)
            {
                var dir = new DirectoryInfo(dirPath);
                Console.WriteLine(dir.Name);
            }

            var newDir = "C:\\TestDir";
            var dirInfo = Directory.CreateDirectory(newDir);
            Console.WriteLine("new direcory created:");
            var parent = dirInfo.Parent;
            foreach (var dir_path in directorys)
            {
                var info = new DirectoryInfo(dir_path);
                foreach (var file in info.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
            }
        }
        private static void GetFiles()
        {
            var f = Directory.GetFiles("C:\\Users\\6152774\\Desktop");
            //Get files and its info within the diurectory
            foreach (var f2 in f)
            {
                var f_data = new FileInfo(f2);
                Console.WriteLine($"the name of file {f_data.Name} and created on {f_data.CreationTime}");
            }
        }

    }
}
