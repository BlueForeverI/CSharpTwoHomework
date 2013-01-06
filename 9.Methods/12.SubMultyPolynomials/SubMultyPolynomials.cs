using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.SubMultyPolynomials
{
    class SubMultyPolynomials
    {
        static int[] SubtractPolynomials(int[] poly1, int[] poly2)
        {
            int length = poly1.Length;
            var result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = poly1[i] - poly2[i];
            }

            return result;
        }

        static int[] MultiplyPolinomials(int[] poly1, int[] poly2)
        {
            List<int> result = new List<int>();
            int length = poly1.Length;

            for(int i = 0; i < length; i ++)
            {
                for(int j = 0; j < length; j ++)
                {
                    result.Add(poly1[i] * poly2[j]);
                }
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the coefficients of the first polynomial, separated by ' ': ");
            var coefs1 = Console.ReadLine().Split(' ').ToArray();
            coefs1 = coefs1.Reverse().ToArray();
            int[] poly1 = new int[coefs1.Length];

            for (int i = 0; i < coefs1.Length; i++)
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

            Console.WriteLine("The coefficients of the subtraction are: {0}",
                string.Join(", ", SubtractPolynomials(poly1, poly2)));

            Console.WriteLine("The coefficients of the multiplication are: {0}",
                string.Join(", ", MultiplyPolinomials(poly1, poly2)));
        }
    }
}
