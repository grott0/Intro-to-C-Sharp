namespace _12.DynamicStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class OrdinaryStack<T>
    {
        private const int Initial_Size = 5;
        private T[] buffer = new T[Initial_Size];
        public int Count { get; private set; }

        public OrdinaryStack() { }

        public OrdinaryStack(T value)
        {
            this.Push(value);
        }

        public OrdinaryStack(IEnumerable<T> collection)
        {
            if (collection == null || collection.Count() == 0)
            {
                throw new Exception("The collection is empty.");
            }

            foreach (var value in collection)
            {
                this.Push(value);
            }
        }

        public void Push(T value)
        {
            if (this.Count == buffer.Length)
            {
                this.IncreaseBuffer();
            }

            this.buffer[this.Count] = value;
            this.Count++;

        }

        public T Pop()
        {
            return this.buffer[--this.Count];
        }

        public T Peek()
        {
            return this.buffer[this.Count - 1];
        }

        private void IncreaseBuffer()
        {
            T[] newBuffer = new T[this.buffer.Length * 2];
            this.buffer.CopyTo(newBuffer, 0);
            this.buffer = newBuffer;
        }

        public T[] ToArray()
        {
            T[] result = new T[this.Count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = buffer[i];
            }

            return result;
        }
    }

    public class DynamicStackNode<T>
    {
        public T Value { get; set; }
        public DynamicStackNode<T> Prev { get; set; }
        public DynamicStackNode<T> Next { get; set; }

        public DynamicStackNode(T value)
        {
            this.Value = value;
        }
    }

    public class DynamicStack<T>
    {
        public int Count { get; private set; }
        private DynamicStackNode<T> currentNode;

        public DynamicStack() { }

        public DynamicStack(T value)
        {
            this.currentNode = new DynamicStackNode<T>(value);
            this.Count++;
        }

        public DynamicStack(IEnumerable<T> collection)
        {
            if (collection == null || collection.Count() == 0)
            {
                throw new Exception("The provided collection is null or emtpy.");
            }

            this.currentNode = new DynamicStackNode<T>(collection.First());
            this.Count++;

            foreach (var value in collection.Skip(1))
            {
                DynamicStackNode<T> node = new DynamicStackNode<T>(value);
                node.Prev = currentNode;
                this.currentNode.Next = node;
                this.currentNode = node;
                this.Count++;
            }
        }

        public void Push(T value)
        {
            if (this.currentNode == null)
            {
                this.currentNode = new DynamicStackNode<T>(value);
                this.Count++;

                return;
            }

            DynamicStackNode<T> node = new DynamicStackNode<T>(value);
            node.Prev = this.currentNode;
            this.currentNode.Next = node;
            this.currentNode = node;
            this.Count++;
        }

        public T Pop()
        {
            if (this.currentNode == null)
            {
                throw new Exception("Stack is empty!");
            }

            T result = this.currentNode.Value;
            DynamicStackNode<T> prev = currentNode.Prev;
            prev.Next = null;
            currentNode.Prev = null;
            currentNode = prev;
            this.Count--;

            return result;
        }

        public T Peek()
        {
            if (this.currentNode == null)
            {
                throw new Exception("Stack is empty!");
            }

            return this.currentNode.Value;
        }

        public T[] ToArray()
        {
            if (this.currentNode == null)
            {
                throw new Exception("Stack is empty!");
            }

            T[] arr = new T[this.Count];
            DynamicStackNode<T> node = this.currentNode;
            int index = this.Count - 1;

            while (node != null)
            {
                arr[index] = node.Value;
                node = node.Prev;
                index--;
            }

            return arr;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            OrdinaryStack<int> stack = new OrdinaryStack<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            stack.Push(8);
            Console.WriteLine(stack.Peek());
        }
    }
}
