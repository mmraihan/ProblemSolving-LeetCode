using System;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=100; i++)
            {
                if (i % 2 ==1)
                {
                    continue;
                }             
               Console.Write(i + ",");

            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.Write(i + ",");

            }
        }
    }
}
