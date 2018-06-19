using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.OrderWords
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (string word in input.OrderBy(x => x))
            {
                Console.WriteLine(word);
            }

        }
    }
}
