using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LexicographicallyFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string firstInput = Console.ReadLine();
            Console.Write("Please enter a second string: ");
            string secondInput = Console.ReadLine();
            char[] firstArray = firstInput.ToCharArray();
            char[] secondArray = secondInput.ToCharArray();

            if (firstArray.Length > secondArray.Length)
            {
                bool equal = true;
                char lastCharFirstArray = ' ';
                char lastCharSecondArray = ' ';

                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        equal = false;
                        lastCharFirstArray = firstArray[i];
                        lastCharSecondArray = secondArray[i];
                        break;
                    }

                }

                if (equal == false)
                {
                    Console.WriteLine("{0}"
                        , (int)lastCharFirstArray > (int)lastCharSecondArray ?
                        "Second string is lexicographically first" :
                        "First string is lexicographically first");
                }
                else
                {
                    Console.WriteLine("Second string is lexicographically first.");
                }

            }
            else if (firstArray.Length < secondArray.Length)
            {
                bool equal = true;
                char lastCharFirstArray = ' ';
                char lastCharSecondArray = ' ';

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        equal = false;
                        lastCharFirstArray = firstArray[i];
                        lastCharSecondArray = secondArray[i];
                        break;
                    }

                }

                if (equal == false)
                {
                    Console.WriteLine("{0}"
                        , (int)lastCharFirstArray > (int)lastCharSecondArray ?
                        "Second string is lexicographically first" :
                        "First string is lexicographically first");
                }
                else
                {
                    Console.WriteLine("First string is lexicographically first.");
                }

            }
            else
            {
                bool equal = true;
                char lastCharFirstArray = ' ';
                char lastCharSecondArray = ' ';

                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        equal = false;
                        lastCharFirstArray = firstArray[i];
                        lastCharSecondArray = secondArray[i];
                        break;
                    }

                }

                if (equal == false)
                {
                    Console.WriteLine("{0}"
                        , (int)lastCharFirstArray > (int)lastCharSecondArray ?
                        "Second string is lexicographically first" :
                        "First string is lexicographically first");
                }
                else
                {
                    Console.WriteLine("Strings are lexicographically equal.");
                }

            }
        }
    }
}
