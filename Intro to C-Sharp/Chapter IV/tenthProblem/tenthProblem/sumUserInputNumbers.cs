using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninthProblem
{
    class sumUserInputNumbers
    {
        static void Main()
        {
            int n;
            double sum = 0;
            Console.Write("Enter how many numbers you want to sum: ");
            bool number = int.TryParse(Console.ReadLine(), out n);

            while (number == false)
            {
                Console.Write("You entered an invalid number. Please try again: ");
                number = int.TryParse(Console.ReadLine(), out n);
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Your {0} number is: ", i);
                double m;
                bool repeat = double.TryParse(Console.ReadLine(), out m);

                while (repeat == false)
                {
                    Console.Write("You entered an invalid number. Please try again: ");
                    repeat = double.TryParse(Console.ReadLine(), out m);
                    
                }

                sum += m;

            }
            Console.WriteLine("The sum of the entered numbers is: {0}", sum);
        }
    }
}
