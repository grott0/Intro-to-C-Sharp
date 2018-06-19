namespace _15.SortLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                list.AddFirst(rnd.Next(0, 50));
            }

            Print(list);
            Sort(list);
            Console.WriteLine();
            Print(list);

        }

        static void Print(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        static void Sort(LinkedList<int> list)
        {
            int iterator = 0;
            int minValue = int.MaxValue;

            while (iterator < list.Count)
            {
                foreach (var item in list.Take(list.Count - iterator))
                {
                    if (item < minValue)
                    {
                        minValue = item;
                    }
                }

                list.Remove(minValue);
                list.AddLast(minValue);
                minValue = int.MaxValue;
                iterator++;
            }
        }
    }
}
