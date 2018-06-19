using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MostFrequentElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is problem number 10 not 11
            int[] integers = new int[13];
            Console.WriteLine("Please enter 13 integers: ");
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("You entered: ");
            for (int i = 0; i < integers.Length; i++)
            {
                Console.Write(integers[i] + " ");
            }

            //algorithm
            int count = 0;
            int bestCount = int.MinValue;
            int value = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = i; j < integers.Length; j++)
                {
                    if (integers[i] == integers[j])
                    {
                        count++;
                        if (count > bestCount)
                        {
                            bestCount = count;
                            value = integers[i];
                        }
                    }
                }
                count = 0;
            }

            Console.WriteLine
                ("The most frequent element is {0} and it occurs {1} times."
                , value, bestCount);
        }
    }
}
