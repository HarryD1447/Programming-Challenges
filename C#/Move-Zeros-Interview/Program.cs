using System;

namespace Move_Zeros_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {0};
            MoveZeros(ref nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static void MoveZeros(ref int[] nums)
        {
            int nextIndexPosition = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nextIndexPosition] = nums[i];
                    nextIndexPosition++; 
                }
            }

            //Backfill with zero's
            for (int i = nextIndexPosition; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
