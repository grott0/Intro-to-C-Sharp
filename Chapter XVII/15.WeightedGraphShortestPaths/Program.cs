﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.WeightedGraphShortestPaths
{

    public class Program
    {
        static void Main(string[] args)
        {
            WeightedGraph wg = new WeightedGraph(10);
            wg.AddEdge(0, 3, 7);
            wg.AddEdge(0, 1, 4);
            wg.AddEdge(0, 2, 3);
            wg.AddEdge(0, 8, 6);
            wg.AddEdge(3, 4, 5);
            wg.AddEdge(3, 8, 4);
            wg.AddEdge(4, 2, 6);
            wg.AddEdge(2, 9, 8);
            wg.AddEdge(2, 7, 7);
            wg.AddEdge(1, 7, 11);
            wg.AddEdge(1, 5, 4);
            wg.AddEdge(1, 6, 6);
            wg.AddEdge(5, 6, 4);

            bool foundPath = false;
            int distance = 0;
            int source = 0;
            int destination = 9;
            GetDistance(wg, -1, source, destination, ref distance, new bool[wg.V], ref foundPath);

            if (foundPath)
            {
                Console.WriteLine($"{source} -> {destination} distance: {distance}");
            }
        }

        // Searching for the first path we can find. Backtracking is not necessary.
        static List<int> GetPath(WeightedGraph wg, int source, int destination,
            List<int> path, bool[] visited, ref bool foundPath)
        {
            if (visited[source] || foundPath)
            {
                return path;
            }

            if (source == destination)
            {
                foundPath = true;
                path.Add(destination);
                return path;
            }

            visited[source] = true;
            path.Add(source);

            foreach (var adjacentVertex in wg.GetAdjacentVertices(source))
            {
                GetPath(wg, adjacentVertex, destination, path, visited, ref foundPath);
            }

            return path;
        }

        static int GetDistance(WeightedGraph wg, int parent, int current, int destination, ref int distance,
            bool[] visited, ref bool foundPath)
        {
            if (visited[current] || foundPath)
            {
                return distance;
            }

            if (current == destination)
            {
                foundPath = true;
                return distance;
            }

            visited[current] = true;

            foreach (var adjacentVertex in wg.GetAdjacentVertices(current))
            {
                if (!foundPath)
                {
                    distance += wg.GetEdgeWeight(current, adjacentVertex);
                    GetDistance(wg, current, adjacentVertex, destination, ref distance, visited, ref foundPath);
                }
            }

            return distance;
        }
    }
}
