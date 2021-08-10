using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;

            if (a>b && a>c)
            {
                Console.WriteLine( "a is greater");
            }
            else if(b>c && b>a)
            {
                Console.WriteLine("b is greater");
            }
            else
            {               
                Console.WriteLine("c is greater");
            }
        }
    }
}
