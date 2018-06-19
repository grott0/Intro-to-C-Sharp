using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twelvethProblem
{
    class decimalToBinary
    {
        static void Main()
        {
            int baseTen = int.Parse(Console.ReadLine());
            int result;
            int counter = 0;

            for (int i = baseTen; i > 0; i /= 2)
            {
                counter++;
                result = i % 2;
            }

            int[] baseTwo = new int[counter];


            for (int j = 0; j < counter; j++)
            {
                result = baseTen % 2;
                baseTen /= 2;
                baseTwo[j] = result;
            }

            for (int k = counter - 1; k >= 0; k--)
            {
                Console.Write(baseTwo[k]);

            }
            Console.WriteLine();
        } 
    }
}
