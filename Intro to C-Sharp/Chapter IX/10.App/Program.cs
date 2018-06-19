using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.App
{
    class Program
    {
        static void Reverse(uint number)
        {
            StringBuilder reversed = new StringBuilder();
            uint digit;


            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                reversed.Append(digit.ToString());
            }
            Console.WriteLine(reversed.ToString());
        }
        static double Average(int length)
        {

            double[] sequence = new double[length];
            double sum = 0;
            double average;

            for (int i = 0; i < length; i++)
            {
                Console.Write("Element #{0}: ", i + 1);
                bool check = double.TryParse(Console.ReadLine(), out sequence[i]);
                while (check == false)
                {
                    Console.Write("Invalid input.Please try again: ");
                    check = double.TryParse(Console.ReadLine(), out sequence[i]);
                }
            }

            for (int i = 0; i < length; i++)
            {
                sum += sequence[i];
            }

            average = sum / length;
            return average;

        }
        static double LinearEquation(double a, double b)
        {
            double x;
            if (b == 0)
            {
                x  = 0;
                return x;
            }
            else 
            {
                long convert = BitConverter.DoubleToInt64Bits(b);
                convert = convert ^ ((long)1 << 63);
                b = BitConverter.Int64BitsToDouble(convert);
                x = b / a;
                return x;
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("1.Reverse the digits of a given integer." +
                "\n2.Calculate the average "
                + "of a number sequence.\n3.Solve a linear equation of the type "
                + "a * x + b = 0");
            Console.Write("\n\nPlease enter the number corresponding to your choice: ");
            ConsoleKeyInfo input = Console.ReadKey();
            char key = input.KeyChar;
            Console.WriteLine();
            while (key != '1' && key != '2' && key != '3')
            {
                Console.Write("Invalid choice.Please try again: ");
                input = Console.ReadKey();
                key = input.KeyChar;
                Console.WriteLine();
            }
            if (key == '1')
            {
                Console.Write("Please enter a 32-bit unsigned integer: ");
                uint n;
                bool check = uint.TryParse(Console.ReadLine(), out n);
                while (check == false)
                {
                    Console.Write("Invalid input.Try again: ");
                    check = uint.TryParse(Console.ReadLine(), out n);
                }
                Reverse(n);

            }
            else if (key == '2')
            {
                Console.Write("How many elements does your sequence contain: ");
                int length;
                bool check = int.TryParse(Console.ReadLine(), out length);
                while (check == false || length <= 0 )
                {

                    Console.Write("Invalid input.Try again: ");
                    check = int.TryParse(Console.ReadLine(), out length);
                }
                Console.WriteLine("The average of the sequence is: {0}", Average(length));
            }
            else
            {
                Console.Write("a = ");
                double a;
                bool checkA = double.TryParse(Console.ReadLine(), out a);
                while (checkA == false || a == 0)
                {
                    if (a == 0)
                    {
                        Console.Write("The coefficient 'a' must not be equal to zero."
                            + "Try again: ");
                        checkA = double.TryParse(Console.ReadLine(), out a);
                        
                    }
                    else
                    {
                        Console.Write("Invalid input.Try again: ");
                        checkA = double.TryParse(Console.ReadLine(), out a);
                    }
                }

                Console.Write("b = ");
                double b;
                bool checkB = double.TryParse(Console.ReadLine(), out b);
                while (checkB == false)
                {
                    Console.Write("Invalid input.Try again: ");
                    checkB = double.TryParse(Console.ReadLine(), out b);
                }

                Console.WriteLine("x = {0}",LinearEquation(a, b));
            }
        }
    }
}
