using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifthProblem
{
    class firstInputMembersFibonacciSequence
    {
        static void Main()
        {

            //skip exception catching
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;
            int next = 0;
            int sum = 0;
            if (n == 1)
            {
                Console.Write(sum);
            }
            else if (n == 2)
            {
                Console.Write(sum + 1);
            }
            else
            {

                for (int i = 0; i < n - 2; i++)
                {

                    next = first + second;
                    sum += next;
                    first = second;
                    second = next;


                }

                Console.WriteLine(sum + 1);
            }





        }
    }
}
