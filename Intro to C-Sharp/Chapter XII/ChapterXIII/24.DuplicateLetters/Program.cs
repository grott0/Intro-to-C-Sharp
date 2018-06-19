using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24.DuplicateLetters
{
    class Program
    {
        static void Main()
        {

            string pattern = @"([a-zA-Z])\1+";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                input = input.Replace(match.ToString(), match.ToString()[0].ToString());
            }
            Console.WriteLine(input);

        }
    }
}
