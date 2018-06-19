using System;
using System.Text.RegularExpressions;

namespace _06.Upcase
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string regexPattern = @"<upcase>([\w\ \!\?\,\.\:\;\&\+\)\(])+</upcase>";
            Regex rgx = new Regex(regexPattern);
            MatchCollection matches = rgx.Matches(input);

            foreach (Match match in matches)
            {
                string original = match.ToString();
                char[] originalToCharArrray = original.ToCharArray();
                for (int i = 8; i < originalToCharArrray.Length - 9; i++)
                {
                    originalToCharArrray[i] = Char.ToUpper(originalToCharArrray[i]);
                }
                string replacement = new string(originalToCharArrray);
                input = input.Replace(original, replacement);
            }
            Console.WriteLine(input);


        }
    }
}
