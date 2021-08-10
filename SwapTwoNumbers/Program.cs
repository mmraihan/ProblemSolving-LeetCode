using System;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int temp;

            Console.WriteLine("Before swapping value of a={0}, b={1}", a,b);

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping value of a={0}, b={1}", a, b);

            //int temp;

            //temp = a;
            //a = b;



        }
    }
}
