using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.PrintSquareRoot
{
    class PrintSquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if(number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Square root: {0}", Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
