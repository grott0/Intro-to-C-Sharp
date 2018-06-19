using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.GetSentences
{
    class Program
    {
        static void Main()
        {
            Regex rgx = new Regex(@"\b([\w\'\""])+\b");
            string input = Console.ReadLine();
            string keyWord = Console.ReadLine();
            string[] sentences = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            PrintSentences(rgx, keyWord, sentences);

        }

        static void PrintSentences(Regex rgx, string keyWord, string[] sentences) 
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                MatchCollection words = rgx.Matches(sentences[i]);
                bool containsKeyWord = false;

                foreach (Match word in words)
                {
                    if (word.ToString().Equals(keyWord))
                    {
                        containsKeyWord = true;
                    }
                }

                if (containsKeyWord)
                {
                    Console.WriteLine(sentences[i].Trim() + ".");
                }

            }
        }
    }
}
