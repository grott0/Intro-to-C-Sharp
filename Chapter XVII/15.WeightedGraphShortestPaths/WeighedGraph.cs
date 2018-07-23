using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.WeightedGraphShortestPaths
{
    public class WeightedGraph
    {
        private int[][] adjacencyMatrix;

        public int V { get; private set; }
        public int E { get; private set; }

        public WeightedGraph(int V)
        {
            this.V = V;
            this.E = 0;
            this.adjacencyMatrix = new int[this.V][];

            for (int i = 0; i < adjacencyMatrix.Length; i++)
            {
                adjacencyMatrix[i] = new int[this.V];
            }
        }

        public void AddEdge(int v, int w, int weight)
        {
            if (this.adjacencyMatrix[v][w] == 0)
            {
                this.E++;
            }

            this.adjacencyMatrix[v][w] = weight;
            this.adjacencyMatrix[w][v] = weight;
        }

        public IEnumerable<int> GetAdjacentVertices(int v)
        {
            if (!VertexIsValid(v))
            {
                throw new ArgumentOutOfRangeException();
            }

            List<int> adjacent = new List<int>();

            for (int i = 0; i < this.adjacencyMatrix[v].Length; i++)
            {
                if (this.adjacencyMatrix[v][i] != 0)
                {
                    adjacent.Add(i);
                }
            }

            return adjacent;
        }

        public bool VertexIsValid(int v)
        {
            if (v < 0 || v >= this.V)
            {
                return false;
            }

            return true;
        }

        public bool EdgeExists(int v, int w)
        {
            if (this.adjacencyMatrix[v][w] != 0)
            {
                return true;
            }

            return false;
        }

        public int GetEdgeWeight(int v, int w)
        {
            if (!EdgeExists(v,w))
            {
                throw new Exception();
            }

            return this.adjacencyMatrix[v][w];
        }

    }
}
