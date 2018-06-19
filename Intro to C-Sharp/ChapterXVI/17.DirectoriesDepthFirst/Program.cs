namespace _17.DirectoriesDepthFirst
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo root = new DirectoryInfo(Console.ReadLine());
            Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();
            stack.Push(root);
            Traverse(stack);
        }

        public static void Traverse(Stack<DirectoryInfo> queue)
        {
            if (queue.Count == 0)
            {
                return;
            }

            DirectoryInfo current = queue.Pop();
            Console.WriteLine(current.FullName);

            foreach (var item in current.GetDirectories())
            {
                queue.Push(item);
            }

            Traverse(queue);
        }
    }
}
