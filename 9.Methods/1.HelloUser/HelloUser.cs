using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.HelloUser
{
    class HelloUser
    {
        static void SayHello()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main(string[] args)
        {
            SayHello();
        }
    }
}
