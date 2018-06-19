using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MaxSumOfConsecutiveElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Please enter 10 integers: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("You entered: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            

            //find sum
            int currentSum = 0;
            int bestSum = int.MinValue;
            int firstIndex = 0;
            int lastIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        firstIndex = i;
                        lastIndex = j;
                    }
                }
                currentSum = 0;
            }

            //print result
            Console.Write("\nMax sum = ");
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Console.Write("{0}",
                    i == lastIndex ? "(" + array[i].ToString() + ")" + " = "
                    : "(" + array[i].ToString() + ")" + " + ");
            }
            Console.WriteLine("{0}", bestSum);
        }
    }
}
