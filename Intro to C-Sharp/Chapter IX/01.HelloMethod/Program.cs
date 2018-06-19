using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloMethod
{
    class Program
    {
        static void Hello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string name = Console.ReadLine();
            Hello(name);
        }
    }
}
