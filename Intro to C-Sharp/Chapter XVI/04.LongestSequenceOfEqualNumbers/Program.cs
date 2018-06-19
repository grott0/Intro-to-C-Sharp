using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> longestEqualSequence = GetLongestEqualSequence();

            Console.WriteLine("Greatest equal sequence: {0}", string.Join(", ", longestEqualSequence));
        }

        static List<int> GetLongestEqualSequence()
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToList();

            if (nums == null || nums.Count == 0)
            {
                throw new Exception("The list is empty!");
            }

            int greatestSequenceLastIndex = -1;
            int currentSequenceLength = 1;
            int greatestSequenceLength = 1;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    currentSequenceLength++;

                    if (currentSequenceLength >= greatestSequenceLength)
                    {
                        greatestSequenceLength = currentSequenceLength;
                        greatestSequenceLastIndex = i + 1;
                    }
                }
                else
                {
                    currentSequenceLength = 1;
                }
            }

            return ExtractLongestEqualSequence(nums, greatestSequenceLastIndex, greatestSequenceLength);
        }

        static List<int> ExtractLongestEqualSequence(List<int> nums, int lastIndex, int sequenceLength)
        {
            if (lastIndex == -1)
            {
                return new List<int>(new int[] { nums[0] });
            }

            List<int> result = new List<int>();

            for (int index = lastIndex, iterator = 0; iterator < sequenceLength; index--, iterator++)
            {
                result.Add(nums[index]);
            }

            return result;
        }
    }
}
