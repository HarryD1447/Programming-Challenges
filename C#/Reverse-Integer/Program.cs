using System;
using System.Collections.Generic;

/*Leetcode challange
https://leetcode.com/problems/reverse-integer/ */

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the 32 bit integer that you want reversing!");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The reverse of {0} is {1}", number, ReverseInteger(number));
        }

        static int ReverseInteger(int num)
        {
            //Push & pop
            int reversed = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                if (reversed > 2147483650 / 10 || (reversed == 2147483650 / 10 && remainder > 7)) {reversed = 0; num = 0;}
                if (reversed < 2147483650 / 10 || (reversed == 2147483650 / 10 && remainder < -8)) {reversed = 0; num = 0;}
                reversed = reversed * 10 + remainder;
                num /= 10;
            }
            return reversed;
        }
    }
}
