using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.FormatNumber
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", n);
            Console.WriteLine("{0,15:P}", n);
            Console.WriteLine("{0,15:E}", n);
            Console.WriteLine("{0,15:C}", n);
            Console.WriteLine("{0,15:X}", (int)n);
        }
    }
}
