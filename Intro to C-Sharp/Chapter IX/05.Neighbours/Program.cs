using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Neighbours
{
    class Program
    {
        static void CalculateFirstAndLast(int[] numbers, int position)
        {
            if (position == 0)
            {
                Console.WriteLine("The element at index 0 has only one neighbour" +
                    " at index 1.");
                if (numbers[0] > numbers[1])
                {
                    Console.WriteLine("The element at position 0: {0}, is greater than"
                        + "the element at position 1: {1}", numbers[0], numbers[1]);
                }
                else if (numbers[0] == numbers[1])
                {
                    Console.WriteLine("The element at position 0: {0}, is equal to"
    + " the element at position 1: {1}", numbers[0], numbers[1]);
                }
                else
                {
                    Console.WriteLine("The element at position 0: {0}, is less than"
+ " the element at position 1: {1}", numbers[0], numbers[1]);
                }
            }
            else if (position == numbers.Length - 1)
            {
                Console.WriteLine("The element at index {0} has only one neighbour" +
    " at index {1}.", numbers.Length - 1, numbers.Length - 2);
                if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                {
                    Console.WriteLine("The element at position 0: {0}, is greater than"
                        + " the element at position 1: {1}"
                        , numbers[numbers.Length - 1]
                        , numbers[numbers.Length - 2]);
                }
                else if (numbers[numbers.Length - 1] == numbers[numbers.Length - 2])
                {
                    Console.WriteLine("The element at position 0: {0}, is equal to"
    + " the element at position 1: {1}"
                            , numbers[numbers.Length - 1]
                        , numbers[numbers.Length - 2]);
                }
                else
                {
                    Console.WriteLine("The element at position 0: {0}, is less than"
+ " the element at position 1: {1}"
                        , numbers[numbers.Length - 1]
                        , numbers[numbers.Length - 2]);
                }
            }
        }
        static void CalculateMiddle(int[] numbers, int position)
        {
            Console.WriteLine("The element at index {0} has 2 neighbours at " +
                "index {1} and index {2}"
                , position
                , position - 1
                , position + 1);

            if (numbers[position] > numbers[position - 1]
                && numbers[position] > numbers[position + 1])
            {
                Console.WriteLine("The element at index {0}: {1}, is greater " +
                    "than the elements at index {2}: {3} and index {4}: {5}"
                    , position
                    , numbers[position]
                    , position - 1
                    , numbers[position - 1]
                    , position + 1
                    , numbers[position + 1]);
            }
            else if (numbers[position] < numbers[position - 1]
                && numbers[position] < numbers[position + 1])
            {
                Console.WriteLine("The element at index {0}: {1}, is less " +
   "than the elements at index {2}: {3} and index {4}: {5}"
   , position
   , numbers[position]
   , position - 1
   , numbers[position - 1]
   , position + 1
   , numbers[position + 1]);
            }
            else if (numbers[position] == numbers[position - 1]
                && numbers[position] == numbers[position + 1])
            {
                                Console.WriteLine("The element at index {0}: {1}, is less " +
                    "than the elements at index {2}: {3} and index {4}: {5}"
                    , position
                    , numbers[position]
                    , position - 1
                    , numbers[position - 1]
                    , position + 1
                    , numbers[position + 1]);
            }
            else if (numbers[position] > numbers[position - 1]
    && numbers[position] == numbers[position + 1])
            {
                Console.WriteLine("The element at index {0}: {1}, is greater " +
    "than the element at index {2}: {3} and equal to the element at index {4}: {5}"
    , position
    , numbers[position]
    , position - 1
    , numbers[position - 1]
    , position + 1
    , numbers[position + 1]);
            }
            else if (numbers[position] == numbers[position - 1]
&& numbers[position] > numbers[position + 1])
            {
                Console.WriteLine("The element at index {0}: {1}, is equal " +
    "to the element at index {2}: {3} and greater than the element at index {4}: {5}"
    , position
    , numbers[position]
    , position - 1
    , numbers[position - 1]
    , position + 1
    , numbers[position + 1]);
            }
            else if (numbers[position] < numbers[position - 1]
&& numbers[position] == numbers[position + 1])
            {
                Console.WriteLine("The element at index {0}: {1}, is less " +
    "than the element at index {2}: {3} and equal to the element at index {4}: {5}"
    , position
    , numbers[position]
    , position - 1
    , numbers[position - 1]
    , position + 1
    , numbers[position + 1]);
            }
            else if (numbers[position] == numbers[position - 1]
&& numbers[position] < numbers[position + 1])
            {
                Console.WriteLine("The element at index {0}: {1}, is equal " +
    "to the element at index {2}: {3} and less than the element at index {4}: {5}"
    , position
    , numbers[position]
    , position - 1
    , numbers[position - 1]
    , position + 1
    , numbers[position + 1]);
            }
            else if (numbers[position] > numbers[position - 1]
&& numbers[position] < numbers[position + 1])
            {
                Console.WriteLine("The element at index {0}: {1}, is greater " +
    "than the element at index {2}: {3} and less than the element at index {4}: {5}"
    , position
    , numbers[position]
    , position - 1
    , numbers[position - 1]
    , position + 1
    , numbers[position + 1]);
            }
            else if (numbers[position] < numbers[position - 1]
&& numbers[position] > numbers[position + 1])
            {
                Console.WriteLine("The element at index {0}: {1}, is less " +
    "than the element at index {2}: {3} and greater than the element at index {4}: {5}"
    , position
    , numbers[position]
    , position - 1
    , numbers[position - 1]
    , position + 1
    , numbers[position + 1]);
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Please enter {0} integers: ", n);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Index #{0}: ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a position between 0 and {0}: ", n - 1);
            int position = int.Parse(Console.ReadLine());

            if (position == 0 || position == n - 1)
            {
                CalculateFirstAndLast(numbers, position);
            }
            else
            {
                CalculateMiddle(numbers, position);
            }



        }
    }
}
