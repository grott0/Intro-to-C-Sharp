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
            int totalRows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int totalCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[totalRows, totalCols];
            int counter = 1;
            int currentRow = 0;
            int currentCol = 0;
            int iteration = 0;

            //algorithm
            while (counter <= totalRows * totalCols)
            {
                while (currentRow < totalRows - iteration)
                {
                    matrix[currentRow, currentCol] = counter;
                    currentRow++;
                    counter++;
                }
                //currentRow == totalRows;
                currentRow--; // currentRow == totalRows - 1;
                currentCol++;

                while (currentCol < totalCols - iteration)
                {
                    matrix[currentRow, currentCol] = counter;
                    currentCol++;
                    counter++;
                }
                //currentCol = totalCols;
                currentCol--; //currentCol = totalCols - 1;
                currentRow--; //currentRow == totalRows - 2;

                while (currentRow >= 0 + iteration)
                {
                    matrix[currentRow, currentCol] = counter;
                    currentRow--;
                    counter++;
                }
                //currentRow == -1;
                currentRow++; //currentRow == 0
                currentCol--; //currentCol = totalCols - 2;

                while (currentCol >= 1 + iteration)
                {
                    matrix[currentRow, currentCol] = counter;
                    currentCol--;
                    counter++;
                }
                //currentCol == -1;
                currentCol++;
                currentRow++; //currentRow == 1;
                iteration++;

            }

            //print
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalCols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
