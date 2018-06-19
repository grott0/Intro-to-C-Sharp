using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.StringMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix =
{
                {"xa","ho","ho","hi" },
                {"xa","he","hi","xx" },
                {"xi","hi","he","xx" },
                {"hi","ho","fo","he" },
                {"xa","ho","fo","ha" }
            };

            int currentLength = 1;
            int maxLenght = int.MinValue;
            //save the element which is found the greatest number of times in this string
            string element = null; 

            /*Check the right diagonal on the upper half, the outer cycle represents
             * the starting column for each iteration of the inner cycle */
            for (int startCol = 0; startCol < matrix.GetLength(1) - 1; startCol++) 
            {
                // constraints to stay in the matrix
                for (int row = 0, col = startCol; row < matrix.GetLength(0) - 1
                    && col < matrix.GetLength(1) - 1; row++, col++) 
                {
                    if (matrix[row,col] == matrix[row + 1, col + 1])
                    {
                        currentLength++;
                        if (currentLength > maxLenght)
                        {
                            maxLenght = currentLength;
                            element = matrix[row, col];
                        }
                    }
                }
                currentLength = 1;

            }

            currentLength = 1; //set to initial value
            
            /*Check the right diagonal on the bottom half of the matrix,
             * start from the second row, the first has already been check by
             * the previous cycle.The outer cycle represents the startin row
             * for every iteration of the inner cycle */

            for (int startRow = 1; startRow < matrix.GetLength(0) - 1; startRow++)
            {
                for (int row = startRow, col = 0;
                    row < matrix.GetLength(0) - 1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        currentLength++;
                        if (currentLength > maxLenght)
                        {
                            maxLenght = currentLength;
                            element = matrix[row, col];
                        }
                    }
                }
                currentLength = 1;
            }
            currentLength = 1; //set to initial value

            /*Check the upper half of the left diagonal, the same algorithm as
             * the upper half of the right diagonal, reversed loops */

            for (int startCol = matrix.GetLength(1) - 1; startCol >= 1; startCol--)
            {
                for (int row = 0, col = startCol;
                    row < matrix.GetLength(0) - 1 && col >= 1; row++, col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        currentLength++;
                        if (currentLength > maxLenght)
                        {
                            maxLenght = currentLength;
                            element = matrix[row, col];
                        }
                    }
                }
                currentLength = 1;

            }
            currentLength = 1; //set to initial value

            /*Check the lower half of the left diagonal, the same algorithm as
             * the lower half of the right diagonal, reversed loops */

            for (int startRow = 1; startRow < matrix.GetLength(0) - 1; startRow++)
            {
                for (int row = startRow, col = matrix.GetLength(1) - 1;
                    row < matrix.GetLength(0) - 1; row++, col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        currentLength++;
                        if (currentLength > maxLenght)
                        {
                            maxLenght = currentLength;
                            element = matrix[row, col];
                        }
                    }
                }
                currentLength = 1;
            }
            currentLength = 1; //set to initial value

            /* Check the rows, starting from the first column up to the last,
             increment the rows until you get to the next to last, since 
             the checking requires [row + 1]*/

            for (int startCol = 0; startCol < matrix.GetLength(1); startCol++)
            {
                for (int row = 0, col = startCol;
                    row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row,col] == matrix[row + 1, col])
                    {
                        currentLength++;
                        if (currentLength > maxLenght)
                        {
                            maxLenght = currentLength;
                            element = matrix[row, col];
                        }
                    }
                }
                currentLength = 1;
            }
            currentLength = 1; //set to initial value

            /*Check the columns in the same manner as the rows */
            for (int startRow = 0; startRow < matrix.GetLength(0); startRow++)
            {
                for (int row = startRow, col = 0;
                    row < matrix.GetLength(0) && col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        currentLength++;
                        if (currentLength > maxLenght)
                        {
                            maxLenght = currentLength;
                            element = matrix[row, col];
                        }
                    }
                }
                currentLength = 1;
            }

            //print results
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("--> ");
            for (int i = 0; i < maxLenght; i++)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

        }
    }
}
