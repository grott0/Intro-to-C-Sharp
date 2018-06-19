using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.ExtractPalindromes
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            List<string> palindromes = FindPalindromes(input);
            PrintPalindromes(palindromes);


        }
        static void PrintPalindromes(List<string> palindromes)
        {
            foreach (string palindrome in palindromes)
            {
                Console.WriteLine(palindrome);
            }
        }
        static List<string> FindPalindromes(string[] words)
        {
            List<string> palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                bool isPalindrome = true;

                for (int j = 0, k = words[i].Length - 1; j < words[i].Length; j++, k--)
                {
                    if (!words[i][j].ToString().ToLower().Equals(words[i][k].ToString().ToLower()))
                    {
                        isPalindrome = false;
                    }
                }

                if (isPalindrome == true)
                {
                    palindromes.Add(words[i]);
                }
            }

            return palindromes;
        }
    }
}
