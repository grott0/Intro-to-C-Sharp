using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dayOfWeek = DateTime.Today;
            Console.WriteLine(dayOfWeek.ToString());
            Console.WriteLine("Today is: {0}",dayOfWeek.DayOfWeek);
        }
    }
}
