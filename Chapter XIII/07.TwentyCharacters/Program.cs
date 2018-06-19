using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TwentyCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input.Length > 20)
            {
                Console.WriteLine("The string you entered is more than 20 characters long.");
            }
            else if (input.Length == 20)
            {
                Console.WriteLine(input);
            }
            else
            {
                char[] charArray = new char[20];
                for (int i = 0; i < 20; i++)
                {
                    if (i < input.Length)
                    {
                        charArray[i] = input[i];
                    }
                    else
                    {
                        charArray[i] = '+';
                    }
                }
                Console.WriteLine(new string(charArray));
            }
        }
    }
}
