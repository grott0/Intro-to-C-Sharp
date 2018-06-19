namespace _03.InnerEdgesAndLeasfs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public Tree()
        {

        }

        public Tree(TreeNode<T> root)
        {
            this.Root = root;
        }
    }

    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Children = new List<TreeNode<T>>();
            this.Value = value;
        }

        public TreeNode(T value, params TreeNode<T>[] children)
        {
            this.Children = new List<TreeNode<T>>();
            this.Children.AddRange(children);
            this.Value = value;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<TreeNode<int>> leafNodes = new List<TreeNode<int>>();
            List<TreeNode<int>> innerNodes = new List<TreeNode<int>>();
            Tree<int> t = new Tree<int>(
                new TreeNode<int>(1,
                    new TreeNode<int>(2,
                        new TreeNode<int>(3),
                        new TreeNode<int>(4),
                        new TreeNode<int>(5)),
                    new TreeNode<int>(6,
                        new TreeNode<int>(7),
                        new TreeNode<int>(8))));

            GetLeafNodes(t.Root, leafNodes);
            GetInnerNodes(t.Root, innerNodes);
            Print(leafNodes);
            Print(innerNodes);

        }

        /// <summary>
        /// Retrieves all of the inner nodes inside the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="innerNodes"></param>
        private static void GetInnerNodes(TreeNode<int> root, List<TreeNode<int>> innerNodes)
        {
            if (root.Children.Count > 0)
            {
                innerNodes.Add(root);
            }

            foreach (var child in root.Children)
            {
                GetInnerNodes(child, innerNodes);
            }
        }

        /// <summary>
        /// Prints the value of every node in the collection.
        /// </summary>
        /// <typeparam name="T">The type of value contained inside the node.</typeparam>
        /// <param name="nodes">The collection of nodes.</param>
        static void Print<T>(List<TreeNode<T>> nodes)
        {
            Console.WriteLine(string.Join(" ", nodes.Select(x => x.Value.ToString())));
        }

        /// <summary>
        /// Retrieves all of the leaf nodes inside a tree.
        /// </summary>
        /// <param name="root">The root node of the tree.</param>
        /// <param name="leafNodes">The collection in which the leaf nodes will be saved.</param>
        static void GetLeafNodes(TreeNode<int> root, List<TreeNode<int>> leafNodes)
        {
            if (root.Children.Count == 0)
            {
                leafNodes.Add(root);
                return;
            }

            foreach (var child in root.Children)
            {
                GetLeafNodes(child, leafNodes);
            }
        }
    }
}
