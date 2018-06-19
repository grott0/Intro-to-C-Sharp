using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('\\');
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }

        }
    }
}
