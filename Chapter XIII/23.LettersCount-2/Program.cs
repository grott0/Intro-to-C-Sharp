using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.LettersCount_2
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            Dictionary<char, int> letters = GetLetterCount(input);
            Print(letters);

        }

        static Dictionary<char, int> GetLetterCount(string input)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;
                    }
                }
                if (letters.ContainsKey(input[i]))
                {
                    continue;
                }
                else
                {
                    letters.Add(input[i], counter);
                }
            }

            return letters;
        }

        static void Print(Dictionary<char, int> letters)
        {
            foreach (KeyValuePair<char, int> pair in letters.OrderBy(x => x.Key))
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }
    }
}
