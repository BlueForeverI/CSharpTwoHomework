using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.DaysBetweenDates
{
    class DaysBetweenDates
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the second date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            //in the presentation, the sample result shows that years don't matter
            firstDate = new DateTime(secondDate.Year, firstDate.Month, firstDate.Day);

            int days = (firstDate > secondDate)
                           ? firstDate.Subtract(secondDate).Days
                           : secondDate.Subtract(firstDate).Days;

            Console.WriteLine("Distance: {0} days", days);
        }
    }
}
