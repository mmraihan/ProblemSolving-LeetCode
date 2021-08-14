using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 153;
            int remainder;
            int cube;
            int result = 0;
            int temp = number;

            while (number!= 0)
            {
                remainder = number % 10;
                cube = remainder * remainder * remainder;
                result = result + cube;
                number = number / 10;              

            }

            number = temp;
            if (result == number)
            {
                Console.WriteLine($"{number} is an Armstrong Number");
            }
            else
            {
                Console.WriteLine( $"{number} is not an Armstrong Number");
            }
            
        }
    }
}
