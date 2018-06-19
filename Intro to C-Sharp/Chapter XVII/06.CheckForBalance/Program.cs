namespace _06.CheckForBalance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
            this.Value = value;
            this.Children.AddRange(children);
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

        public bool IsBinaryAndPerfectlyBalanced()
        {
            Dictionary<int, int> data = new Dictionary<int, int>();
            Queue<TreeNode<T>> nodes = new Queue<TreeNode<T>>();
            nodes.Enqueue(this.Root);
            this.TraverseBreadthFirst(nodes, 0, data);

            foreach (var kvp in data)
            {
                if (kvp.Key == 0)
                {
                    continue;
                }

                if (kvp.Value % 2 != 0)
                {
                    return false;
                }

            }

            return true;
        }

        private void TraverseBreadthFirst(Queue<TreeNode<T>> nodes, int level, Dictionary<int, int> data)
        {
            if (nodes.Count == 0)
            {
                return;
            }

            TreeNode<T> currentNode = nodes.Dequeue();
            Console.WriteLine(new string('-', level) +  currentNode.Value);

            if (!data.ContainsKey(level))
            {
                data.Add(level, 1);
            }
            else
            {
                data[level]++;
            }

            foreach (var child in currentNode.Children)
            {
                nodes.Enqueue(child);
                TraverseBreadthFirst(nodes, level + 1, data);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Tree<int> balancedBinaryTree = new Tree<int>(new TreeNode<int>(0,
                new TreeNode<int>(1,
                    new TreeNode<int>(3,
                        new TreeNode<int>(7),
                        new TreeNode<int>(8)),
                    new TreeNode<int>(4)),
                new TreeNode<int>(2,
                    new TreeNode<int>(5),
                    new TreeNode<int>(6))));

            Tree<int> tree = new Tree<int>(new TreeNode<int>(0,
    new TreeNode<int>(1,
        new TreeNode<int>(3),
        new TreeNode<int>(4)),
    new TreeNode<int>(2,
        new TreeNode<int>(5),
        new TreeNode<int>(6),
        new TreeNode<int>(7))));

            bool shouldBe = balancedBinaryTree.IsBinaryAndPerfectlyBalanced();
            bool shouldNotBe = tree.IsBinaryAndPerfectlyBalanced();

            Console.WriteLine(shouldBe);
            Console.WriteLine(shouldNotBe);
        }
    }
}
