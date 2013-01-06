using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.AddPolinomials
{
    class AddPolinomials
    {
        static int[] AddPolinoms(int[] poly1, int[] poly2)
        {
            int maxLength = (poly1.Length > poly2.Length) ? poly1.Length : poly2.Length;
            var result = new int[maxLength + 1];

            for (int i = 0; i < maxLength; i++)
            {
                int sum = 0;
                if (i >= poly1.Length && i < poly2.Length)
                {
                    sum = poly2[i];
                }
                else if (i < poly1.Length && i >= poly2.Length)
                {
                    sum = poly1[i];
                }
                else
                {
                    sum = poly1[i] + poly2[i];
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

            if (result.Last() == 0)
            {
                var newResult = new int[maxLength];
                Array.Copy(result, newResult, maxLength);
                result = newResult;
            }

            return result.Reverse().ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the coefficients of the first polynomial, separated by ' ': ");
            var coefs1 = Console.ReadLine().Split(' ').ToArray();
            coefs1 = coefs1.Reverse().ToArray();
            int[] poly1 = new int[coefs1.Length];
            
            for(int i = 0; i < coefs1.Length; i ++)
            {
                poly1[i] = int.Parse(coefs1[i]);
            }

            Console.Write("Enter the coefficients of the second polynomial, separated by ' ': ");
            var coefs2 = Console.ReadLine().Split(' ').ToArray();
            coefs2 = coefs2.Reverse().ToArray();
            int[] poly2 = new int[coefs1.Length];

            for (int i = 0; i < coefs2.Length; i++)
            {
                poly2[i] = int.Parse(coefs2[i]);
            }

            Console.WriteLine("The coefficients of the resulting polynomial are: {0}",
                string.Join(", ", AddPolinoms(poly1, poly2)));
        }
    }
}
