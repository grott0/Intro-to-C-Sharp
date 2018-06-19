using System;

public class MergeSortAlgo
{
    public static void Main()
    {
        int[] arr = { 1, 4, 7, 13, 2, 8, 5, 6, 0, 10, 3, 11, 14, 12, 15,12,4,3,6,14,35,36,143,64,34,63,234,643,47,34,12};
        int[] result = MergeSort(arr);
        Console.WriteLine(string.Join(" ", result));
    }

    private static int[] Sort(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];

        for (int i = 0, j = 0, k = 0; i < result.Length; i++)
        {
            if (j == arr1.Length)
            {
                result[i] = arr2[k];
                k++;
            }
            else if (k == arr2.Length)
            {
                result[i] = arr1[j];
                j++;
            }
            else
            {
                if (arr1[j] > arr2[k])
                {
                    result[i] = arr2[k];
                    k++;
                }
                else
                {
                    result[i] = arr1[j];
                    j++;
                }
            }

        }

        return result;
    }

    public static int[] MergeSort(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr;
        }

        int[] arr1, arr2;

        if (arr.Length % 2 != 0)
        {
            arr1 = new int[arr.Length / 2 + 1];
            arr2 = new int[arr.Length / 2];
        }
        else
        {
            arr1 = new int[arr.Length / 2];
            arr2 = new int[arr.Length / 2];
        }

        Populate(arr1, arr2, arr);
        arr1 = MergeSort(arr1);
        arr2 = MergeSort(arr2);

        return Sort(arr1, arr2);


    }

    private static void Populate(int[] arr1, int[] arr2, int[] arr)
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = arr[i];
        }

        for (int i = arr1.Length, j = 0; i < arr.Length; i++, j++)
        {
            arr2[j] = arr[i];
        }
    }
}

