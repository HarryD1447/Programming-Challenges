using System;

namespace Remove_Duplicates_Sorted_Array
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[5] { 1, 1, 1, 1, 1 };
            int k = RemoveDuplicates(ref nums);
            Console.WriteLine("The new length is: {0}", k);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        /* Modify the current nums array to remove duplicates
        and return the ideal size of the new array */
        public static int RemoveDuplicates(ref int[] nums)
        {
            if (nums.Length > 0)
            {
                int nextIndex = 0;
                int previousValue = 0;
                if (previousValue == nums[0])
                { previousValue = 1; }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != previousValue)
                    {
                        //Not equal to previous value so it should be kept
                        previousValue = nums[i];
                        nums[nextIndex] = nums[i];
                        nextIndex++;
                    }
                }
                //Return the size of the new array 
                return nextIndex;
            }
            else
            {
                return 0;
            }

        }
    }
}
