using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace _17.ReadDate
{
    class ReadDate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in the format day.month.year hour:minute:second: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            date = date.AddHours(6.5);
            Console.WriteLine("After 6 hours and 30 minutes: {0}, {1}", date, 
                date.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
