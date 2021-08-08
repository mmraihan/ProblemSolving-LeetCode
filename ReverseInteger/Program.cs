using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = reverseInt (-123);
            Console.WriteLine(result);
        }

        public static int reverseInt(int x)
        {
            int result = 0;
            int prev = 0;
            int cur;

            while (x != 0)
            {
                cur = x % 10;
                x /= 10;

                result = result * 10 + cur;

                if ((result - cur) / 10 != prev) return 0;

                prev = result;
            }

            return result;
        }


    }
}
