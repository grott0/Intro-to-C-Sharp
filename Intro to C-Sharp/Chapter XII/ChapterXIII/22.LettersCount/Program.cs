using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.LettersCount
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] lettersCount = CountLetters(input);
            char[] letters = 
                { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            PrintLetters(lettersCount, letters);

        }

        static void PrintLetters(int[] lettersCount, char[] letters)
        {
            for (int i = 0; i < lettersCount.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", letters[i], lettersCount[i]);
            }
        }
        static int[] CountLetters(string input)
        {
            int[] lettersCount = new int[26];

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        lettersCount[0] += 1;
                        break;
                    case 'b':
                        lettersCount[1] += 1;
                        break;
                    case 'c':
                        lettersCount[2] += 1;
                        break;
                    case 'd':
                        lettersCount[3] += 1;
                        break;
                    case 'e':
                        lettersCount[4] += 1;
                        break;
                    case 'f':
                        lettersCount[5] += 1;
                        break;
                    case 'g':
                        lettersCount[6] += 1;
                        break;
                    case 'h':
                        lettersCount[7] += 1;
                        break;
                    case 'i':
                        lettersCount[8] += 1;
                        break;
                    case 'j':
                        lettersCount[9] += 1;
                        break;
                    case 'k':
                        lettersCount[10] += 1;
                        break;
                    case 'l':
                        lettersCount[11] += 1;
                        break;
                    case 'm':
                        lettersCount[12] += 1;
                        break;
                    case 'n':
                        lettersCount[13] += 1;
                        break;
                    case 'o':
                        lettersCount[14] += 1;
                        break;
                    case 'p':
                        lettersCount[15] += 1;
                        break;
                    case 'q':
                        lettersCount[16] += 1;
                        break;
                    case 'r':
                        lettersCount[17] += 1;
                        break;
                    case 's':
                        lettersCount[18] += 1;
                        break;
                    case 't':
                        lettersCount[19] += 1;
                        break;
                    case 'u':
                        lettersCount[20] += 1;
                        break;
                    case 'v':
                        lettersCount[21] += 1;
                        break;
                    case 'w':
                        lettersCount[22] += 1;
                        break;
                    case 'x':
                        lettersCount[23] += 1;
                        break;
                    case 'y':
                        lettersCount[24] += 1;
                        break;
                    case 'z':
                        lettersCount[25] += 1;
                        break;
                    default:
                        break;
                }
            }

            return lettersCount;
        }
    }
}
