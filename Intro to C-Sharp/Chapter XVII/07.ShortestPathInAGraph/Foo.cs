using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ShortestPathInAGraph
{
    class Foo
    {
        public static void DoWork()
        {
            FooNode a = new FooNode("NodeA");
            FooNode b = new FooNode("NodeB");
            FooNode c = new FooNode("NodeC");
            FooNode d = new FooNode("NodeD");
            FooNode e = new FooNode("NodeE");
            FooNode f = new FooNode("NodeF");

            FooEdge edge1 = new FooEdge(a, d);
            FooEdge edge2 = new FooEdge(d, c);
            FooEdge edge3 = new FooEdge(c, b);
            FooEdge edge4 = new FooEdge(d, b);
            FooEdge edge5 = new FooEdge(d, e);
            FooEdge edge6 = new FooEdge(e, c);
            FooEdge edge7 = new FooEdge(e, f);

            FooGraph graph = new FooGraph();
            graph.AddEdge(edge1);
            graph.AddEdge(edge2);
            graph.AddEdge(edge3);
            graph.AddEdge(edge4);
            graph.AddEdge(edge5);
            graph.AddEdge(edge6);
            graph.AddEdge(edge7);
        }
        public static void TraverseGraph(FooGraph g)
        {
            List<FooNode> visited = new List<FooNode>();

            foreach (var edge in g.Edges)
            {
                if (!visited.Contains(edge.NodeA))
                {
                    Console.WriteLine(edge.NodeA.Value);
                    visited.Add(edge.NodeA);
                }

                if (!visited.Contains(edge.NodeB))
                {
                    Console.WriteLine(edge.NodeB.Value);
                    visited.Add(edge.NodeB);
                }
            }
        }

        public static List<FooEdge> GetAdjacentEdges(FooEdge e, FooGraph g)
        {
            List<FooEdge> allEdgesExceptCurrent = g.Edges.Where(x => x != e).ToList();
            List<FooEdge> adjacentEdges = new List<FooEdge>();
            FooNode nodeA = e.NodeA;
            FooNode nodeB = e.NodeB;

            foreach (var edge in allEdgesExceptCurrent.Where(x => x.NodeA == nodeA || x.NodeB == nodeA))
            {
                adjacentEdges.Add(edge);
            }

            foreach (var edge in allEdgesExceptCurrent.Where(x => x.NodeA == nodeB || x.NodeB == nodeB))
            {
                adjacentEdges.Add(edge);
            }

            return adjacentEdges;
        }

        public static List<FooEdge> GetAdjacentEdges(FooNode n, FooGraph g)
        {
            return g.Edges.Where(e => e.NodeA == n || e.NodeB == n).ToList();
        }
    }

    public class FooEdge
    {
        public FooNode NodeA { get; set; }
        public FooNode NodeB { get; set; }

        public FooEdge(FooNode nodeA, FooNode nodeB)
        {
            this.NodeA = nodeA;
            this.NodeB = nodeB;
        }
    }

    public class FooNode
    {
        public string Value { get; set; }

        public FooNode(string value)
        {
            this.Value = value;
        }
    }

    public class FooGraph
    {
        public List<FooEdge> Edges { get; private set; }

        public FooGraph()
        {
            this.Edges = new List<FooEdge>();
        }

        public bool AddEdge(FooEdge e)
        {
            if (this.Edges.Contains(e))
            {
                return false;
            }

            if (this.Edges.FirstOrDefault(x => x.NodeA == e.NodeA && x.NodeB == e.NodeB) != null)
            {
                return false;
            }

            this.Edges.Add(e);

            return true;
        }
    }
}
