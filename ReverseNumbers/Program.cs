using System;

namespace ReverseNumbers
{
    class Program
    {
    static void Main(string[] args)
        {
            var result = FindReverseNumber(12345678903);
            Console.WriteLine("Reverse Number: " +result);
        }

        public static int FindReverseNumber(long num)
        {
           
            long result = 0;
            long reminder;

            while (num != 0)
            {
                reminder = num % 10;
                result = result * 10 + reminder;
                num = num / 10;
            }

            try
            {
                string a = result.ToString();
                return int.Parse(a);
            }
            catch (Exception)
            {
                return 0;              
            }
        }
    }
}
