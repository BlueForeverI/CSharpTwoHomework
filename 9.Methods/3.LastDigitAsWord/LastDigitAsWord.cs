using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LastDigitAsWord
{
    class LastDigitAsWord
    {
        static string GetLastDigit(int number)
        {
            char digit = number.ToString().Last();
            switch (digit)
            {
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eight";
                case '9':
                    return "nine";
                default:
                    return "zero";
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit is {0}", GetLastDigit(number));
        }
    }
}
