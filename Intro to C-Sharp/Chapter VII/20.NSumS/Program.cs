using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.NSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldExit = false;
            int s = int.Parse(Console.ReadLine());
            int[] arr = ReadArray();
            bool[] usedIndeces = new bool[arr.Length];
            for (int i = 1; i <= arr.Length; i++)
            {
                int[] result = new int[i];
                NestedLoops(arr.Length, i, 0, result, s, arr, ref shouldExit, usedIndeces);
            }
            Console.ReadKey();

            /*for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 || i == arr.Length - 1)
                {
                    if (s == arr[i])
                    {
                        Console.WriteLine($"yes -> {arr[i]}");
                        return;
                    }
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == s)
                    {
                        Console.WriteLine($"yes -> {arr[i]}, {arr[j]}");
                        return;
                    }
                }
            }

            Console.WriteLine("no");*/
        }


        static void NestedLoops(int limit, int numberOfLoops, int currentLoop, int[] result, int checkSum, int[] array, ref bool shouldExit, bool[] usedIndeces)
        {
            if (currentLoop == numberOfLoops)
            {
                if (result.Sum() == checkSum)
                {
                    Console.WriteLine($"yes -> {string.Join(",", result)}");
                    shouldExit = true;
                }

                return;
            }

            for (int i = 0; i < limit; i++)
            {
                if (!usedIndeces[i])
                {
                    result[currentLoop] = array[i];
                    usedIndeces[i] = true;
                }
                NestedLoops(limit, numberOfLoops, currentLoop + 1, result, checkSum, array, ref shouldExit, usedIndeces);

                if (shouldExit)
                {
                    return;
                }
            }
        }
        static int[] ReadArray()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
 