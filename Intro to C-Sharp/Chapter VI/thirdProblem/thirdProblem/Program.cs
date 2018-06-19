using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdProblem
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("{0,15}", "Hearts: ");
            for (int i = 2; i < 15; i++)
            {
                if (i == 11)
                {
                    Console.Write("J ");
                }
                else if (i == 12)
                {
                    Console.Write("Q ");
                }
                else if (i == 13)
                {
                    Console.Write("K ");
                }
                else if (i == 14)
                {
                    Console.Write("A ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,15}", "Tiles: ");
            for (int i = 2; i < 15; i++)
            {
                if (i == 11)
                {
                    Console.Write("J ");
                }
                else if (i == 12)
                {
                    Console.Write("Q ");
                }
                else if (i == 13)
                {
                    Console.Write("K ");
                }
                else if (i == 14)
                {
                    Console.Write("A ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,15}","Clovers: ");
            for (int i = 2; i < 15; i++)
            {
                if (i == 11)
                {
                    Console.Write("J ");
                }
                else if (i == 12)
                {
                    Console.Write("Q ");
                }
                else if (i == 13)
                {
                    Console.Write("K ");
                }
                else if (i == 14)
                {
                    Console.Write("A ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }


            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine("{0,15}", "Spikes: ");
            for (int i = 2; i < 15; i++)
            {
                if (i == 11)
                {
                    Console.Write("J ");
                }
                else if (i == 12)
                {
                    Console.Write("Q ");
                }
                else if (i == 13)
                {
                    Console.Write("K ");
                }
                else if (i == 14)
                {
                    Console.Write("A ");
                }
                else
                {
                    Console.Write(i + " ");
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
