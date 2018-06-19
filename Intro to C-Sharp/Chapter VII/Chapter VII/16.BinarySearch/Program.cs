using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 51);
            }
            Array.Sort(array);

            Console.Write("Please enter an integer to search for: ");
            int searchFor = int.Parse(Console.ReadLine());
            int firstIndex = 0;
            int lastIndex = array.Length - 1;

            if (searchFor > array[lastIndex])
            {
                Console.WriteLine
                    ("The integer you are looking for is not contained in the array.");
            }
            else if (searchFor < array[firstIndex])
            {
                Console.WriteLine
                    ("The integer you are looking for is not cotained in the array.");

            }
            else
            {
                while (true)
                {
                    int guess = (lastIndex + firstIndex) / 2;

                    if (array[guess] == searchFor)
                    {
                        Console.WriteLine
                            ("The integer you are looking for is at index {0}.", guess);
                        break;
                    }
                    else if (Math.Abs(firstIndex - lastIndex) == 1)
                    {
                        if (searchFor == array[0])
                        {
                            Console.WriteLine
                                ("The integer you are looking for is at index 0.");
                            break;
                        }
                        else if (searchFor == array[array.Length - 1])
                        {
                            Console.WriteLine
                                ("The integer you are looking for is at index {0}."
                                , array.Length - 1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine
                                ("The integer you are looking for is not contained in the array.");
                            break;
                        }

                    }
                    else if (array[guess] < searchFor)
                    {
                        firstIndex = guess + 1;
                    }
                    else if (array[guess] > searchFor)
                    {
                        lastIndex = guess - 1;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }


            






        }
    }
}
