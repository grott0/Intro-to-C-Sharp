using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eighthProblem
{
    class chooseVariableType
    {
        static void Main()
        {
            Console.Write("Enter 0 for string, 1 for integer or 2 for real number: ");
            int type = int.Parse(Console.ReadLine());
            int a;
            double b;
            string c;

            switch(type)
            {
                case 0:
                    c = Console.ReadLine();
                    string d = c + "*";
                    Console.WriteLine(d);
                    break;
                case 1:
                    a = int.Parse(Console.ReadLine());
                    int result = a + 1;
                    Console.WriteLine(result);
                    break;
                case 2:
                    b = double.Parse(Console.ReadLine());
                    double result1 = b + 1;
                    Console.WriteLine(result1);
                    break;
                default:
                    Console.WriteLine("invalid input!");
                    break;
                        
                    

            }
        }
    }
}
