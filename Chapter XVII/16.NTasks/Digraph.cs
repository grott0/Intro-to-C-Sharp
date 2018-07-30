using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _16.NTasks
{
    public class Digraph
    {
        public int V { get; private set; }
        public int E { get; private set; }
        private LinkedList<int>[] adjacencyLists;


        public Digraph(int V)
        {
            if (V < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.V = V;
            this.E = 0;
            this.adjacencyLists = new LinkedList<int>[V];

            for (int i = 0; i < this.adjacencyLists.Length; i++)
            {
                adjacencyLists[i] = new LinkedList<int>();
            }
        }

        public Digraph(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int v = int.Parse(lines[0].Trim());
            if (v < 0)
                throw new ArgumentOutOfRangeException();
            this.V = v;
            this.adjacencyLists = new LinkedList<int>[this.V];
            for (int i = 0; i < this.adjacencyLists.Length; i++)
            {
                this.adjacencyLists[i] = new LinkedList<int>();
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
                this.adjacencyLists[v1].AddFirst(v2);
                this.adjacencyLists[v2].AddFirst(v1);
            }
        }

        public Digraph(Digraph g) : this(g.V)
        {
            this.E = g.E;

            for (int v = 0; v < g.V; v++)
            {
                Stack<int> reverse = new Stack<int>();

                foreach (int adjacentVertex in g.adjacencyLists[v])
                {
                    reverse.Push(adjacentVertex);
                }

                foreach (int vertex in reverse)
                {
                    this.adjacencyLists[v].AddLast(vertex);
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
            adjacencyLists[v].AddLast(w);
            //adjacencyLists[w].AddLast(v); // Comment out to create a directed graph.
        }

        public LinkedList<int> GetAdjacentVertices(int v)
        {
            this.ValidateVertex(v);

            return this.adjacencyLists[v];
        }

        public List<int> GetAllVertices()
        {
            List<int> vertices = new List<int>();

            for (int i = 0; i < adjacencyLists.Length; i++)
            {
                if (adjacencyLists[i].Count > 0)
                {
                    vertices.Add(i);
                }
            }

            return vertices;
        }

        public int GetDegree(int v)
        {
            this.ValidateVertex(v);

            return this.adjacencyLists[v].Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.V + "vertices, " + this.E + " edges" + Environment.NewLine);

            for (int v = 0; v < this.adjacencyLists.Length; v++)
            {
                sb.Append(v + ": ");

                foreach (int vertex in this.adjacencyLists[v])
                {
                    sb.Append(vertex + " ");
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
