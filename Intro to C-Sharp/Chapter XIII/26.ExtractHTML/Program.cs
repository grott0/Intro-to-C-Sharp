using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _26.ExtractHTML
{
    class Program
    {
        static void Main()
        {

            string bodyPattern = @"(?<=<.+?>).+?(?=</.+?>)";
            string input = Console.ReadLine();
            MatchCollection text = Regex.Matches(input, bodyPattern);
            string title = text[0].ToString();
            Console.WriteLine("Title: {0}", title);
            Console.Write("Body: ");
            for (int i = 1; i < text.Count; i++)    
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }
    }
}
