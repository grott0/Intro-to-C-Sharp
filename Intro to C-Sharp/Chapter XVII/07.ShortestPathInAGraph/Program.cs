namespace _07.ShortestPathInAGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int currentRow = 0;
            int currentCol = 0;
            int iterator = 0;
            int cnt = 1;

            while (cnt <= n * n)
            {
                while (currentCol < (matrix.GetLength(1) - iterator))
                {
                    matrix[currentRow, currentCol] = cnt;
                    cnt++;
                    currentCol++;
                }

                currentCol--;
                currentRow++;

                while (currentRow < (matrix.GetLength(0) - iterator))
                {
                    matrix[currentRow, currentCol] = cnt;
                    cnt++;
                    currentRow++;
                }
                currentRow--;
                currentCol--;

                while (currentCol >= (0 + iterator))
                {
                    matrix[currentRow, currentCol] = cnt;
                    cnt++;
                    currentCol--;
                }
                currentCol++;
                currentRow--;

                while (currentRow >= (1 + iterator))
                {
                    matrix[currentRow, currentCol] = cnt;
                    cnt++;
                    currentRow--;
                }

                iterator++;
                currentRow = iterator;
                currentCol = iterator;
            }

            Print(matrix);
        }

        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
