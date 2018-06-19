using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NonConsecutiveIncreasingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to enter: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            Console.WriteLine("Enter {0} elements: ", length);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int[] lens = new int[numbers.Length];
            lens[0] = 1;
            int bestLen = int.MinValue;

            for (int x = 0; x <= numbers.Length - 1; x++)
            {
                for (int prev = 0; prev <= x - 1; prev++)
                {
                    if (lens[prev] > bestLen && numbers[prev] < numbers[x])
                    {
                        bestLen = lens[prev];
                    }
                }
                if (bestLen != int.MinValue)
                {
                    lens[x] = bestLen + 1;
                }
                else
                {
                    lens[x] = 1;
                }
                bestLen = int.MinValue;

            }
            Console.WriteLine("original array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("lens array: ");
            for (int i = 0; i < lens.Length; i++)
            {
                Console.Write(lens[i] + " ");
            }

            //find greatest length
            int maxLength = int.MinValue;

            for (int i = 0; i < lens.Length; i++)
            {
                if (lens[i] > maxLength)
                {
                    maxLength = lens[i];
                }
            }
            int maxLengthCopy = maxLength;
            //print results
            int[] result = new int[numbers.Length];
            Console.WriteLine();
            Console.WriteLine("longest increasing sequece");
            for (int i = lens.Length - 1; i >= 0; i--)
            {
                if (lens[i] == maxLengthCopy)
                {
                    result[i] = numbers[i];
                    maxLengthCopy--;
                }
            }
            Array.Sort(result);
            for (int i = result.Length - maxLength; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

        }
    }
}
