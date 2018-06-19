using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleventhProblem
{
    class employeesData
    {
        static void Main()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter \"m\" for male and \"f\" for female: ");
            char genderKey = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter your age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Enter security number: ");
            //Use of string in case number starts with zero
            string security = Console.ReadLine();
            string genderWord = null;

            if (genderKey == 'm')
            {
                genderWord = "male";
            }
            else if (genderKey == 'f')
            {
                genderWord = "female";
            }
            else
            {
                Console.WriteLine("You have entered an invalid character!");
                Environment.Exit(0);
            }

            Console.WriteLine("You are: {0} {1}. A {2} year old {3}. Security number: {4}", firstName, lastName, age, genderWord, security);


        }
    }
}
