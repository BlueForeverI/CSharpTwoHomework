using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.LargestArea
{
    class LargestArea
    {
        private static List<KeyValuePair<int, int>> visited = new List<KeyValuePair<int, int>>();

        static bool HasSameNeighbour(int[,] matrix, int row, int col, int nRow, int nCol)
        {
            if(nRow >= matrix.GetLength(0) || nRow < 0 || nCol >= matrix.GetLength(1) || nCol < 0)
            {
                return false;
            }
            if(matrix[row, col] == matrix[nRow, nCol])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetNumberOfNeighbours(int[,] matrix, int row, int col)
        {
            int count = 0;
            if (HasSameNeighbour(matrix, row, col, row + 1, col))
            {
                count++;
            }

            if (HasSameNeighbour(matrix, row, col, row - 1, col))
            {
                count++;
            }

            if (HasSameNeighbour(matrix, row, col, row, col + 1))
            {
                count++;
            }

            if (HasSameNeighbour(matrix, row, col, row, col - 1))
            {
                count++;
            }

            return count;
        }

        static int Search(int[, ] matrix, int row, int col)
        {
            visited.Add(new KeyValuePair<int, int>(row, col));
            int count = GetNumberOfNeighbours(matrix, row, col);
            if (HasSameNeighbour(matrix, row, col, row + 1, col))
            {
                if (!visited.Contains(new KeyValuePair<int, int>(row + 1, col)))
                count += (Search(matrix, row + 1, col) - 1);
            }

            if (HasSameNeighbour(matrix, row, col, row - 1, col))
            {
                if (!visited.Contains(new KeyValuePair<int, int>(row - 1, col)))
                count += (Search(matrix, row - 1, col) - 1);
            }

            if (HasSameNeighbour(matrix, row, col, row, col + 1))
            {
                if (!visited.Contains(new KeyValuePair<int, int>(row, col + 1)))
                count += (Search(matrix, row, col + 1) - 1);
            }

            if (HasSameNeighbour(matrix, row, col, row, col - 1))
            {
                if (!visited.Contains(new KeyValuePair<int, int>(row, col - 1)))
                count += (Search(matrix, row, col -1) - 1);
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of cols: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }

            List<int> areas = new List<int>();
            for(int row = 0; row < rows - 1; row ++)
            {
                for(int col = 0; col < cols - 1; col ++)
                {
                    areas.Add(Search(matrix, row, col) + 1);
                }
            }

            areas.Sort();
            Console.WriteLine("The lasrgest areas has {0} elements", areas.Last());
            Console.ReadLine();
        }
    }
}
