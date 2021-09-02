using System;

namespace Array_Interview_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testValues = new int[8]{1,4,8,11,18,22,6,7};
            int target = 12;

            int[] returnValues = GetArrayPairToTarget(testValues, target);
            Console.WriteLine("Value pair is: {0} , {1}", returnValues[0], returnValues[1]);
        }

        static int[] GetArrayPairToTarget(int[] baseArray, int target)
        {
            //Create a large int array
            int[] storedValuesInIndex = new int[5000];

            for (int i = 0; i < baseArray.Length; i++)
            {
                //Calculate the remaining 
                int remaining = target - baseArray[i];
                if (storedValuesInIndex[remaining] != 0)
                {
                    return new int[2]{remaining, baseArray[i]};
                }

                /*Store the baseArray value in the
                storedValuesIndex at the index of baseArray 
                e.g. baseArray value = 4 so i set the storedValueInIndex at index 4 = to 
                a value to indicate that the value exists */
                storedValuesInIndex[baseArray[i]] = 1;
            }

            return new int[2]{-1,-1};
        }
    }

    
}
