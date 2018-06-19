using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.GenerateSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            queue.Enqueue(n);

            while (cnt < 50)
            {
                int currentHead = queue.Dequeue();
                queue.Enqueue(currentHead + 1);
                queue.Enqueue((2 * currentHead) + 1);
                queue.Enqueue(currentHead + 2);
                Console.WriteLine(currentHead);
                cnt++;
            }
        }
    }
}
