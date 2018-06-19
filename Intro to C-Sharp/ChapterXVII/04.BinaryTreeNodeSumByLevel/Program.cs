namespace _04.BinaryTreeNodeSumByLevel
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

        public void TraverseDepthFirst()
        {
            this.TraverseDepthFirst(this.Root);
        }

        private void TraverseDepthFirst(TreeNode<T> root)
        {
            Console.WriteLine(root.Value);

            foreach (var child in root.Children)
            {
                TraverseDepthFirst(child);
            }
        }

        public void TraverseBreadthFirst()
        {

            Queue<TreeNode<T>> nodes = new Queue<TreeNode<T>>();
            nodes.Enqueue(this.Root);

            this.TraverseBreadthFirst(nodes);
        }

        private void TraverseBreadthFirst(Queue<TreeNode<T>> nodes)
        {
            if (nodes.Count == 0)
            {
                return;
            }

            TreeNode<T> node = nodes.Dequeue();
            Console.WriteLine(node.Value);

            foreach (var child in node.Children)
            {
                nodes.Enqueue(child);
            }

            this.TraverseBreadthFirst(nodes);
        }
    }

    public class BinaryTree<T>
    {
        public T Value { get; set; }
        public BinaryTree<T> LeftChild { get; set; }
        public BinaryTree<T> RightChild { get; set; }
        public int Count
        {
            get
            {
                return this.GetChildCount();
            }
        }

        public BinaryTree() { }

        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public void TraverseDepthFirst()
        {
            Console.WriteLine(this.Value);

            if (this.LeftChild != null)
            {
                this.LeftChild.TraverseDepthFirst();
            }

            if (this.RightChild != null)
            {
                this.RightChild.TraverseDepthFirst();
            }
        }

        private void GetChildCount(ref int childCount)
        {
            childCount++;

            if (this.LeftChild != null)
            {
                this.LeftChild.GetChildCount(ref childCount);
            }

            if (this.RightChild != null)
            {
                this.RightChild.GetChildCount(ref childCount);
            }
        }

        private int GetChildCount()
        {
            int childCount = 0;
            this.GetChildCount(ref childCount);

            return childCount;
        }

        public Dictionary<int, int> GetSumOfVerticesAtEachLevel()
        {
            Dictionary<int, int> results = new Dictionary<int, int>();
            this.GetSumOfVerticesAtEachLevel(results, 0);

            return results;

        }

        private void GetSumOfVerticesAtEachLevel(Dictionary<int, int> results, int currentLevel)
        {
            if (!results.ContainsKey(currentLevel))
            {
                results.Add(currentLevel, 0);
            }

            results[currentLevel] += int.Parse(this.Value.ToString());
            
            if (this.LeftChild != null)
            {
                this.LeftChild.GetSumOfVerticesAtEachLevel(results, currentLevel + 1);
            }

            if (this.RightChild != null)
            {
                this.RightChild.GetSumOfVerticesAtEachLevel(results, currentLevel + 1);
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> bTree = new BinaryTree<int>(71,
                new BinaryTree<int>(53,
                    new BinaryTree<int>(37,
                        null,
                        null),
                    new BinaryTree<int>(61,
                        null,
                        null)),
                new BinaryTree<int>(83,
                    new BinaryTree<int>(79,
                        null,
                        null),
                    new BinaryTree<int>(88,
                        new BinaryTree<int>(82,
                            new BinaryTree<int>(80,
                                null,
                                null),
                            null),
                        null)));

            //var results = bTree.GetSumOfVerticesAtEachLevel();
            //PrintResults(results);
            Queue<BinaryTree<int>> queue = new Queue<BinaryTree<int>>();
            queue.Enqueue(bTree);
            TraverseBinaryTreeBreadthFirst<int>(queue);
        }

        static void PrintResults(Dictionary<int, int> results)
        {
            foreach (var kvp in results)
            {
                Console.WriteLine($"Level {kvp.Key} sum: {kvp.Value}");
            }
        }

        static void TraverseBinaryTreeBreadthFirst<T>(Queue<BinaryTree<T>> queue)
        {
            if (queue.Count == 0)
            {
                return;
            }

            BinaryTree<T> currentNode = queue.Dequeue();
            Console.WriteLine(currentNode.Value);

            if (currentNode.LeftChild != null)
            {
                queue.Enqueue(currentNode.LeftChild);
            }

            if (currentNode.RightChild != null)
            {
                queue.Enqueue(currentNode.RightChild);
            }

            TraverseBinaryTreeBreadthFirst<T>(queue);
        }

        static void TraverseBinaryTreeDepthFirst<T>(BinaryTree<T> root)
        {
            Console.WriteLine(root.Value);

            if (root.LeftChild != null)
            {
                TraverseBinaryTreeDepthFirst<T>(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                TraverseBinaryTreeDepthFirst<T>(root.RightChild);
            }
        }

        static void UseTree()
        {
            Tree<int> tree = new Tree<int>(
                new TreeNode<int>(1,
                    new TreeNode<int>(2,
                        new TreeNode<int>(3,
                            new TreeNode<int>(4),
                            new TreeNode<int>(5)),
                        new TreeNode<int>(6,
                            new TreeNode<int>(7),
                            new TreeNode<int>(8))),
                    new TreeNode<int>(9,
                        new TreeNode<int>(10),
                        new TreeNode<int>(11))));

            //tree.TraverseDepthFirst();
            tree.TraverseBreadthFirst();
        }
    }
}
