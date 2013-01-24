using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _5.ToUpperCase
{
    class ToUpperCase
    {
        static void Main(string[] args)
        {
            string text =
                "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            string replaced = Regex.Replace(text, "<upcase>[^<>]+</upcase>", m => m.Value.ToUpper());
            replaced = replaced.Replace("<UPCASE>", string.Empty).Replace("</UPCASE>", string.Empty);
            Console.WriteLine(replaced);
        }
    }
}
