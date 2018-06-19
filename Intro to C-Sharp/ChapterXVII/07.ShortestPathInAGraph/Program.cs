namespace _07.ShortestPathInAGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"../../tinyG.txt";
            Graph g = new Graph(filePath);
            Console.WriteLine(g.ToString());

            LinkedList<int> adj = g.GetAdjacentVertices(0);

            foreach (var vertex in adj)
            {
                Console.WriteLine(vertex);
            }
        }
    }
}
