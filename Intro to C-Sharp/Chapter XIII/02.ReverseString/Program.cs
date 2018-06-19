using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class Program
    {
        static void Main()
        {
            //first solution
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(new string(input));


            //second solution
            Array.Reverse(input); //get back initial value
            StringBuilder reverse = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse.Append(input[i]);
            }
            Console.WriteLine(reverse.ToString());
        }
    }
}
