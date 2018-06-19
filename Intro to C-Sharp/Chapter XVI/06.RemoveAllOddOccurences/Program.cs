using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveAllOddOccurences
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToList();

            SingleStructureSolution(integers);
        }

        static void SingleStructureSolution(List<int> integers)
        {
            for (int i = 0; i < integers.Count; i++)
            {
                int currentNum = integers[i];
                int count = 0;

                for (int j = 0; j < integers.Count; j++)
                {
                    if (currentNum == integers[j])
                    {
                        count++;
                    }
                }

                if (count % 2 != 0)
                {
                    for (int k = 0; k < integers.Count; k++)
                    {
                        if (integers[k] == currentNum)
                        {
                            integers.RemoveAt(k);
                            k--;
                        }
                    }

                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", integers));
        }

        static void HelperStructureSolution(List<int> integers)
        {
            HashSet<int> oddOccurences = new HashSet<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                int count = 0;

                for (int j = 0; j < integers.Count; j++)
                {
                    if (integers[i] == integers[j])
                    {
                        count++;
                    }
                }

                if (count % 2 != 0)
                {
                    oddOccurences.Add(integers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", integers.Where(x => !oddOccurences.Contains(x)).ToList()));
        }
    }
}
