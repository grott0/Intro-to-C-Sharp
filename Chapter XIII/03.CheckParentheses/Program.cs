using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckParentheses
{
    class Program
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            int countParentheses = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    countParentheses++;
                }
                else if (expression[i] == ')')
                {
                    countParentheses--;
                }
            }

            if (countParentheses == 0)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("incorrect");
            }
        }
    }
}
