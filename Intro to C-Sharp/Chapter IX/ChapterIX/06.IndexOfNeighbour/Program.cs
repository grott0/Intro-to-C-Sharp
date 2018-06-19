using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IndexOfNeighbour
{
    class Program
    {
        static int GetIndex(int[] numbers)
        {
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else if (i == numbers.Length - 1)
                {
                    continue;
                }
                else
                {
                    if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                    {
                        index = i;
                    }
                    return index;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the size of the array: ");
            int n = 0;
            bool tryparse = int.TryParse(Console.ReadLine(), out n);
            while (tryparse == false)
            {
                Console.WriteLine("Invalid input!Please enter a valid 32 bit signed integer.");
                tryparse = int.TryParse(Console.ReadLine(), out n);
            }
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Element #{0}: ", i);
                bool check = int.TryParse(Console.ReadLine(), out numbers[i]);
                while (check == false)
                {
                    Console.WriteLine("Invalid input! Please enter a 32 bit signed integer.");
                    check = int.TryParse(Console.ReadLine(), out numbers[i]);
                }
            }

            if (GetIndex(numbers) == -1)
            {
                Console.WriteLine("There is no element which is greater" +
                    " than it's neighbouring elements.");
            }
            else
            {
                Console.WriteLine("The element at index {0} is greater that both" +
                    " of his neighbours.",GetIndex(numbers));
            }
        }
    }
}
