using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _18.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string text = "I have two emails: pesho.ivanov@abv.bg and pesho.pp@gmail.com;"
                + "you can contact my boss at gosho@hotmail.com";

            Console.WriteLine("The text: {0}\n", text);

            var matches = Regex.Matches(text, "\\s[A-Za-z]+[\\.]*[A-Za-z0-9]+@[A-Za-z]*[A-Za-z0-9]+\\.[a-z]{2,3}");
            Console.WriteLine("The following emails were found: ");
            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString().Trim());
            }
        }
    }
}
