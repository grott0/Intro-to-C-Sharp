namespace _14.StaticQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StaticQueue<T>
    {
        private const int InitialSize = 10;
        private T[] buffer = new T[InitialSize];
        public int head = 0;
        public int tail = 0;
        public int Count { get; private set; }

        public StaticQueue() { }

        public void Enqueue(T value)
        {
            if (this.tail == this.buffer.Length - 1)
            {
                this.ResizeBuffer();
            }

            this.buffer[this.tail] = value;
            this.Count++;
            this.tail++;
        }

        private void ResizeBuffer()
        {
            T[] newBuffer = new T[this.buffer.Length * 2];
            this.buffer.CopyTo(newBuffer, 0);
            this.buffer = newBuffer;
            this.head = 0;
            this.tail = this.Count;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new Exception("The queue is empty!");
            }

            T res = this.buffer[this.head];
            this.Count--;
            this.head++;

            if (this.head == this.tail)
            {
                this.head = 0;
                this.tail = 0;
            }

            return res;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new Exception("The queue is empty!");
            }

            return this.buffer[this.head];
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
