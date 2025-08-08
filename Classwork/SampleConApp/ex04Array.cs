using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1
{
    internal class exArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1D Array");
            sdarray();// Single Dimensional Array
            Console.WriteLine("\n2D Array");
            mdarray();// Multi Dimensional Array
            Console.WriteLine("\nJagged Array");
            jdarray();// Jagged Array
        }
        private static void sdarray()
        {
            string[] names = new string[2];
            names[0] = "swar";
            names[1] = "swar";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }
        private static void mdarray()
        {
            int[,] arr = new int[2, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static void jdarray()
        {
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6,68,09 };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
