using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ReadNumberMethod
{
    class ReadNumberMethod
    {
        static int ReadNumber(int start, int end)
        {
            Console.Write("Enter a number in the range [{0}, {1}]: ", start, end);
            int number;
            bool isValid = int.TryParse(Console.ReadLine(), out number);

            if(!isValid)
            {
                throw new Exception("Invalid number format");
            }

            if(number > end || number < start)
            {
                throw new Exception("The number is not in the specified range");
            }

            return number;
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i == 0)
                    {
                        array[i] = ReadNumber(2, 99);
                    }
                    else
                    {
                        array[i] = ReadNumber(array[i - 1], 99);
                    }
                }

                Console.WriteLine("You entered {0}", String.Join(", ", array));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
