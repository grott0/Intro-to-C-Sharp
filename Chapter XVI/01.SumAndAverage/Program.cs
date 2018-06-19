using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                list.Add(int.Parse(input));

                input = Console.ReadLine();
            }

            Console.WriteLine(list.Sum() + "\n" + list.Average());
        }
    }
}
