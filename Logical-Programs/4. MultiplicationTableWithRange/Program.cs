using System;

namespace _4._MultiplicationTableWithRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide input number to calculate multiplicaton table with in range: ");

            int inputRange = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= inputRange; i++)
            {
                for (int j = 1; j <11; j++)
                {
                    Console.Write($"{i}*{j}={i*j}"+ "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
