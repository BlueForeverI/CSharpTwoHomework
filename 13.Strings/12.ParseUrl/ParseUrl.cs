using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ParseUrl
{
    class ParseUrl
    {
        static void Main(string[] args)
        {
            string url = "http://zamunda.net/browse.php";

            string protocol = url.Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries).First();
            string server = url.Split(new string[] { "://" }, StringSplitOptions.None).Last().Split('/').First();
            string resource = url.Split(new string[] { server }, StringSplitOptions.None).Last();

            Console.WriteLine("URL: {0}", url);
            Console.WriteLine("Protocol: {0}", protocol);
            Console.WriteLine("Server: {0}", server);
            Console.WriteLine("Resource: {0}", resource);
        }
    }
}
