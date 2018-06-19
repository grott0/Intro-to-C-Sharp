using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StringPt2
{ 
    class Program
    {
        static int[] indexes;
        static int numberOfLoops;
        static int numberOfWords;
        static string[] words;

        static void Initialize()
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("#{0}: ", i + 1);
                words[i] = Console.ReadLine();
            }
        }
        static void Print()
        {
            Console.Write("(");
            for (int i = 0; i < words.Length; i++)
            {
                if (indexes[i + 1] == 0 && i != 0)
                {
                    break;
                }
                else
                {
                    int index = indexes[i + 1];
                    Console.Write(" " + words[index]);
                }
            }
            Console.WriteLine(" )");
        }
        static void Algorithm(int currentLoop)
        {
            if (currentLoop == numberOfLoops + 1)
            {
                Print();
                return;
            }

            for (int i = indexes[currentLoop - 1] + 1;
                i <= numberOfWords - (numberOfLoops - (currentLoop - 1)); i++)
            {
                indexes[currentLoop] = i;
                Algorithm(currentLoop + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("How many words would you like to enter: ");
            numberOfWords = int.Parse(Console.ReadLine());
            words = new string[numberOfWords];
            numberOfLoops = 1;

            indexes = new int[numberOfWords + 1];
            indexes[0] = -1;
            Initialize();

            for (int i = 0; i < numberOfWords; i++)
            {
                Algorithm(1);
                numberOfLoops++;
            }


        }
    }
}
