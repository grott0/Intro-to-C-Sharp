using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MatrixA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            int counter = 1;
            int currentRow = 0;
            int currentCol = 0;

            //algorithm
            while (counter < rows * cols)
            {
                while (currentRow < rows)
                {
                    matrix[currentRow, currentCol] = counter;
                    counter++;
                    currentRow++;
                }
                currentRow = 0;
                currentCol++;
            }

            //print
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
