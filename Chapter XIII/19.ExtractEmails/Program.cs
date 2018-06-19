using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19.ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z][\w\.\-]+)@([\w\.\-]+)(\.[a-zA-Z]{2,8}){1,2}";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.ToString());
            }

        }
    }
}
