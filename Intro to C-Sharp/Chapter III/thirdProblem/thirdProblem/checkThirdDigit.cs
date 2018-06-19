using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdProblem
{
    class checkThirdDigit
    {
        static void Main()
        {
            Console.Write("Enter a number between -2,147,483,647 and 2,147,483,647: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1000000000)
            {
                n /= 10000000;
                Console.WriteLine("The third digit is: {0}", n % 10);
            }
            else if(n >= 100000000)
            {
                n /= 1000000;
                Console.WriteLine("The third digit is: {0}", n % 10);
            }
            else if (n >= 10000000)
            {
                n /= 100000;
                Console.WriteLine("The third digit is: {0}", n % 10);
            }
            else if (n >= 1000000)
            {
                n /= 10000;
                Console.WriteLine("The third digit is: {0}", n % 10);
            }
            else if (n >= 100000)
            {
                n /= 1000;
                Console.WriteLine("The third digit is: {0}", n % 10);
            }
            else if (n >= 10000)
            {
                n /= 100;
                Console.WriteLine("The third digit is: {0}", n % 10);
            }
            else if (n >= 1000)
            {
                n /= 10;
                Console.WriteLine("The third digit is: {0}", n % 10);
            }
            else if (n >= 100)
            {
                Console.WriteLine("The third digit is: {0}", n % 10);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

        }

    }
}
