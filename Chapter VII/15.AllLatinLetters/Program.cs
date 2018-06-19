using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AllLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = {'a','b','c','d','e','f','g','h','i','g','k',
            'l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine().ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} is the {1} letter of the alphabet."
                            , word[i]
                            , j + 1);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
