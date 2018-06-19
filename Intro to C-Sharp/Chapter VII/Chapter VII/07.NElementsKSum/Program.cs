using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NElementsKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter {0} elements: ", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int bestSum = int.MinValue;
            int currentSum = 0;
            int lastIndex = 0;
            int firstIndex = 0;

            for (int i = 0; i <= array.Length - k; i++)
            {
                for (int j = i; j < i + k; j++)
                {
                    currentSum += array[j];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        lastIndex = j;
                        firstIndex = i;
                    }
                }
                currentSum = 0;
            }

            Console.WriteLine();
            Console.Write("numbers entered: { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}",
                    i == array.Length - 1 ? array[i].ToString() + "}"
                    : array[i].ToString() + ", ");

            }
            Console.WriteLine();
            Console.Write("\nMax consecutive sum of {0} numbers = ", k);
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                if (i == lastIndex)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + " + ");
                }
                
            }
            Console.WriteLine(" = {0}", bestSum);
        }
    }
}
