using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DepthFirstSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Graph g = new Graph(10);
            g.AddEdge(0,1, 3);
            g.AddEdge(0,2,1);
            g.AddEdge(1, 6, 4);
            g.AddEdge(1, 3, 2);
            g.AddEdge(1, 7, 5);
            g.AddEdge(2, 4, 8);
            g.AddEdge(2, 5, 4);
            g.AddEdge(2, 3, 8);

            var adjacents = g.GetAdjacentVertices(1);

            Console.WriteLine(string.Join(", ", adjacents));
        }
    }
}
