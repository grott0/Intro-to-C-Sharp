using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeNumbers
{
    public class Program
    {
        public static void Main()
        {
            List<double> nums = Console.ReadLine()
                .Split(' ')
                .Select(x => double.Parse(x))
                .ToList()
                .Where(x => x > 0)
                .ToList();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
