using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Now is {0}", now.DayOfWeek);
            Console.ReadLine();
        }
    }
}
