using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LongestSequence
{
    class LongestSequence
    {
        static bool Exists(string[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }

        static List<string> TraverseDiagonalForward(string[,] matrix, int row, int col)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[row, col]);

            if(Exists(matrix, row + 1, col + 1))
            {
                if(matrix[row + 1, col + 1] == matrix[row, col])
                {
                    return sequence.Concat(TraverseDiagonalForward(matrix, row + 1, col + 1)).ToList();
                }

                else
                {
                    return sequence;
                }
            }

            return sequence;
        }

        static List<string> TraverseDiagonalBackward(string[,] matrix, int row, int col)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[row, col]);

            if (Exists(matrix, row + 1, col - 1))
            {
                if (matrix[row + 1, col - 1] == matrix[row, col])
                {
                    return sequence.Concat(TraverseDiagonalBackward(matrix, row + 1, col - 1)).ToList();
                }

                else
                {
                    return sequence;
                }
            }

            return sequence;
        }

        static List<List<string>> ScanDiagonals(string[,] matrix)
        {
            List<List<string>> sequences = new List<List<string>>();

            for(int row = 0; row < matrix.GetLength(0); row ++)
            {
                for(int col = 0; col < matrix.GetLength(1); col ++)
                {
                    sequences.Add(TraverseDiagonalForward(matrix, row, col));
                    sequences.Add(TraverseDiagonalBackward(matrix, row, col));
                }
            }

            return sequences;
        }

        static List<string> TraverseHorizontal(string[,] matrix, int row, int col)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[row, col]);

            if (Exists(matrix, row, col + 1))
            {
                if (matrix[row, col + 1] == matrix[row, col])
                {
                    return sequence.Concat(TraverseHorizontal(matrix, row, col + 1)).ToList();
                }

                else
                {
                    return sequence;
                }
            }

            return sequence;
        }

        static List<List<string>> ScanHorizontals(string[,] matrix)
        {
            List<List<string>> sequences = new List<List<string>>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sequences.Add(TraverseHorizontal(matrix, row, col));
                }
            }

            return sequences;
        }

        static List<string> TraverseVertical(string[,] matrix, int row, int col)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[row, col]);

            if (Exists(matrix, row + 1, col))
            {
                if (matrix[row + 1, col] == matrix[row, col])
                {
                    return sequence.Concat(TraverseVertical(matrix, row + 1, col)).ToList();
                }

                else
                {
                    return sequence;
                }
            }

            return sequence;
        }

        static List<List<string>> ScanVerticals(string[,] matrix)
        {
            List<List<string>> sequences = new List<List<string>>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sequences.Add(TraverseVertical(matrix, row, col));
                }
            }

            return sequences;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter N: "); //cols
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter M: "); //rows
            int M = int.Parse(Console.ReadLine());

            string[,] matrix = new string[M, N];
            for(int i = 0; i < M; i ++)
            {
                for(int j = 0; j < N; j ++)
                {
                    Console.Write("matrix[{0}, {1}] = ", i, j);
                    matrix[i, j] = Console.ReadLine();
                }
            }

            var diagonals = ScanDiagonals(matrix);
            diagonals.Sort((x, y) => x.Count.CompareTo(y.Count));
            diagonals.RemoveRange(0, diagonals.Count - 1);

            var horizontals = ScanHorizontals(matrix);
            horizontals.Sort((x, y) => x.Count.CompareTo(y.Count));
            horizontals.RemoveRange(0, horizontals.Count - 1);

            var verticals = ScanVerticals(matrix);
            verticals.Sort((x, y) => x.Count.CompareTo(y.Count));
            verticals.RemoveRange(0, verticals.Count - 1);

            var longest = diagonals.Concat(horizontals).Concat(verticals).ToList();
            longest.Sort((x, y) => x.Count.CompareTo(y.Count));

            Console.WriteLine(string.Join(", ", longest.Last()));
        }
    }
}
