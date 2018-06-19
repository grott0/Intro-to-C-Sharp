using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _09.WorkDays
{
    class Program
    {
        static void Main()
        {
            
            string input = Console.ReadLine();
            DateTime startDate = new DateTime();
            string format = "dd-MM-yy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            bool convert = 
                DateTime.TryParseExact(input, format, provider, startDate);
        }
    }
}
