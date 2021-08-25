using System;

namespace _1._SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide input numbers:");
            int inputNumber = Int32.Parse( Console.ReadLine());

            int backupValue = inputNumber;
            int sum = 0, remainder = 0;

            while (inputNumber !=0)
            {
                remainder = inputNumber % 10;
                sum += remainder;
                remainder = inputNumber / 10;
                inputNumber /= 10;
            }
            Console.WriteLine($"Sum of {backupValue} is: {sum}");

        }
    }
}
