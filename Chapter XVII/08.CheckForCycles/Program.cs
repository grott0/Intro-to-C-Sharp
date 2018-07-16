using System;
using System.Collections.Generic;
using System.Linq;

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

            Graph g1 = new Graph(10);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 4);
            g.AddEdge(1, 6);
            g.AddEdge(1, 7);
            g.AddEdge(2, 5);
            g.AddEdge(2, 8);

            bool containsCycle = GraphContainsCycle(g1);
            Console.WriteLine(containsCycle);


        }

        public static bool GraphContainsCycle(Graph g)
        {
            for (int i = 0; i < g.V; i++)
            {
                var adjacents = g.GetAdjacentVertices(i);

                if (adjacents.Count < 2)
                {
                    continue;
                }

                for (int j = 0; j < adjacents.Count; j++)
                {
                    for (int k = j + 1; k < adjacents.Count; k++)
                    {
                        bool[] visited = new bool[g.V];
                        visited[i] = true;
                        var paths = GetAllPaths(g, j, k, visited, new List<int>(), new List<List<int>>());

                        if (paths.Count > 0)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
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
