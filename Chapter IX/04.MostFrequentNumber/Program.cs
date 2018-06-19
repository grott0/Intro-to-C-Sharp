using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MostFrequentNumber
{
    class Program
    {
        //I'm even going to make the program find the most frequent element
        static void Find(string input)
        {
            char[] charArray = input.ToCharArray();
            int currentOccurence = 0;
            int bestOccurence = int.MinValue;
            char element = ' ';

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < charArray.Length; j++)
                {
                    if (charArray[i] == charArray[j] )
                    {
                        currentOccurence++;

                        if (currentOccurence > bestOccurence)
                        {
                            bestOccurence = currentOccurence;
                            element = charArray[i];
                        }
                    }
                }
                currentOccurence = 0;
            }

            Console.WriteLine("The most frequent element is {0}." +
                "\nIt occurs in the array {1} times."
                , element
                , bestOccurence);
        }
        static void Main(string[] args)
        {
            Console.Write("Type anything you want: ");
            string input = Console.ReadLine();
            Find(input);
        }
    }
}
