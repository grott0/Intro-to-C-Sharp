using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumEqualToInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is problem number 11 not 10
            Console.Write("Enter a sum to search for: ");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 7 integers: ");
            int[] array = new int[7];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("You entered: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //algorithm
            int currentSum = 0;
            int firstIndex = 0;
            int lastIndex = 0;
            bool specialCase = true;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum == sum)
                    {
                        firstIndex = i;
                        lastIndex = j;
                        specialCase = false;
                        break;
                    }
                }
                currentSum = 0;
            }

            if (specialCase == true)
            {
                Console.WriteLine
                    ("There are no consecutive numbers that" +
                    " form the sum that you are looking for.");
            }
            else
            {
                Console.Write("The sum you are looking for: ");
                for (int i = firstIndex; i <= lastIndex; i++)
                {
                    Console.Write(i == lastIndex ?
                        "(" + array[i].ToString() + ")" + " = {0}"
                        : "(" + array[i].ToString() + ")" + " + ", sum);
                }
                Console.WriteLine();
            }
        }
    }
}
