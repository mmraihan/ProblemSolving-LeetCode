using System;

namespace _3._MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a multplication table mumber");

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number}*{i} = {number*i}");
            }

            Console.ReadKey();
        }


    }
}
