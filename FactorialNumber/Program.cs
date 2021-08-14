using System;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            int fact = 1;

            for (int i = 1; i <=num; i++)
            {
                fact *= i;               
            }
            Console.WriteLine(fact);

        }
    }
}
