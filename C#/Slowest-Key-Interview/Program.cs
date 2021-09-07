using System;
using System.Collections.Generic;

namespace Slowest_Key_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] releaseTimes = { 9, 29, 49, 50 };
            string characters = "cbcd";
            char answer = SlowestKey(releaseTimes, characters);
            Console.WriteLine(answer);
        }

        static char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            char[] differentCharacters = keysPressed.ToCharArray();
            int previousTime = 0;
            int largestTime = 0;

            List<char> largestCharacters = new List<char>();

            for (int i = 0; i < releaseTimes.Length; i++)
            {
                int pressTime = releaseTimes[i] - previousTime;
                previousTime = releaseTimes[i];

                if (pressTime > largestTime)
                {
                    largestTime = pressTime;
                    largestCharacters.Clear();
                    largestCharacters.Add(differentCharacters[i]);
                    Console.WriteLine(differentCharacters[i]);
                }
                else if (pressTime == largestTime)
                {
                    largestCharacters.Add(differentCharacters[i]);  
                    Console.WriteLine(differentCharacters[i]);

                }

            }
            char[] largeCharacters = largestCharacters.ToArray();

            for (int i = 0; i < largeCharacters.Length; i++)
            {
                Console.WriteLine(largeCharacters[i]);
            }

            Array.Sort(largeCharacters);
            return largeCharacters[largeCharacters.Length - 1];

        }
    }
}
