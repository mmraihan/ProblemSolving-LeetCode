using System;

namespace ReverseNumbers
{
    class Program
    {
    static void Main(string[] args)
        {
            var result = FindReverseNumber(1234);
            Console.WriteLine("Reverse Number: " +result);
        }

        public static int FindReverseNumber(int num)
        {
           
            int result = 0;
            int reminder;

            while (num != 0)
            {
                reminder = num % 10;
                result = result * 10 + reminder;
                num = num / 10;
            }
            return result;
            
        }
    }
}
