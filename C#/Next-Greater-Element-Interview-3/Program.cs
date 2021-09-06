using System;
using System.Collections.Generic;

namespace Next_Greater_Element_Interview_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first value is: {0}", NextGreaterElement(1546464654));
        }

        public static int NextGreaterElement(int value)
        {
            int digitsLength = value.ToString().Length;
            if (digitsLength > 10) { return -1; }

            int[] digitsArray = new int[digitsLength];
            int tempValue = value;
            int indexCount = 0;
            while (tempValue > 0)
            {
                digitsArray[digitsLength - indexCount - 1] = tempValue % 10;
                tempValue /= 10;
                indexCount++;
            }

            /*Start from the back of the array and go through 
            until the value is smaller than the previous value
            */

            bool possible = false;
            int currentValue = digitsArray[digitsLength - 1];
            int swapValueA = -1;
            int swapIndexA = -1;
            for (int i = digitsLength - 1; i >= 0; i--)
            {
                if (digitsArray[i] >= currentValue) //Work out if it should be > or >=
                {
                    //Greater than & equal too.
                    currentValue = digitsArray[i];
                }
                else
                {
                    swapValueA = digitsArray[i];
                    swapIndexA = i;
                    possible = true;
                    break;
                }
            }
            //Checking if the calculation is possible
            if (!possible)
            {
                return -1;
            }
            int swapIndexB = GetOtherSwapIndex(swapIndexA, digitsArray);

            //Swap the values
            int t = digitsArray[swapIndexA];
            digitsArray[swapIndexA] = digitsArray[swapIndexB];
            digitsArray[swapIndexB] = t;

            //Reverse the last digits after the first flipping index
            ReverseBackendOfArray(swapIndexA + 1, ref digitsArray);



            //for (int i = 0; i < digitsLength; i++)
            //{
                //Console.WriteLine(digitsArray[i]);
            //}

            //Check the value of the result to check it's within the 32 bit integer range
            char[] charValues = new char[digitsLength];
            for (int i = 0; i < digitsLength; i++)
            {
                charValues[i] = digitsArray[i].ToString().ToCharArray()[0];
            }

            try
            {
                 string str = new String(charValues);
                 int v = int.Parse(str);
                 return v;
            }
            catch (System.Exception)
            {
                
                return -1;
            }

            
        }

        static int GetOtherSwapIndex(int firstIndex, int[] values)
        {
            int firstValue = values[firstIndex];
            int currentDifference = 100;
            int currentIndex = 0;
            for (int i = firstIndex; i < values.Length; i++)
            {
                int diff = values[i] - firstValue;
                if (diff > 0 && diff < currentDifference)
                {
                    currentDifference = diff;
                    currentIndex = i;
                }
            }
            return currentIndex;
        }

        static void ReverseBackendOfArray(int startIndex, ref int[] array)
        {
            //if (startIndex < array.Length)
            //{
                //int amountOfSwaps = (array.Length - startIndex) / 2;
                //for (int i = 0; i < amountOfSwaps; i++)
                //{
                   // int temp = array[startIndex + i];
                   // array[startIndex + i] = array[array.Length - 1 - i];
                   // array[array.Length - 1 - i] = temp;
                //}
            //}

            Array.Sort(array,startIndex,array.Length - startIndex);
        }


    }
}
