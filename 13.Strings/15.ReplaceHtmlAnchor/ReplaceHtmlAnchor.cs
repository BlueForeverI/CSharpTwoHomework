using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.ReplaceHtmlAnchor
{
    class ReplaceHtmlAnchor
    {
        static void Main(string[] args)
        {
            string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a>" +
                          " to choose a training course. Also visit <a href=\"www.devbg.org\">" + 
                          "our forum</a> to discuss the courses.</p>";

            string replaced = html.Replace("<a href=\"", "[URL=").Replace("\">", "]")
                .Replace("</a>", "[/URL]");
            Console.WriteLine(replaced);
        }
    }
}
