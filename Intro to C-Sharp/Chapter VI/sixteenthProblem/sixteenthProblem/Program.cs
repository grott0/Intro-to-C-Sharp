using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixteenthProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] randomNumbers = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                randomNumbers[i] = rnd.Next(1, n);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(randomNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
