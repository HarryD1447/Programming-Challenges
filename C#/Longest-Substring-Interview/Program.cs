using System;

namespace Longest_Substring_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            string hi = " ";
            char[] letters = hi.ToCharArray();
            Console.WriteLine(letters.Length);
        }

        public static int LengthOfLongestSubstring(string s) 
        {
            char[] theCharacters = s.ToCharArray();

            int largestSubstring = 0;
            int substringStartIndex = 0;

            int[] storedCharacter = new int[200]; //I believe it can go to 128 as theres only 127 bits in ascii
            //Initial each value with -1 just for a placeholder
            for (int i = 0; i < storedCharacter.Length; i++)
            {
                storedCharacter[i] = -1;
            }

            for (int i = 0; i < theCharacters.Length; i++)
            {
                int integerValue = (int)theCharacters[i];
                if (storedCharacter[integerValue] != -1 && storedCharacter[integerValue] >= substringStartIndex)
                {
                    //Character already exists in the substring
                    int size = i - substringStartIndex;
                    largestSubstring = size > largestSubstring ? size : largestSubstring;
                    substringStartIndex = storedCharacter[integerValue] + 1;
                    storedCharacter[integerValue] = i;
                }
                else
                {
                    //Character doesn't exist in the substring therefore add it
                    storedCharacter[integerValue] = i;
                }
            }

            int finalSize = theCharacters.Length - substringStartIndex;
            largestSubstring = finalSize > largestSubstring ? finalSize : largestSubstring;

            return largestSubstring;

        }
    }
}
