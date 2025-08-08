using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1.Assignment
{
    internal class Assignment4
    {
        static void print(Array array)
        {
            Console.WriteLine("Array contents:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void intArray(int size, Array a)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                int val = ConsoleUtil.GetInputInt("Enter the input ");
                ((int[])a)[i] = val;
            }
            print(a);
        }

        public static void doubleArray(int size, Array a)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                double val = ConsoleUtil.GetInputInt("Enter the input ");
                ((double[])a)[i] = val;
            }
            print(a);
        }

        public static void floatArray(int size, Array a)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                float val = ConsoleUtil.GetInputInt("Enter the input ");
                ((float[])a)[i] = val;
            }
            print(a);
        }

        public static void stringArray(int size, Array a)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                ((string[])a)[i] = Console.ReadLine() ?? string.Empty;
            }
            print(a);
        }

        static void Main(string[] args)
        {
            string type = ConsoleUtil.GetInputString("Enter the type of array (int, double, string):").ToLower();
            int size = ConsoleUtil.GetInputInt("Enter the size of arrray:");
            Array arr;
            switch (type)
            {
                case "int":
                    arr = new int[size];
                    intArray(size, arr);
                    break;

                case "double":
                    arr = new double[size];
                    doubleArray(size, arr);
                    break;
                case "float":
                    arr = new float[size];
                    floatArray(size, arr);
                    break;
                case "string":
                    arr = new string[size];
                    stringArray(size, arr);
                    break;
                default:
                    Console.WriteLine("Unsupported type.");
                    return;
            }
        }
    }
}
        