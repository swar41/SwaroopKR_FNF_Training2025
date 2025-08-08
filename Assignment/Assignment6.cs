using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp1.Assignment
{
    internal class Assignment6
    {
        public static bool chk(int year, int month, int day)
        {
            //if (month < 1 || month > 12)
            //    return false;

            //int[] daysInMonth = { 31, (DateTime.IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //if (day < 1 || day > daysInMonth[month - 1])
            //    return false;
            //---------------------------------------------------

            if (day < 1 || day > DateTime.DaysInMonth(year, month))
                return false;

            //=-=======-------------------------------------------
            return true;
        }
        public static (int y,int m,int d) takeInput()
        {
            int year = ConsoleUtil.GetInputInt("ENter year");
            int month = ConsoleUtil.GetInputInt("ENter month");
            int day = ConsoleUtil.GetInputInt("ENter day");
            return (year, month, day);
        }
        static void Main(string[] args)
        {
            bool f = true;
            do
            {
                var (year, month, day) = takeInput();
                bool res = chk(year, month, day);
                if (res){
                    Console.WriteLine("Valid");
                }else{
                    Console.WriteLine("Invalid");
                }
                Console.WriteLine("y for retry ,, n for exit");
                String c = Console.ReadLine().ToLower();
                if (c == "n") 
                {
                    f = false;
                }
            } while (f);
        }
    }
}
