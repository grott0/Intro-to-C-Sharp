using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ShortestOperationsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            List<int> dequeued = new List<int>();
            queue.Enqueue(n);

            while (true)
            {
                int currentHead = queue.Dequeue();
                dequeued.Add(currentHead);

                if (currentHead == m)
                {
                    Console.WriteLine(string.Join(" ", dequeued));
                    break;
                }

                queue.Enqueue(currentHead + 1);
                queue.Enqueue(currentHead + 2);
                queue.Enqueue(currentHead * 2);
            }
        }
    }
}
