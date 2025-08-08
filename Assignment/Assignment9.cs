using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1.Assignment
{
    internal class Assignment9
    {
        public static void reverseByWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            words.Reverse();
            string res = string.Join(" ", words);
            Console.WriteLine("the reversed:" + res);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence");
            string s = Console.ReadLine();
            reverseByWords(s);
        }
    }
}
