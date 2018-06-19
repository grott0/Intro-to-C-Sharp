using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MajorElement
{
    class Occurence
    {
        public int Value { get; set; }
        public int Times { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Random rnd = new Random();
            List<int> integers = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                integers.Add(rnd.Next(0, 10));
            }*/

            List<int> integers = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToList();

            int n = integers.Count;
            List<Occurence> results = new List<Occurence>();

            while (integers.Count > 0)
            {
                int currentNum = integers[0];
                int cnt = 0;

                for (int i = 0; i < integers.Count; i++)
                {
                    if (integers[i] == currentNum)
                    {
                        integers.RemoveAt(i);
                        cnt++;
                        i--;
                    }
                }

                results.Add(new Occurence() { Value = currentNum, Times = cnt });
                //Console.WriteLine($"{currentNum} -> {cnt} times");
            }

            var majorant = results.SingleOrDefault(r => r.Times >= (n / 2) + 1)?.Value;

            if (majorant != null)
            {
                Console.WriteLine(majorant);
            }
            else
            {
                Console.WriteLine("The majorant doesn't exist!");
            }

        }
    }
}
