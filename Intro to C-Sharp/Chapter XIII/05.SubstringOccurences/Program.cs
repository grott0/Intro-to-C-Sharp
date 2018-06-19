using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.SubstringOccurences
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string searchFor = Console.ReadLine();
            Regex rx = new Regex(searchFor, RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(input);
            int counter = 0;
            foreach (var match in matches)
            {
                counter++;
            }
            Console.WriteLine(counter);

        }
    }
}
