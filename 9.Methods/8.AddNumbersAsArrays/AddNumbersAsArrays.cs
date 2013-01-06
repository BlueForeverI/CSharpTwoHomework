using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.AddNumbersAsArrays
{
    class AddNumbersAsArrays
    {
        static int[] AddNumbers(int[] num1, int[] num2)
        {
            int maxLength = (num1.Length > num2.Length) ? num1.Length : num2.Length;
            var result = new int[maxLength + 1];

            for (int i = 0; i < maxLength; i ++)
            {
                int sum = 0;
                if(i >= num1.Length && i < num2.Length)
                {
                    sum = num2[i];
                }
                else if(i < num1.Length && i >= num2.Length)
                {
                    sum = num1[i];
                }
                else
                {
                    sum = num1[i] + num2[i];
                }

                if (sum >= 10)
                {
                    result[i] += sum - 10;
                    result[i + 1] = 1;
                }
                else
                {
                    result[i] += sum;
                }
            }

            if(result.Last() == 0)
            {
                var newResult = new int[maxLength];
                Array.Copy(result, newResult, maxLength);
                result = newResult;
            }

            return result.Reverse().ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number size: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] num1 = new int[size1];

            for (int i = 0; i < size1; i ++)
            {
                Console.Write("num1[{0}] = ", i);
                num1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter second number size: ");
            int size2 = int.Parse(Console.ReadLine());
            int[] num2 = new int[size1];

            for (int i = 0; i < size2; i++)
            {
                Console.Write("num2[{0}] = ", i);
                num2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The result is {0}", string.Join("", AddNumbers(num1, num2)));
        }
    }
}
