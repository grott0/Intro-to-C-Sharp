using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MergeSort
{
    class Program
    {
        static int[] array = new int[8];

        static void InitializeArray()
        {
            Console.WriteLine("Please enter eight integer numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static void SplitArray()
        {

        }
        static void Main(string[] args)
        {
            //InitializeArray();
            int[][] jaggedArray = new int[7][];
            jaggedArray[0] = new int[10];

            for (int i = 0; i < jaggedArray[0].Length; i++)
            {
                jaggedArray[0][i] = i * 2;
                Console.Write(jaggedArray[0][i] + " ");
            }



        }
    }
}
