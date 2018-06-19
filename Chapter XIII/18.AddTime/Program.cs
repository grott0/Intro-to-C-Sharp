using System;
using System.Globalization;

namespace _18.AddTime
{
    class Program
    {
        static void Main()
        {
            DateTime date = 
                DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            date = date.Add(new TimeSpan(6, 30, 0));
            //date = date.AddHours(6.0);
            //date = date.AddMinutes(30);
            Console.WriteLine(date.ToString());
        }
    }
}
