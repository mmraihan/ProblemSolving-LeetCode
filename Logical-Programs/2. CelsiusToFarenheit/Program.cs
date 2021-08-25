using System;

namespace _2._CelsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            CelsiusToFarenheit celsius = new CelsiusToFarenheit();
            Console.WriteLine("Eneter the Celsius Value");

            double celToFare = double.Parse( Console.ReadLine());

            var result= celsius.ConvertCelToFaren(celToFare);
            Console.WriteLine($"{celToFare} Degree Farenheit = {result} Degree Celsius");
            Console.ReadKey();

        }
    }
}
