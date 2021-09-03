using System;

namespace Programming_Challenge_003
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static string GetString(string[] strings, int largestIndex)
        {
            int[] numberInts = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                numberInts[i] = int.Parse(strings[i]);
            }

            //Bubble sort
            for (int x = 0; x < numberInts.Length; x++)
            {
                for (int y = 0; y < numberInts.Length - 1; y++)
                {
                    if (numberInts[y] > numberInts[y + 1])
                    {
                        //Flip
                        int temp = numberInts[y];
                        numberInts[y] = numberInts[y + 1];
                        numberInts[y + 1] = temp;
                    }
                }
            }

            int value = numberInts[numberInts.Length - largestIndex];
            return value.ToString();

        }
        
    }
}
