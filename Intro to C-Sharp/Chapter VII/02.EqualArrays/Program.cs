using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the first array: ");
            int nElementsFirstArray = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of elements in the second array: ");
            int nElementsSecondArray = int.Parse(Console.ReadLine());
            int[] firstArray = new int[nElementsFirstArray];
            int[] secondArray = new int[nElementsSecondArray];
            bool equal = true;

            if (nElementsSecondArray != nElementsFirstArray)
            {
                Console.WriteLine("Arrays are not equal");
            }
            else
            {
                Console.WriteLine("Enter the elements for the first array: ");
                for (int i = 0; i < nElementsFirstArray; i++)
                {
                    firstArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the elements for the second array: ");
                for (int i = 0; i < nElementsSecondArray; i++)
                {
                    secondArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < nElementsFirstArray; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        equal = false;
                    }
                }
                Console.WriteLine
                    ("{0}", equal == true ? "Arrays are equal." : "Arrays are not equal.");
            }

        }
    }
}
