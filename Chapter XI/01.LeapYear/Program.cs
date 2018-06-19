using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the year you wish to check(0001-9999): ");
            string input = Console.ReadLine();
            int year = 0;
            while ((int.TryParse(input, out year) == false) || (input.Length != 4))
            {
                Console.Write("invalid input.try again: ");
                input = Console.ReadLine();
            }

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
        }
    }
}
