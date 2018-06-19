namespace _01.NumberOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Parent { get; set; }
        public BinaryTreeNode<T> LeftChild { get; set; }
        public BinaryTreeNode<T> RightChild { get; set; }

        public BinaryTreeNode(T value)
        {
            if (value == null)
            {
                throw new Exception("Can't instantiate a node with a null value!");
            }

            this.Value = value;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            BinaryTreeNode<T> other = obj as BinaryTreeNode<T>;

            if (other == null)
            {
                return false;
            }

            return this.CompareTo(other) == 0;
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public int Count { get; private set; }
        public BinaryTreeNode<T> Root { get; private set; }

        public BinarySearchTree() { }

        public BinarySearchTree(BinaryTreeNode<T> root)
        {
            this.Root = root;
        }

        public void Insert(BinaryTreeNode<T> nodeToInsert)
        {
            this.Insert(nodeToInsert, this.Root);
        }

        private void Insert(BinaryTreeNode<T> nodeToInsert, BinaryTreeNode<T> node)
        {
            if (node.CompareTo(nodeToInsert) == 0)
            {
                return;
            }
            else if (nodeToInsert.CompareTo(node) == 1)
            {
                if (node.RightChild == null)
                {
                    nodeToInsert.Parent = node;
                    node.RightChild = nodeToInsert;

                    return;
                }
                else
                {
                    Insert(nodeToInsert, node.RightChild);
                }
            }
            else if (nodeToInsert.CompareTo(node) == -1)
            {
                if (node.LeftChild == null)
                {
                    nodeToInsert.Parent = node;
                    node.LeftChild = nodeToInsert;

                    return;
                }
                else
                {
                    Insert(nodeToInsert, node.LeftChild);
                }
            }
        }

        public BinaryTreeNode<T> Find(T value)
        {
            BinaryTreeNode<T> node = this.Root;

            while (node != null)
            {
                if (value.CompareTo(node.Value) == 1)
                {
                    node = node.RightChild;
                }
                else if (value.CompareTo(node.Value) == -1)
                {
                    node = node.LeftChild;
                }
                else
                {
                    break;
                }
            }

            return node;
        }

        public bool Contains(T value)
        {
            return this.Find(value) != null;
        }

        public void Remove(T value)
        {
            BinaryTreeNode<T> nodeToRemove = this.Find(value);

            if (nodeToRemove == null)
            {
                return;
            }
            else if (nodeToRemove.LeftChild == null && nodeToRemove.RightChild != null)
            {
                nodeToRemove.RightChild.Parent = nodeToRemove.Parent;
                nodeToRemove.RightChild = null;
            }
            else if (nodeToRemove.LeftChild != null && nodeToRemove.RightChild == null)
            {
                nodeToRemove.LeftChild.Parent = nodeToRemove.Parent;
                nodeToRemove.LeftChild = null;
            }
            else if (nodeToRemove.LeftChild == null && nodeToRemove.RightChild == null)
            {
                if (nodeToRemove.Parent == null)
                {
                    this.Root = null;
                }
                else
                {
                    BinaryTreeNode<T> parentRightChild = nodeToRemove.Parent.RightChild;
                    BinaryTreeNode<T> parentLeftChild = nodeToRemove.Parent.LeftChild;

                    if (parentLeftChild == nodeToRemove)
                    {
                        nodeToRemove.Parent.LeftChild = null;
                    }
                    else if (parentRightChild == nodeToRemove)
                    {
                        nodeToRemove.Parent.RightChild = null;
                    }
                }
            }
            else
            {
                BinaryTreeNode<T> replacement = this.GetNodeWithLowestValue(nodeToRemove.RightChild);
                replacement.Parent = nodeToRemove.Parent;
                replacement.LeftChild = nodeToRemove.LeftChild;
                replacement.RightChild = nodeToRemove.RightChild;
            }
        }

        private BinaryTreeNode<T> GetNodeWithLowestValue(BinaryTreeNode<T> node)
        {
            if (node.LeftChild != null)
            {
                this.GetNodeWithLowestValue(node.LeftChild);
            }

            return node;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(new BinaryTreeNode<int>(37));
            BinaryTreeNode<int> node = new BinaryTreeNode<int>(10);
            BinaryTreeNode<int> node1 = new BinaryTreeNode<int>(40);
            BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(13);
            BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(17);
            BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(7);
            BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(1);
            BinaryTreeNode<int> node7 = new BinaryTreeNode<int>(49);
            BinaryTreeNode<int> node8 = new BinaryTreeNode<int>(39);
            binarySearchTree.Insert(node);
            binarySearchTree.Insert(node1);
            binarySearchTree.Insert(node2);
            binarySearchTree.Insert(node3);
            binarySearchTree.Insert(node4);
            binarySearchTree.Insert(node5);
            binarySearchTree.Insert(node6);
            binarySearchTree.Insert(node7);
            binarySearchTree.Insert(node8);
            binarySearchTree.Remove(49);
            Console.WriteLine(binarySearchTree.Contains(39));
        }
    }
}
