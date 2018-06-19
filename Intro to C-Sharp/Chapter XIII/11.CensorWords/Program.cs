using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CensorWords
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] wordsToCensor = Console.ReadLine().Split(',');

            for (int i = 0; i < wordsToCensor.Length; i++)
            {
                input = input.Replace(wordsToCensor[i], new string('*', wordsToCensor[i].Length));
            }
            Console.WriteLine(input);

        }
    }
}
