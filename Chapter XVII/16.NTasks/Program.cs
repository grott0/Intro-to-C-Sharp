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
            Digraph dg = new Digraph(10);
            dg.AddEdge(3, 1);
            dg.AddEdge(1, 2);
            dg.AddEdge(2, 5);
            dg.AddEdge(2, 4);
            dg.AddEdge(6, 5);
            dg.AddEdge(6, 7);
            dg.AddEdge(8, 6);

            bool[] visited = new bool[dg.V];
            TraverseDepthFirst(dg, 1, visited);

            Console.Write("Unvisited vertices: ");
            for (int vertex = 0; vertex < visited.Length; vertex++)
            {
                if (!visited[vertex] && dg.GetAdjacentVertices(vertex).Count > 0)
                {
                    Console.Write(vertex + " ");
                }
            }
            Console.WriteLine();
        } 

        public static void TraverseDepthFirst(Digraph dg, int source, bool[] visited)
        {
            if (visited[source])
            {
                return;
            }

            visited[source] = true;
            Console.WriteLine(source);

            foreach (var adjacentVertex in dg.GetAdjacentVertices(source))
            {
                TraverseDepthFirst(dg, adjacentVertex, visited);
            }
        }
    }
}
