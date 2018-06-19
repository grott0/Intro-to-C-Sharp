namespace _02.SubtreesWithKChildren
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TreeNode<T>
    {
        public T Value { get; private set; }
        public List<TreeNode<T>> Children { get; private set; }

        public TreeNode(T value)
        {
            this.Children = new List<TreeNode<T>>();
            this.Value = value;
        }

        public TreeNode(T value, params TreeNode<T>[] children) : this(value)
        {
            this.Children = new List<TreeNode<T>>();
            this.Children.AddRange(children);
        }

        public void AddChild(TreeNode<T> child)
        {
            this.Children.Add(child);
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public Tree() { }

        public Tree(TreeNode<T> root)
        {
            this.Root = root;
        }

        public void TraverseDepthFirst()
        {
            this.TraverseDepthFirst(this.Root);
        }

        private void TraverseDepthFirst(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            foreach (var child in node.Children)
            {
                Console.WriteLine(child.Value);
                TraverseDepthFirst(child);
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            Tree<int> tree = ConstructTree();
            //tree.TraverseDepthFirst();
            List<TreeNode<int>> allNodes = GetAllNodes(new List<TreeNode<int>>(new TreeNode<int>[] { tree.Root }), tree.Root);

            foreach (var node in allNodes)
            {
                int numberOfChildren = 0;
                GetNumberOfChildren(node, ref numberOfChildren);

                if (numberOfChildren > k)
                {
                    Console.WriteLine(node.Value);
                }
            }
        }

        static Tree<int> ConstructTree()
        {
            Tree<int> tree = new Tree<int>(
                new TreeNode<int>(1,
                    new TreeNode<int>(2,
                        new TreeNode<int>(3),
                        new TreeNode<int>(4),
                        new TreeNode<int>(5)),
                    new TreeNode<int>(6, 
                        new TreeNode<int>(7),
                        new TreeNode<int>(8)),
                    new TreeNode<int>(9)));

            return tree;
        }

        static List<TreeNode<int>> GetAllNodes(List<TreeNode<int>> nodes, TreeNode<int> currentNode)
        {
            if (currentNode == null)
            {
                return nodes;
            }

            foreach (var child in currentNode.Children)
            {
                nodes.Add(child);
                GetAllNodes(nodes, child);
            }

            return nodes;
        }

        static int GetNumberOfChildren(TreeNode<int> node, ref int childrenCnt)
        {
            if (node == null)
            {
                return childrenCnt;
            }

            foreach (var child in node.Children)
            {
                childrenCnt++;
                GetNumberOfChildren(child, ref childrenCnt);
            }

            return childrenCnt;
        }
    }
}
