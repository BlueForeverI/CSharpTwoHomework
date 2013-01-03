using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.MatrixContainer
{
    class MatrixContainer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows for matrix1: ");
            int rows1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns for matrix1: ");
            int cols1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter matrix1:");
            Matrix matrix1 = new Matrix(rows1, cols1);
            Matrix.ReadMatrix(matrix1);

            Console.Write("Enter number of rows for matrix2: ");
            int rows2 = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns for matrix2: ");
            int cols2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter matrix2:");
            Matrix matrix2 = new Matrix(rows2, cols2);
            Matrix.ReadMatrix(matrix2);

            Console.WriteLine("Added:\n{0}", matrix1 + matrix2);
            Console.WriteLine("Subtracted:\n{0}", matrix1 - matrix2);
            Console.WriteLine("Multiplied:\n{0}", matrix1 * matrix2);
            Console.ReadLine();
        }
    }
}
