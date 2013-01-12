using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year {0} is leap", year);
            }
            else
            {
                Console.WriteLine("The year {0} is NOT leap", year);
            }

            Console.ReadLine();
        }
    }
}
