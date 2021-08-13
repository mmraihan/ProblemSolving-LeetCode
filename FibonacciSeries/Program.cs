using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
          
            for (int i = 0; i < 10; i++)
            {             
                c = a + b;              
                Console.WriteLine(c);
                a = b;
                b = c;
            }
          
            Console.ReadLine();
        }
    }
}
