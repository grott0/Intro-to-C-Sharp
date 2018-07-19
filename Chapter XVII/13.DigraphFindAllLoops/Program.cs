using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DigraphFindAllLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Digraph g = new Digraph(10);
            g.AddEdge(0, 1);
            g.AddEdge(0, 7);
            g.AddEdge(7, 7);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(2, 4);
            g.AddEdge(2, 6);
            g.AddEdge(6, 3);
            g.AddEdge(3, 3);
            g.AddEdge(5, 5);
            g.AddEdge(4, 4);

            List<int> loops = GetAllLoops(g);
            Console.WriteLine("Loop vertices: " + string.Join(", ", loops));

        }

        static List<int> GetAllLoops(Digraph g)
        {

            List<int> vertices = g.GetAllVertices();
            List<int> loops = new List<int>();

            foreach (var vertex in vertices)
            {
                bool isLoop = IsLoop(g, vertex);

                if (isLoop)
                {
                    loops.Add(vertex);
                }
            }

            return loops;
        }

        static bool IsLoop(Digraph g, int v)
        {
            // If the adjacency list of vertex v contains itself, this vertex forms a loop.
            return g.GetAdjacentVertices(v).Contains(v);
        }
    }
}
