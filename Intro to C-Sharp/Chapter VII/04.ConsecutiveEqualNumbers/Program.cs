using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ConsecutiveEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to enter: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            int greatestSequence = int.MinValue;
            int currentSequence = 0;
            int lastIndex = 0;
            Console.WriteLine("Please enter {0} integers: ", length);
            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentSequence++;
                    if (currentSequence > greatestSequence)
                    {
                        greatestSequence = currentSequence;
                        lastIndex = i + 1;
                    }
                }
                else
                {
                    currentSequence = 0;
                }
            }

            if (length == 1)
            {
                Console.WriteLine("{{{0}}}", numbers[0]);
            }
            else
            {
                Console.Write("{");
                for (int i = lastIndex - greatestSequence; i <= lastIndex; i++)
                {

                    if (i == lastIndex)
                    {
                        Console.WriteLine(numbers[i] + "}");
                    }
                    else
                    {
                        Console.Write(numbers[i] + ", ");
                    }

                }
            }

        }
    }
}
