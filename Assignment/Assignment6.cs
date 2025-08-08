using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Assignment6
    {
        static void Main(string[] args)
        {
            do
            {
                bool valid = false;
                int year = GetIntinput("Enter the Year: ");
                int month = GetIntinput("Enter the Month: ");
                int day = GetIntinput("Enter the Day: ");
                valid = IsValidDate(year, month, day);
                Console.WriteLine(valid); 
            } while (true);
        }

        private static bool IsValidDate(int year, int month, int day)
        {
            if((day <1 || day > 31) || (month<1 || month>12 ))
            {
                return false;
            }
            // leap year 
            else if (year % 400 ==0 || year % 4 ==0)
            {
                // leap year 2cd month have 29 days
                if(month == 2)
                {
                    if(day>29) return false;
                    else return true;
                }
                // months with 31 days
                else if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
                {
                    if (day < 32) return true;
                    else return false;
                }
                // months with 30 days
                else
                {
                    if (day > 30) return false;
                    else return true;
                }
            }
            // not leap year but to handle months with 31 days
            else if((month ==1) ||  (month == 3) || (month == 5) || (month == 7) || (month == 8)  || (month == 10) ||  (month == 12) ) {
                if (day < 32) return true;
                else return false;
            }
            
            // not a leap year 
            else if(month == 2)
            {
                if(day > 28) return false; 
                else return true;
            }
            // months with 30 days
            else
            {
                if (day > 30) return false;
                else return true;
            }
            
        }

        private static int GetIntinput(string v)
        {
            Console.WriteLine(v);
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        
    }
}
