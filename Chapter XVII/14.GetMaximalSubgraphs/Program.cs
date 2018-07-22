using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.GetMaximalSubgraphs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph g = new Graph(30);
            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(1, 5);
            g.AddEdge(5, 6);
            g.AddEdge(2, 4);
            g.AddEdge(2, 3);
            g.AddEdge(19, 20);
            g.AddEdge(7, 8);
            g.AddEdge(7, 12);
            g.AddEdge(8, 9);
            g.AddEdge(9, 12);
            g.AddEdge(8, 11);
            g.AddEdge(9, 10);
            g.AddEdge(13, 14);
            g.AddEdge(15, 16);
            g.AddEdge(15, 17);

            List<int> allVertices = g.GetAllVertices();
            List<List<int>> subgraphs = GetAllSubgraphs(g, allVertices);

            foreach (var subgraph in subgraphs)
            {
                Console.WriteLine(string.Join(", ", subgraph.OrderBy(x => x)));
            }
        }

        public static List<List<int>> GetAllSubgraphs(Graph g, List<int> allVertices)
        {
            List<List<int>> subgraphs = new List<List<int>>();

            foreach (var vertex in allVertices)
            {
                if (!VertexAlreadyContainedInSubgraphs(vertex, subgraphs))
                {
                    List<int> subgraph = GetSubgraph(g, vertex, new bool[g.V], new List<int>());
                    subgraphs.Add(subgraph);
                }

            }

            return subgraphs;
        }

        public static bool VertexAlreadyContainedInSubgraphs(int vertex, List<List<int>> subgraphs)
        {
            return subgraphs.SelectMany(x => x).Contains(vertex);
        }

        public static List<int> GetSubgraph(Graph g, int vertex, bool[] visited, List<int> buffer)
        {
            if (visited[vertex])
            {
                return buffer;
            }

            buffer.Add(vertex);
            visited[vertex] = true;

            foreach (var adjacentVertex in g.GetAdjacentVertices(vertex))
            {
                GetSubgraph(g, adjacentVertex, visited, buffer);
            }

            return buffer;
        }
    }
}
