using System;

namespace _3.PalindromeNumber_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = IsPalindrome(-121);
            Console.WriteLine(result);

        }
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || x != 0 && x % 10 == 0)
            {
                return false;
            }
            int number = x;
            int result = 0;
            int remainder;
            int temp = number;

            while (number != 0)
            {
                remainder = number % 10;
                result = remainder + result * 10;
                number = number / 10;

            }
            number = temp;
            if (result == number)
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
