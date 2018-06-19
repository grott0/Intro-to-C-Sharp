using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.TimeBetweenDates
{
    class Program
    {
        static void Main()
        {
            DateTime firstDate = 
                DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = 
                DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            TimeSpan interval = secondDate - firstDate;
            Console.WriteLine("Distance: {0} days", Math.Abs(interval.Days).ToString());
        }
    }
}
