namespace _05.NodesWithLeafChildren
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BinaryTree<T>
    {
        public T Value { get; set; }
        public BinaryTree<T> LeftChild { get; set; }
        public BinaryTree<T> RightChild { get; set; }

        public BinaryTree(T value)
        {
            this.Value = value;
        }

        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public void TraverseDepthFirst()
        {
            this.TraverseDepthFirst(0);
        }

        private void TraverseDepthFirst(int level)
        {
            Console.WriteLine(new string('-', level) +  this.Value);

            if (this.LeftChild != null)
            {
                this.LeftChild.TraverseDepthFirst(level + 1);
            }

            if (this.RightChild != null)
            {
                this.RightChild.TraverseDepthFirst(level + 1);
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

            bTree.TraverseDepthFirst();
            Console.WriteLine();
            PrintAllNodesWhichHaveOnlyLeafChildren(bTree);
        }

        private static bool PrintAllNodesWhichHaveOnlyLeafChildren<T>(BinaryTree<T> root)
        {
            bool hasChildren = false;
            bool leftChildHasChildren = true;
            bool rightChildHasChildren = true;

            if (root.LeftChild != null)
            {
                hasChildren = true;
                leftChildHasChildren = PrintAllNodesWhichHaveOnlyLeafChildren(root.LeftChild);
            }
            else
            {
                leftChildHasChildren = false;
            }

            if (root.RightChild != null)
            {
                hasChildren = true;
                rightChildHasChildren = PrintAllNodesWhichHaveOnlyLeafChildren(root.RightChild);
            }
            else
            {
                rightChildHasChildren = false;
            }

            if (!rightChildHasChildren && !leftChildHasChildren && (root.LeftChild != null || root.RightChild != null))
            {
                Console.WriteLine(root.Value);
            }

            return hasChildren;

        }
    }
}
