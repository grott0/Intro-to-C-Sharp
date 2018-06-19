using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Strings
{
    class Program
    {
        static string[] words;
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] indexes;

        static void InitializeArray()
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("#{0}: ", i + 1);
                words[i] = Console.ReadLine();
            }
        }
        static void PrintArray()
        {
            Console.Write("(");
            for (int i = 1; i < indexes.Length; i++)
            {
                if (i == indexes.Length - 1)
                {
                    int tempIndex = indexes[i];
                    Console.Write(words[tempIndex] + "");
                }
                else
                {
                    int tempIndex = indexes[i];
                    Console.Write(words[tempIndex] + ", ");
                }

            }
            Console.WriteLine(")");
        }
        static void Algorithm(int currentLoop)
        {
            if (currentLoop == numberOfLoops + 1)
            {
                PrintArray();
                return;
            }
            for (int i = indexes[currentLoop - 1] + 1; i <=
                numberOfIterations - (numberOfLoops - (currentLoop - 1)); i++)
            {
                indexes[currentLoop] = i;
                Algorithm(currentLoop + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("How many words do you want to enter: ");
            numberOfIterations = int.Parse(Console.ReadLine());
            Console.Write("How many words do you want to group: ");
            numberOfLoops = int.Parse(Console.ReadLine());
            words = new string[numberOfIterations];
            indexes = new int[numberOfLoops + 1];
            indexes[0] = -1;
            InitializeArray();
            Algorithm(1);

        }
    }
}
