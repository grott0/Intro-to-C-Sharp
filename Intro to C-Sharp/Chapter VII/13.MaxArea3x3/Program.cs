using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MaxArea3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of rows: ");
            int totalRows = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of columns: ");
            int totalCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[totalRows, totalCols];
            Random rnd = new Random();
            //initialize the array with random elements;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 51);
                }
            }

            //algorithm
            int currentSum = 0;
            int maxSum = int.MinValue;
            int maxIndexRow = 0; // the indexes for which the maxSum is found
            int maxIndexCol = 0; 

            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    currentSum = matrix[i, j] + matrix[i, j - 1] + matrix[i, j + 1]
                        + matrix[i - 1, j] + matrix[i - 1, j - 1] + matrix[i - 1, j + 1]
                        + matrix[i + 1, j] + matrix[i + 1, j - 1] + matrix[i + 1, j + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxIndexRow = i;
                        maxIndexCol = j;
                    }
                }
                //don't need to clear the sum, it's getting reinitialized for every loop
            }


            //print result
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The max sum of a 3x3 area is: {0}", maxSum);
            Console.WriteLine("The 3x3 area with the max sum: ");
            Console.WriteLine(matrix[maxIndexRow - 1, maxIndexCol - 1] + " "
                + matrix[maxIndexRow - 1, maxIndexCol] + " "
                + matrix[maxIndexRow - 1, maxIndexCol + 1]);
            Console.WriteLine(matrix[maxIndexRow, maxIndexCol - 1] + " "
    + matrix[maxIndexRow, maxIndexCol] + " "
    + matrix[maxIndexRow, maxIndexCol + 1]);
            Console.WriteLine(matrix[maxIndexRow + 1, maxIndexCol - 1] + " "
    + matrix[maxIndexRow + 1, maxIndexCol] + " "
    + matrix[maxIndexRow + 1, maxIndexCol + 1]);
        }
    }
}
