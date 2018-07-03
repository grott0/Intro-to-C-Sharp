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
            int source = int.Parse(Console.ReadLine());
            int destination = int.Parse(Console.ReadLine());

            Graph g = new Graph(10);

            g.AddEdge(0, 1);
            g.AddEdge(4, 9);
            g.AddEdge(1, 8);
            g.AddEdge(1, 7);
            g.AddEdge(7, 2);
            g.AddEdge(7, 6);
            g.AddEdge(1, 4);
            g.AddEdge(0, 2);
            g.AddEdge(0, 7);
            g.AddEdge(7, 4);

            List<List<int>> paths = GetAllPaths(g, source, destination, new bool[10], new List<int>(), new List<List<int>>());

            // Print the shortest.

            Console.WriteLine($"Shortest path from {source} to {destination}: "
                + string.Join(", ", paths.OrderBy(x => x.Count).First()));

        }

        public static List<List<int>> GetAllPaths(Graph g, int source, int destination, bool[] visited,
            List<int> path, List<List<int>> paths)
        {
            if (visited[source])
            {
                return paths;
            }

            if (source == destination)
            {
                // Prevent backtracking from altering the final result.
                // Yes, I know it's expensive.
                int[] temp = path.ToArray();
                List<int> copy = new List<int>(temp);
                copy.Add(destination);
                paths.Add(copy.ToList());

                return paths;
            }

            path.Add(source);
            visited[source] = true;

            foreach (int adjacentNode in g.GetAdjacentVertices(source))
            {
                GetAllPaths(g, adjacentNode, destination, visited, path, paths);
            }

            path.Remove(source);
            visited[source] = false;

            return paths;
        }


    }
}
