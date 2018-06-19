using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RecursiveNestedLoops
{
    
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loop;
        static void Main(string[] args)
        {
            Console.Write("Number of loops: ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("Number of iterations: ");
            numberOfIterations = int.Parse(Console.ReadLine());

            loop = new int[numberOfLoops];

            NestedLoops(0);
        }
        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }

            for (int i = 1; i <= numberOfIterations; i++)
            {
                loop[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }
        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loop[i]);
            }
            Console.WriteLine();
        }

    }
}
