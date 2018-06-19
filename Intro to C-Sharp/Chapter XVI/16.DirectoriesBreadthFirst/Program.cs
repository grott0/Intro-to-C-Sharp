namespace _16.DirectoriesBreadthFirst
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo root = new DirectoryInfo(Console.ReadLine());
            Queue<DirectoryInfo> queue = new Queue<DirectoryInfo>();
            queue.Enqueue(root);
            Traverse(queue);
        }

        public static void Traverse(Queue<DirectoryInfo> queue)
        {
            if (queue.Count == 0)
            {
                return;
            }

            DirectoryInfo current = queue.Dequeue();
            Console.WriteLine(current.FullName);

            foreach (var item in current.GetDirectories())
            {
                queue.Enqueue(item);
            }

            Traverse(queue);
        }
    }
}
