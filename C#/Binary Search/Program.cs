using System;
using System.Collections.Generic;

namespace Binary_Search
{
    class Program
    {

        enum Result
        {
            Lower,
            Higher, 
            Equal
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the binary search challange solution. (Number Wizard)");
            Console.WriteLine("Think of a whole number that you want to guess from 1 to 1000 and i'll guess it!");
            Console.WriteLine("Enter H,L or E to indicate if the guess was higher, lower or equal to the number");

            bool found = false;
            int guessCount = 0;

            int top = 1000;
            int bottom = 1;

            while (!found)
            {
                int guess = Lerp(bottom, top);
                Result response = GetUserResponse(guess);

                if (response == Result.Lower)
                {
                    top = guess;
                    guessCount++;
                }
                else if (response == Result.Higher)
                {
                    bottom = guess;
                    guessCount++;
                }
                else
                {
                    found = true;
                    Console.WriteLine("See I managed to guess the number within {0} attempts", guessCount);
                }
            }
        }

        static int Lerp(int bottom, int top)
        {
            int distance = top - bottom;
            int half = distance / 2;
            return bottom + half;
        }

        static Result GetUserResponse(int guessValue)
        {
            Result r = Result.Equal;
            bool ans = false;
            while (!ans)
            {
                Console.WriteLine("My guess is: {0}. Enter H,L or E", guessValue);
                string value = Console.ReadLine();
                switch(value)
                {
                    case "H":
                        r = Result.Higher;
                        ans = true;
                        break;
                    case "L":
                        r = Result.Lower;
                        ans = true;
                        break;
                    case "E":
                        r = Result.Equal;
                        ans = true;
                        break;
                }
            }
            return r;
        }
    }
}

