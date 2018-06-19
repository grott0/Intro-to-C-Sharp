using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortNumbersAscending
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                integers.Add(int.Parse(input));

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers.OrderBy(x => x)));
        }
    }
}
