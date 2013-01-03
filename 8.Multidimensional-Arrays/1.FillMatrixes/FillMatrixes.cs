using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.FillMatrixes
{
    class FillMatrixes
    {
        static void PrintMatrix(int[,] matrix, int size)
        {
            for(int i = 0; i < size; i ++)
            {
                for(int j = 0; j < size; j ++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void FillMatrixA(ref int[,] matrix, int size)
        {
            int current = 1;
            for(int i = 0; i < size; i ++)
            {
                for(int j = 0; j < size; j ++)
                {
                    matrix[j, i] = current;
                    current++;
                }
            }
        }

        static void FillMatrixB(ref int[,] matrix, int size)
        {
            int current = 1;

            int x = 0, y = 0;
            while(current <= size * size)
            {
                if(x % 2 == 0)
                {
                    y = 0;
                    for(; y < size; y ++)
                    {
                        matrix[y, x] = current;
                        current++;
                    }
                }
                else
                {
                    y = size - 1;
                    for(; y >= 0; y --)
                    {
                        matrix[y, x] = current;
                        current++;
                    }
                }

                x++;
            }
        }

        private static void ArrangeDiagonalC(ref int startingNumber, int startX, int startY, int[,] matrix, int size)
        {
            int j = startX;
            for (int i = startY; i < size; i++)
            {
                matrix[i, j] = startingNumber;
                startingNumber++;
                j++;

                if (j == size)
                {
                    break;
                }
            }
        }

        private static void FillMatrixC(ref int[,] matrix, int size)
        {
            int currentNumber = 1;
            for (int i = size - 1; i >= 0; i--)
            {
                ArrangeDiagonalC(ref currentNumber, 0, i, matrix, size);
            }

            for (int i = 1; i < size; i++)
            {
                ArrangeDiagonalC(ref currentNumber, i, 0, matrix, size);
            }
        }

        private static void FillMatrixD(ref int[,] matrix, int size)
        {
            int count = 1;
            for(int i = 0, j = size - 1; j >= 0; i++, j--)
            {
                for (int k = i; k < j; k++)  
                {
                    matrix[k, i] = count;
                    count++;
                } 
                for (int k = i; k < j; k++) 
                {
                    matrix[j, k] = count;
                    count++;
                } 
                for (int k = j; k > i; k--)
                {
                    matrix[k, j] = count;
                    count++;
                } 
                for (int k = j; k > i; k--)
                {
                    matrix[i, k] = count;
                    count++;
                }
            }
        }

        static void Main(string[] args)
        {
            const int SIZE = 4;
            int[,] matrix = new int[SIZE, SIZE];

            FillMatrixA(ref matrix, SIZE);
            PrintMatrix(matrix, SIZE);
            Console.WriteLine("\n");

            FillMatrixB(ref matrix, SIZE);
            PrintMatrix(matrix, SIZE);
            Console.WriteLine("\n");

            FillMatrixC(ref matrix, SIZE);
            PrintMatrix(matrix, SIZE);
            Console.WriteLine("\n");

            FillMatrixD(ref matrix, SIZE);
            PrintMatrix(matrix, SIZE);

            Console.ReadLine();
        }
    }
}
