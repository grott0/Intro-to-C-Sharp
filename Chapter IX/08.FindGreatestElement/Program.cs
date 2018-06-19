using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FindGreatestElement
{
    class Program
    {
        static void FindAndSort(int[] numbers)
        {
            int greatestValue = int.MinValue;
            int greatestIndex = 0;
            int saveGreatestValue = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (numbers[j] > greatestValue)
                    {
                        greatestValue = numbers[j];
                        greatestIndex = j;
                    }
                }
                if (i == numbers.Length - 1)
                {
                    saveGreatestValue = greatestValue;
                }
                int temp = numbers[i];
                numbers[i] = numbers[greatestIndex];
                numbers[greatestIndex] = temp;
                greatestValue = int.MinValue;
            }

            Console.WriteLine("The greatest number in the array is: {0}", saveGreatestValue);
            Console.WriteLine("The is the sorted array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            //dummy array
            int[] numbers = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 101);
            }
            Console.WriteLine("This is the original array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            FindAndSort(numbers);
        }
    }
}
