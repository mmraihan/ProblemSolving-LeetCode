using System;

namespace _2._CelsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Eneter the Celsius Value");

            double celToFare = double.Parse( Console.ReadLine());

            CelsiusToFarenheit celsius = new CelsiusToFarenheit();

            var result= celsius.ConvertCelToFaren(celToFare);
            Console.WriteLine($"{celToFare} Degree Farenheit = {result} Degree Celsius");

            Console.ReadKey();

        }
    }
}
