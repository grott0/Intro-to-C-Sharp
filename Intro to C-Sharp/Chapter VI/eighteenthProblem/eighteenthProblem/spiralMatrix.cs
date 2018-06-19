using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eighteenthProblem
{
    class spiralMatrix
    {
        static void Main()
        {
            // Enter matrix size and initialize two dimensional array

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            //Fill the matrix with elements

            for (int i = 0, m = 0; i < matrix.GetLength(0); i++, m +=n)
            {
                for (int j = 0, k = 1; j < matrix.GetLength(1); j++, k++) 
                {
                    matrix[i, j] = k + m;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { 
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
