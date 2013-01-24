using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.ConvertToUnicode
{
    class ConvertToUnicode
    {
        static void Main(string[] args)
        {
            string text = "Hello world!";
            StringBuilder unicode = new StringBuilder();

            foreach (char character in text)
            { 
                string hex = Convert.ToString((int)character, 16);
                unicode.Append(string.Format("\\u{0}{1}", new string('0', 4 - hex.Length), hex));
            }

            Console.WriteLine("Original string: {0}", text);
            Console.WriteLine("Unicode: {0}", unicode);
        }
    }
}
