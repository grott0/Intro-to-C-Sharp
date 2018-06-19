namespace _18.ShortestPaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = ReadMatrix(n);
            int startingRow = GetStartingCoordinates(matrix).Item1;
            int startingCol = GetStartingCoordinates(matrix).Item2;
            FindPaths(startingRow, startingCol, matrix, 0);
            Console.WriteLine();
            Print(matrix);
        }

        private static void Print(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == "0")
                    {
                        matrix[i, j] = "u";
                    }

                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static Tuple<int,int> GetStartingCoordinates(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == "*")
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }

            throw new Exception("Couldn't find the starting positions.");
        }

        static void FindPaths(int row, int col, string[,] matrix, int steps)
        {
            if (row > matrix.GetLength(0) - 1 ||
                row < 0 ||
                col > matrix.GetLength(1) - 1||
                col < 0 ||
                matrix[row, col] == "x")
            {
                return;
            }

            if (matrix[row,col] != "*")
            {
                int currentPosValue = int.Parse(matrix[row, col]);

                if (currentPosValue > 0 && currentPosValue <= steps)
                {
                    return;
                }

                matrix[row, col] = steps.ToString();
            }

            FindPaths(row, col + 1, matrix, steps + 1); // try right
            FindPaths(row, col - 1, matrix, steps + 1); // try left
            FindPaths(row - 1, col, matrix, steps + 1); // try up
            FindPaths(row + 1, col, matrix, steps + 1); // try down
        }

        private static string[,] ReadMatrix(int n)
        {
            string[,] matrix = new string[n, n];

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j].ToString();
                }
            }

            return matrix;
        }
    }
}
