using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DepthFirstSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph g = new Graph(10);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 7);
            g.AddEdge(1, 8);
            g.AddEdge(1, 7);
            g.AddEdge(1, 4);
            g.AddEdge(2, 7);
            g.AddEdge(7, 6);
            g.AddEdge(7, 4);
            g.AddEdge(6, 5);
            g.AddEdge(5, 9);
            g.AddEdge(9, 4);

            TraverseDepthFirst(g, 0, new bool[g.V]);

        }

        public static void TraverseDepthFirst(Graph g, int source, bool[] visited)
        {
            if (!visited[source])
            {
                Console.WriteLine(source);
                visited[source] = true;

                foreach (var node in g.GetAdjacentVertices(source))
                {
                    TraverseDepthFirst(g, node, visited);
                }
            }

        }
    }
}
