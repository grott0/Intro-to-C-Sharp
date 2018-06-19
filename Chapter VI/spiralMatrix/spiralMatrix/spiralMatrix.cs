using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiralMatrix
{
    class spiralMatrix
    {
        static void Main()
        {

            //My algorithm - someday maybe I'll make it work
            int n1 = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[n1, n1];
            int counter1 = 1;
            double iterator = Math.Ceiling(n1 / 2.0);

            for (int i = 0, j = 1; i < 1; i++, j++)
            {
                for (int row1 = 0; row1 < n1; row1++)
                {
                    for (int col1 = 0; col1 < n1; col1++)
                    {
                        if (row1 == i && col1 >= i && col1 <= n1 - j)
                        {
                            matrix1[row1, col1] = counter1;
                            counter1++;
                        }
                        if (row1 >= i && row1 <= n1 - j && col1 == n1 - j)
                        {
                            if (row1 == i)
                            {
                               counter1--;
                               matrix1[row1, col1] = counter1;
                            }
                            matrix1[row1, col1] = counter1;
                            counter1++;
                        }
                        if (row1 == n1 - j && col1 >= i && col1 <= n1 - j)
                        {
                            if (col1 == n1 - j)
                            {
                                counter1--;
                            }
                           
                            matrix1[row1, col1] = counter1;
                            counter1++;

                        }
                        if (row1 > i && row1 <= n1 - j && col1 == i)
                        {

                            matrix1[row1, col1] = counter1;
                            counter1++;
                        }

                    }
                }
            }

            for (int k = 0; k < n1; k++)
            {
                for (int l = 0; l < n1; l++)
                {
                    Console.Write(matrix1[k, l] + " ");
                }
                Console.WriteLine();
            }

            //end of my stuff
            Console.WriteLine(new string('_', 20));
            //New approach

            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            int iteration = 0;

            while (counter <= n  * n) 
            {
                while (col < n - iteration )
                {
                    matrix[row, col] = counter;
                    counter++;
                    col++;
                }

                row++;
                col--;
                

                while (row < n - iteration)
                {
                    matrix[row, col] = counter;
                    counter++;
                    row++;
                }

                col--;
                row--;

                while (col >= iteration)
                {
                    matrix[row, col] = counter;
                    col--;
                    counter++;
                }

                col++;
                row--;

                while (row > iteration)
                {
                    matrix[row, col] = counter;
                    row--;
                    counter++;
                }
                row++;
                col++;
                iteration += 1;

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
