using System;
using System.Collections.Generic;

namespace _10.DirectedGraphBreadthFirst
{
    class Program
    {
        static void Main(string[] args)
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
            g.AddEdge(4, 8);

            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            TraverseBreadthFirstLoop(g, new bool[g.V], q);

        }

        static void TraverseBreadthFirst(Graph g, bool[] visited, Queue<int> queue)
        {
            int v = queue.Dequeue();

            if (!visited[v])
            {
                Console.WriteLine(v);
                visited[v] = true;

                foreach (var adjacent in g.GetAdjacentVertices(v))
                {
                    queue.Enqueue(adjacent);
                }
            }

            if (queue.Count > 0)
            {
                TraverseBreadthFirst(g, visited, queue);
            }
        }

        static void TraverseBreadthFirstLoop(Graph g, bool[] visited, Queue<int> queue)
        {
            while (true)
            {
                if (queue.Count == 0)
                {
                    break;
                }

                int v = queue.Dequeue();

                if (!visited[v])
                {
                    Console.WriteLine(v);
                    visited[v] = true;

                    foreach (var adjacent in g.GetAdjacentVertices(v))
                    {
                        queue.Enqueue(adjacent);
                    }
                }
            }

        }
    }
}
