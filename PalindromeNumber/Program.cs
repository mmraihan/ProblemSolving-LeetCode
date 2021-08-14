using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 121;
            int result = 0;
            int remainder;
            int temp = number;

            while (number !=0)
            {
                remainder = number % 10;
                result = remainder + result*10;
                number = number / 10;
             
            }
            number = temp;
            if (result == number)
            {
                Console.WriteLine("It's a Palindrome Number  ");
            }
            else
            {
                Console.WriteLine("It's not a Palindrome Number");
            }



        }
    }
}
