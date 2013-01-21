using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _5.ReadMatrix
{
    class ReadMatrix
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("..\\..\\input.txt");
            int size = int.Parse(lines[0]);
            int[,] matrix = new int[size, size];

            string[] stringMatrix = new string[size];
            Array.Copy(lines, 1, stringMatrix, 0, size);

            for(int i = 0; i < size; i ++)
            {
                string[] numbers = stringMatrix[i].Split(' ');
                for(int j = 0; j < size; j ++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }

            int maxSum = int.MinValue;
            for(int i = 0; i < size - 1; i ++)
            {
                for(int j = 0; j < size - 1; j ++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j]
                              + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if(sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            File.WriteAllText("..\\..\\output.txt", maxSum.ToString());
            Console.WriteLine("Max sum saved in file output.txt");
        }
    }
}
