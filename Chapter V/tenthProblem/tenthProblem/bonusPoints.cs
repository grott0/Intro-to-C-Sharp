using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenthProblem
{
    class bonusPoints
    {
        static void Main()
        {
            double points = double.Parse(Console.ReadLine());
            double totalPoints = 0;

            if (points > 0 && points <= 9)
            {
                if (points >= 1 && points <= 3)
                {
                    totalPoints = points * 10;
                    Console.WriteLine("{0} * 10 = {1}", points, totalPoints);
                }
                else if (points > 3 && points <= 6)
                {
                    totalPoints = points * 100;
                    Console.WriteLine("{0} * 100 = {1}", points, totalPoints);
                }
                else if (points > 6 && points <= 9)
                {
                    totalPoints = points * 1000;
                    Console.WriteLine("{0} * 1000 = {1}", points, totalPoints);
                }
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
