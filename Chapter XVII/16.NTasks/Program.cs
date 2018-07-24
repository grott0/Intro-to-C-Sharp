using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NTasks
{
    public class Pair
    {
        public int Task { get; set; }
        public int DependentTask { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of tasks which have to be performed: ");
            int n = int.Parse(Console.ReadLine());

        }
    }
}
