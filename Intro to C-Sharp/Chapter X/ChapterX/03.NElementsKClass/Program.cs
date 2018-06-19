using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KElementNSet
{
    class Program
    {
        static int numberOfIterations;
        static int numberOfLoops;
        static int[] elements;

        static void Algorithm(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintElements();
                return;
            }

            for (int i = 1; i <= numberOfIterations; i++)
            {
                elements[currentLoop] = i;
                Algorithm(currentLoop + 1);
            }
        }
        static void PrintElements()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write("{0} ", elements[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            numberOfIterations = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            elements = new int[numberOfLoops];
            Algorithm(0);


        }
    }
}
