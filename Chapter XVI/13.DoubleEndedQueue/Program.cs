namespace _13.DoubleEndedQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayDeque<T>
    {
        private const int InitialSize = 10;
        private T[] buffer = new T[InitialSize];
        public int Count { get; private set; }
        private int tail = InitialSize / 2;
        private int head = (InitialSize / 2) - 1;

        public ArrayDeque() { }

        public void EnqueueFront(T value)
        {
            if (this.head == 0)
            {
                this.ResizeBuffer();
            }

            this.buffer[this.head] = value;
            this.head--;
            this.Count++;
        }

        public void EnqueueBack(T value)
        {
            if (this.tail == buffer.Length - 1)
            {
                this.ResizeBuffer();
            }

            this.buffer[this.tail] = value;
            this.tail++;
            this.Count++;
        }

        private void ResizeBuffer()
        {
            T[] newBuffer = new T[this.buffer.Length * 2];
            int startIndex = this.buffer.Length / 2;
            this.buffer.CopyTo(newBuffer, startIndex);
            this.head += this.buffer.Length / 2;
            this.tail += this.buffer.Length / 2;
            this.buffer = newBuffer;
        }

        public T PeekFront()
        {
            if (this.Count == 0 || this.head == this.tail - 1)
            {
                throw new Exception("The deque is empty!");
            }

            return this.buffer[this.head + 1];
        }

        public T PeekBack()
        {
            if (this.Count == 0 || this.head == this.tail - 1)
            {
                throw new Exception("The deque is empty!");
            }

            return this.buffer[this.tail - 1];
        }

        public T DequeueFront()
        {
            if (this.Count == 0 || this.head == this.tail - 1)
            {
                throw new Exception("The deque is empty!");
            }

            T result = this.buffer[this.head + 1];
            this.buffer[this.head + 1] = default(T);
            this.head++;
            this.Count--;

            return result;
        }

        public T DequeueBack()
        {
            if (this.Count == 0 || this.head == this.tail - 1)
            {
                throw new Exception("The deque is empty!");
            }

            T result = this.buffer[this.tail - 1];
            this.buffer[this.tail - 1] = default(T);
            this.tail--;
            this.Count--;

            return result;
        }

        public void DeleteFront()
        {
            if (this.Count == 0 || this.head == this.tail - 1)
            {
                throw new Exception("The deque is empty!");
            }

            this.buffer[this.head + 1] = default(T);
            this.head++;
            this.Count--;

        }

        public void DeleteBack()
        {
            if (this.Count == 0 || this.head == this.tail - 1)
            {
                throw new Exception("The deque is empty!");
            }

            this.buffer[this.tail - 1] = default(T);
            this.tail--;
            this.Count--;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}
