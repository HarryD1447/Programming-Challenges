using System;

namespace Remove_Element_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,2,2,2,2,2};
            int k = RemoveElement(ref nums, 2);
            Console.WriteLine("The new size of the array is {0}", k);
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static int RemoveElement(ref int[] nums, int val)
        {
            int nextIndexPosition = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[nextIndexPosition] = nums[i];
                    nextIndexPosition++;
                }
            }

            return nextIndexPosition;
        }
    }
}
