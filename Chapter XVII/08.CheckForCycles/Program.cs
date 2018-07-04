using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CheckForCycles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(10);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 7);
            g.AddEdge(1, 8);
            g.AddEdge(1, 4);
            g.AddEdge(1, 7);
            g.AddEdge(4, 9);
            g.AddEdge(4, 7);
            g.AddEdge(7, 2);
            g.AddEdge(7, 6);
            g.AddEdge(9, 5);
            g.AddEdge(5, 6);

            List<List<int>> paths = GetAllPaths(g, 0, 5, new bool[g.V], new List<int>(), new List<List<int>>());

            foreach (var path in paths)
            {
                Console.WriteLine(string.Join(", ", path));
            }
        }

        public static List<List<int>> GetAllPaths(Graph g, int source, int destination, bool[] visited,
            List<int> path, List<List<int>> paths)
        {
            if (source == destination)
            {
                path.Add(destination);
                int[] temp = path.ToArray();
                paths.Add(temp.ToList());
                path.Remove(destination);

                return paths;
            }

            if (visited[source])
            {
                return paths;
            }

            path.Add(source);
            visited[source] = true;

            foreach (int adjacentVertex in g.GetAdjacentVertices(source))
            {
                GetAllPaths(g, adjacentVertex, destination, visited, path, paths);
            }

            visited[source] = false;
            path.Remove(source);
            return paths;
        }
    }
}
