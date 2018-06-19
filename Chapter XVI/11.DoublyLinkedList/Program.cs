using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DoublyLinkedList
{
    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
        public int Index { get; set; }
        public DoublyLinkedList<T> List { get; set; }

        public DoublyLinkedListNode(T value)
        {
            this.Value = value;
        }

        public DoublyLinkedListNode(T value, int index) : this(value)
        {
            this.Index = index;
        }
    }

    public class DoublyLinkedList<T>
    {
        public int Count { get; private set; }

        private DoublyLinkedListNode<T> head;

        public DoublyLinkedListNode<T> this[int index]
        {
            get
            {
                return this.FindNode(index);
            }
            set
            {
                DoublyLinkedListNode<T> node = this.FindNode(index);
                node = value;
            }
        }

        public DoublyLinkedList() { }

        public DoublyLinkedList(T value)
        {
            this.head = new DoublyLinkedListNode<T>(value);
            this.head.Index = 0;
            this.Count++;
        }

        public DoublyLinkedList(T[] collection)
        {
            if (collection.Length != 0)
            {
                this.head = new DoublyLinkedListNode<T>(collection[0]);
                this.head.Index = 0;
                this.Count++;
                DoublyLinkedListNode<T> currentNode = this.head;

                for (int i = 1; i < collection.Length; i++)
                {
                    DoublyLinkedListNode<T> nextNode = new DoublyLinkedListNode<T>(collection[i]);
                    nextNode.Index = i;
                    nextNode.Previous = currentNode;
                    currentNode.Next = nextNode;
                    currentNode = nextNode;
                    this.Count++;
                }
            }
            else
            {
                this.head = new DoublyLinkedListNode<T>(collection[0], 0);
                this.Count++;
            }
        }

        public void Add(T value)
        {
            DoublyLinkedListNode<T> lastNode = this.FindNode(this.Count - 1);
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value, this.Count);
            newNode.Previous = lastNode;
            lastNode.Next = newNode;
            this.Count++;
        }

        public void Add(DoublyLinkedListNode<T> node)
        {
            DoublyLinkedListNode<T> lastNode = this.FindNode(this.Count - 1);
            node.Index = lastNode.Index + 1;
            lastNode.Next = node;
            this.Count++;
        }

        private DoublyLinkedListNode<T> FindNode(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (this.head == null)
            {
                throw new Exception("The list is empty!");
            }

            DoublyLinkedListNode<T> currentNode = this.head;
            DoublyLinkedListNode<T> result = null;

            while (currentNode != null)
            {
                if (currentNode.Index == index)
                {
                    result = currentNode;
                    break;
                }

                currentNode = currentNode.Next;
            }

            return result;
        }

        private void NormalizeIndexes(DoublyLinkedListNode<T> startNode)
        {
            DoublyLinkedListNode<T> currentNode = startNode;
            int currentIndex;

            // The head has been removed.
            if (currentNode == null)
            {
                currentIndex = 0;
                currentNode = this.head;

                while (currentNode != null)
                {
                    currentNode.Index = currentIndex;
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
            }
            else
            {
                currentIndex = currentNode.Index;

                while (currentNode != null)
                {
                    currentNode.Index = currentIndex;
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
            }
        }

        /// <summary>
        /// Inserts a value at the specified index.
        /// </summary>
        public void InsertAt(T value, int index)
        {
            DoublyLinkedListNode<T> nodeToInsert;

            if (index == 0)
            {
                nodeToInsert = new DoublyLinkedListNode<T>(value, index);
                nodeToInsert.Next = this.head;
                this.head = nodeToInsert;
                this.Count++;
                this.NormalizeIndexes(this.head);
                return;
            }
            else
            {
                DoublyLinkedListNode<T> prevNode = this.FindNode(index).Previous;
                nodeToInsert = new DoublyLinkedListNode<T>(value, index);
                nodeToInsert.Next = prevNode.Next;
                nodeToInsert.Previous = prevNode;
                prevNode.Next = nodeToInsert;
                this.Count++;
                this.NormalizeIndexes(prevNode);
            }
        }

        public void RemoveAt(int index)
        {
            DoublyLinkedListNode<T> nodeToRemove = this.FindNode(index);

            if (index == 0)
            {
                this.head = this.head.Next;
                this.head.Previous.Next = null;
                this.Count--;
                this.NormalizeIndexes(null);

            }
            else if (index == this.Count - 1)
            {
                nodeToRemove.Previous.Next = nodeToRemove.Next;
                nodeToRemove.Previous = null;
                this.Count--;

            }
            else
            {
                nodeToRemove.Previous.Next = nodeToRemove.Next;
                nodeToRemove.Next.Previous = nodeToRemove.Previous;
                this.Count--;
                this.NormalizeIndexes(nodeToRemove.Previous);
                nodeToRemove.Next = null;
                nodeToRemove.Previous = null;
            }
        }


        public void Remove(T value)
        {
            DoublyLinkedListNode<T> currentNode = this.head;

            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                {
                    this.RemoveAt(currentNode.Index);
                    break;
                }

                currentNode = currentNode.Next;
            }
        }

        public void Remove(DoublyLinkedListNode<T> node)
        {
            if (node.Previous == null)
            {
                this.head = node.Next;
                node.Next = null;
                NormalizeIndexes(null);
            }
            else if (node.Next == null)
            {
                node.Previous.Next = null;
                node.Previous = null;
            }
            else
            {
                DoublyLinkedListNode<T> prevNode = node.Previous;
                DoublyLinkedListNode<T> nextNode = node.Next;
                node.Previous = null;
                node.Next = null;
                prevNode.Next = nextNode;
                nextNode.Previous = prevNode;
                this.NormalizeIndexes(prevNode);
            }

            this.Count--;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            DoublyLinkedListNode<T> currentNode = this.head;

            while (currentNode != null)
            {
                arr[currentNode.Index] = currentNode.Value;
                currentNode = currentNode.Next;
            }

            return arr;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            list.Add(new DoublyLinkedListNode<int>(9));
            Console.WriteLine(list[8].Value);
        }
    }
}
