using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.MaximalSum
{
    class MaximalPlatformSum
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("M = ");
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, M];
            String inputNumber;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    inputNumber = Console.ReadLine();
                    matrix[i, j] = int.Parse(inputNumber);
                }
            }

            int maxSum = int.MinValue;
            for(int i = 0; i < N - 2; i ++)
            {
                for(int j = 0; j < M - 2; j ++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                              matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                              matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if(sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine("The max sum in");
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j ++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("is {0}", maxSum);
            Console.ReadLine();
        }
    }
}
