using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _25.ExtractFromHtml
{
    class ExtractFromHtml
    {
        static void Main(string[] args)
        {
            string html = "<html>" +
                          "<head><title>News</title></head>" +
                          "<body><p><a href=\"http://academy.telerik.com\">Telerik " +
                          "Academy</a>aims to provide free real-world practical " +
                          "training for young people who want to turn into " +
                          "skillful .NET software engineers.</p></body>" +
                          "</html>";

            string title = Regex.Replace(Regex.Match(html, "<title>[A-Za-z0-9\\s]+</title>").ToString(), "<[^<>]+>", " ").Trim();
            html = Regex.Replace(html, "<title>[A-Za-z0-9\\s]+</title>", "");
            string content = Regex.Replace(html, "<[^<>]+>", " ").Trim();


            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Body: {0}", content);
        }
    }
}
