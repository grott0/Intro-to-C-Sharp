using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TimeSinceStarted
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("miliseconds: {0}", Environment.TickCount);
            int tenToTheNegativeThirdSeconds = Environment.TickCount;
            int totalSeconds = tenToTheNegativeThirdSeconds / 1000;
            int totalMinutes = totalSeconds / 60;
            int hours = totalMinutes / 60;
            int seconds = totalSeconds % 60;
            int minutes = totalMinutes % 60;
            Console.WriteLine
                ("Total hours: {0}\nTotal minutes: {1}\nTotal seconds: {2}"
                , hours, totalMinutes, totalSeconds);
            Console.WriteLine("{0}{1} : {2}{3} : {4}{5}"
                , hours.ToString().Length == 1 ? "0" : null
                , hours
                , minutes.ToString().Length == 1 ? "0" : null
                , minutes
                , seconds.ToString().Length == 1 ? "0" : null
                , seconds);


        }
    }
}
