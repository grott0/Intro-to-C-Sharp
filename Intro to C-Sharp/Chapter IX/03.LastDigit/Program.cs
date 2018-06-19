using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastDigit
{
    class Program
    {
        static void LastDigit(long number)
        {
            long lastDigit = number % 10;

            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("The last digit is zero");
                    break;
                case 1:
                    Console.WriteLine("The last digit is one");
                    break;
                case 2:
                    Console.WriteLine("The last digit is two");
                    break;
                case 3:
                    Console.WriteLine("The last digit is three");
                    break;
                case 4:
                    Console.WriteLine("The last digit is four");
                    break;
                case 5:
                    Console.WriteLine("The last digit is five");
                    break;
                case 6:
                    Console.WriteLine("The last digit is six");
                    break;
                case 7:
                    Console.WriteLine("The last digit is seven");
                    break;
                case 8:
                    Console.WriteLine("The last digit is eight");
                    break;
                case 9:
                    Console.WriteLine("The last digit is nine");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            long input = Convert.ToInt64(Console.ReadLine());
            LastDigit(input);
        }
    }
}
