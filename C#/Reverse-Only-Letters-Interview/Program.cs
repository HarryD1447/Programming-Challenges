using System;

namespace Reverse_Only_Letters_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseOnlyLetters("a-bC-dEf-ghIj"));
        }

        public static string ReverseOnlyLetters(string s)
        {
            char[] characters = s.ToCharArray();
            if (characters.Length <= 1) { return s; }

            int pointerA = 0;
            int pointerB = characters.Length - 1;

            while (pointerA != pointerB || pointerA < pointerB)
            {
                if (!isValidCharacter(characters[pointerA]))
                {
                    pointerA++;
                    Console.WriteLine("Invalid character A");

                }
                else if (!isValidCharacter(characters[pointerB]))
                {
                    pointerB--;
                    Console.WriteLine("Invalid character B");
                }
                else
                {
                    if (isValidCharacter(characters[pointerA]) && isValidCharacter(characters[pointerB]))
                    {
                        //Swap 
                        char temp = characters[pointerB];
                        characters[pointerB] = characters[pointerA];
                        characters[pointerA] = temp;

                        //Modify pointer
                        pointerA++;
                        pointerB--;

                        Console.WriteLine("Swap {0}  ,   {1}",characters[pointerA],characters[pointerB]);
                    }
                }

                //Check pointers
                if (pointerA - 1 == pointerB){break;}

            }

            return new string(characters);
        }

        public static bool isValidCharacter(char c)
        {
            int value = (int)c;
            if (c >= 97 && c <= 122)
            {
                return true;
            }
            else if (c >= 65 && c <= 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
