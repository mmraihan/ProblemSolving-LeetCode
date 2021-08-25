using System;

namespace CelsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Reasult = ConvertCtoF(12);
            Console.WriteLine(Reasult);
        }

        public static double ConvertCtoF(double celsius)
        {
            double farenheit = (celsius * 9 / 5) + (32);

            return farenheit;
        }
     
    }
}
