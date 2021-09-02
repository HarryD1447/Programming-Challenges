using System;

namespace Readable_Scalable_Code
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] ints = new int[5]{1,2,3,4,5};

            for (int x = 0; x < ints.Length; x++)
            {
                for (int y = 0; y < ints.Length; y++)
                {
                    Console.WriteLine("{0} , {1}", ints[x],ints[y]);
                }
            }
        }
    }
}
