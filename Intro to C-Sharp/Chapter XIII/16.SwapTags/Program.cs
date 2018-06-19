using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _16.SwapTags
{
    class Program
    {
        static void Main()
        {
            string pattern = @"<a href=""[\w\.]+"">.+?</a>";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            input = input.Replace("<a href", "[URL href");
            input = input.Replace("</a>", "[/URL]");
            Console.WriteLine(input);

        }
    }
}
