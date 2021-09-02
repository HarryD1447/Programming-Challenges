using System;
using System.Collections.Generic;

//Challange Link
//https://leetcode.com/explore/challenge/card/august-leetcoding-challenge-2021/617/week-5-august-29th-august-31st/3957/


namespace Range_Addition_2_Interview
{
    class Program
    {
        public static int[,] testData = new int[,]{{2,2},{3,3}};

        static void Main(string[] args)
        {
            int output = MaxCount(3,3, testData);
            Console.WriteLine(output);
        }

        public static int MaxCount(int m, int n, int[,] ops)
        {
            int currentSize = m * n;
            int operationsCount = ops.GetLength(0);
            
            for (int i = 0; i < operationsCount; i++)
            {
                //Console.WriteLine(i);
                int x = ops[i,0];
                Console.WriteLine(x);
                int y = ops[i,1];
                Console.WriteLine(y);
                int area = x * y;
                if (area < currentSize)
                {
                    currentSize = area;
                }
            }

            return currentSize;
        }
    }
}
