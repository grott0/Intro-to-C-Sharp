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
            int startRow = totalRows - 1;
            int startCol = 0;
            int startRowTop = 0;
            int startColTop = 1;
            int currentRow = startRow;
            int currentCol = startCol;
            int currentColTop = startColTop;
            int currentRowTop = startRowTop;

            //algorithm
            while (counter <= (totalRows * totalCols))
            {

                if (counter < (totalRows * totalCols) / 2)
                {
                    while (currentRow >= 0 && currentRow < totalRows
                        && currentCol < totalCols)
                    {
                        matrix[currentRow, currentCol] = counter;
                        currentCol++;
                        currentRow++;
                        counter++;

                    }
                    startRow--;
                    currentRow = startRow;
                    currentCol = startCol;
                }
                else
                {
                    while (currentColTop < totalCols && currentRow < totalRows)
                    {
                        matrix[currentRowTop, currentColTop] = counter;
                        currentColTop++;
                        currentRowTop++;
                        counter++;
                    }
                    startColTop++;
                    currentColTop = startColTop;
                    currentRowTop = startRowTop;
                }
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
