using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _19.ExtractDates
{
    class ExtractDates
    {
        static void Main(string[] args)
        {
            string text = "I was born at 06.05.1994 and today is 24.01.2013";
            Console.WriteLine("Text: {0}\n", text);

            var matches = Regex.Matches(text, "[0-9]{1,2}\\.[0-9]{1,2}\\.[0-9]{1,4}");
            Console.WriteLine("Dates found: ");
            foreach (var match in matches)
            {
                Console.WriteLine(DateTime.Parse(match.ToString()).ToString("",  new CultureInfo("en-CA")));
            }
        }
    }
}
