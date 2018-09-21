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

        public int VertexCount { get; private set; }
        public int EdgeCount { get; private set; }

        public WeightedGraph(int vertexCount)
        {
            this.VertexCount = vertexCount;
            this.EdgeCount = 0;
            this.adjacencyMatrix = new int[this.VertexCount][];

            for (int index = 0; index < adjacencyMatrix.Length; index++)
            {
                adjacencyMatrix[index] = new int[this.VertexCount];
            }
        }

        public void AddEdge(int sourceVertex, int destinationVertex, int weight)
        {
            if (this.adjacencyMatrix[sourceVertex][destinationVertex] == 0)
            {
                this.EdgeCount++;
            }

            this.adjacencyMatrix[sourceVertex][destinationVertex] = weight;
            this.adjacencyMatrix[destinationVertex][sourceVertex] = weight;
        }

        public IEnumerable<int> GetAdjacentVertices(int vertex)
        {
            if (!VertexIsValid(vertex))
            {
                throw new ArgumentOutOfRangeException();
            }

            List<int> adjacent = new List<int>();

            for (int i = 0; i < this.adjacencyMatrix[vertex].Length; i++)
            {
                if (this.adjacencyMatrix[vertex][i] != 0)
                {
                    adjacent.Add(i);
                }
            }

            return adjacent;
        }

        public bool VertexIsValid(int vertex)
        {
            if (vertex < 0 || vertex >= this.VertexCount)
            {
                return false;
            }

            return true;
        }

        public bool EdgeExists(int sourceVertex, int destinationVertex)
        {
            if (this.adjacencyMatrix[sourceVertex][destinationVertex] != 0)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        ///  Gets the weight of an edge.
        /// </summary>
        /// <param name="sourceVertex">Source.</param>
        /// <param name="destinationVertex">Destination.</param>
        /// <returns>The weight of the edge. 0 if the edge does not exist.</returns>
        public int GetEdgeWeight(int sourceVertex, int destinationVertex)
        {
            return this.adjacencyMatrix[sourceVertex][destinationVertex];
        }

    }
}
