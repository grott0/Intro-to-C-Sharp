using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.SumTwoNumbers
{
    class Program
    {
        static BigInteger Sum(byte[] firstNumber, byte[] secondNumber)
        {
            StringBuilder number1 = new StringBuilder();
            StringBuilder number2 = new StringBuilder();

            //create first number
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                number1.Append(firstNumber[i]);
            }
            //create second number
            for (int i = secondNumber.Length - 1; i >= 0; i--)
            {
                number2.Append(secondNumber[i]);
            }

            //Parse
            BigInteger sum = BigInteger.Parse(number1.ToString())
                + BigInteger.Parse(number2.ToString());
            return sum;

        } 
        static void Main(string[] args)
        {
            //Two numbers are represented as arrays
            //Where the last digit of the number is at index 0 and so on
            //The goal is to find they're sum
            //The program must work with numbers up to 10 000 digits long
            Random rnd = new Random();
            byte[] firstNumber = new byte[rnd.Next(0,15)];
            byte[] secondNumber = new byte[rnd.Next(0,15)];


            Console.WriteLine("first number reversed: ");
            for (int i = 0; i < firstNumber.Length; i++)
            {
                firstNumber[i] = (byte)rnd.Next(0, 10);
                Console.Write(firstNumber[i]);
            }
            Console.WriteLine();
            Console.WriteLine("second number reversed: ");
            for (int i = 0; i < secondNumber.Length; i++)
            {
                secondNumber[i] = (byte)rnd.Next(0, 10);
                Console.Write(secondNumber[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the two: {0}",Sum(firstNumber, secondNumber));

            
            
        }
    }
}
