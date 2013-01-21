using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _10.ExtractFromXml
{
    class ExtractFromXml
    {
        static void Main(string[] args)
        {
            string filePath = "..\\..\\file.xml";
            string content = File.ReadAllText(filePath);
            string newContent = Regex.Replace(content, "<[^<>]+>", "");

            File.WriteAllText(filePath, newContent);
            Console.WriteLine("Text from XML file extracted");
        }
    }
}
