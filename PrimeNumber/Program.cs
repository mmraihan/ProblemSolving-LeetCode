using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int number = 1; number <=100; number++)
            {
                int count = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number%i==0)
                    {
                        count++;
                    }
                }

                if (count==2)
                {
                    Console.WriteLine(number);
                }
            }
          
                                    
            
        }
    }
}
