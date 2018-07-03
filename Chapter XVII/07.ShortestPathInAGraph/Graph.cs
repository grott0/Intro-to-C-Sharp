using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ShortestPathInAGraph
{
    public class Graph
    {
        public int V { get; private set; }
        public int E { get; private set; }
        private LinkedList<int>[] adjacencyList;


        public Graph(int V)
        {
            if (V < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.V = V;
            this.E = 0;
            this.adjacencyList = new LinkedList<int>[V];

            for (int i = 0; i < this.adjacencyList.Length; i++)
            {
                adjacencyList[i] = new LinkedList<int>();
            }
        }

        public Graph(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int v = int.Parse(lines[0].Trim());
            if (v < 0)
                throw new ArgumentOutOfRangeException();
            this.V = v;
            this.adjacencyList = new LinkedList<int>[this.V];
            for (int i = 0; i < this.adjacencyList.Length; i++)
            {
                this.adjacencyList[i] = new LinkedList<int>();
            }

            int e = int.Parse(lines[1].Trim());
            if (e < 0)
                throw new ArgumentOutOfRangeException();
            this.E = e;
            for (int i = 2; i < this.E; i++)
            {
                string[] lineArgs = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int v1 = int.Parse(lineArgs[0].Trim());
                int v2 = int.Parse(lineArgs[1].Trim());
                this.ValidateVertex(v1);
                this.ValidateVertex(v2);
                this.adjacencyList[v1].AddFirst(v2);
                this.adjacencyList[v2].AddFirst(v1);
            }
        }

        public Graph(Graph g) : this(g.V)
        {
            this.E = g.E;

            for (int v = 0; v < g.V; v++)
            {
                Stack<int> reverse = new Stack<int>();

                foreach (int adjacentVertex in g.adjacencyList[v])
                {
                    reverse.Push(adjacentVertex);
                }

                foreach (int vertex in reverse)
                {
                    this.adjacencyList[v].AddLast(vertex);
                }
            }
        }

        private void ValidateVertex(int v)
        {
            if (v < 0 || v >= this.V)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void AddEdge(int v, int w)
        {
            this.ValidateVertex(v);
            this.ValidateVertex(w);
            this.E++;
            adjacencyList[v].AddLast(w);
            adjacencyList[w].AddLast(v); // Comment out to create a directed graph.
        }

        public LinkedList<int> GetAdjacentVertices(int v)
        {
            this.ValidateVertex(v);

            return this.adjacencyList[v];
        }

        public int GetDegree(int v)
        {
            this.ValidateVertex(v);

            return this.adjacencyList[v].Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.V + "vertices, " + this.E + " edges" + Environment.NewLine);

            for (int v = 0; v < this.adjacencyList.Length; v++)
            {
                sb.Append(v + ": ");

                foreach (int vertex in this.adjacencyList[v])
                {
                    sb.Append(vertex + " ");
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }


    }
}
