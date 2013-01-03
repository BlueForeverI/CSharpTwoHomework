using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.MatrixContainer
{
    class Matrix
    {
        private int[,] matrix;
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new int[Rows, Cols];
        }

        public int this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int row = 0; row < this.Rows; row ++)
            {
                for(int col = 0; col < this.Cols; col ++)
                {
                    sb.Append(string.Format("{0},\t", this[row, col]));
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }

        public static void ReadMatrix(Matrix matrix)
        {
            for(int row = 0; row < matrix.Rows; row ++)
            {
                for(int col = 0; col < matrix.Cols; col ++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Cols != matrix2.Cols || matrix1.Rows != matrix2.Rows)
            {
                throw new ArgumentException("The matrices should have equal dimensions");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);
            for(int row = 0; row < result.Rows; row ++)
            {
                for(int col = 0; col < result.Cols; col ++)
                {
                    result[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if(matrix1.Cols != matrix2.Cols || matrix1.Rows != matrix2.Rows)
            {
                throw new ArgumentException("The matrices should have equal dimensions");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = matrix1[row, col] - matrix2[row, col];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if(matrix1.Cols != matrix2.Rows)
            {
                throw new ArgumentException("The columns in the first matrix should be the same count as the rows in the second matrix");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = 0;
                    for(int k = 0; k < matrix1.Cols; k ++)
                    {
                        result[row, col] += matrix1[row, k]*matrix2[k, col];
                    }
                }
            }

            return result;
        }
    }
}
