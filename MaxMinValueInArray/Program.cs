namespace MaxMinValueInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[] numbers = { 1, 2, 3,44,55,66,79,66 };
          
            int minValue = numbers[0];
            int maxValue = numbers[0];

            foreach (var item in numbers)
            {
                if (item<minValue)
                {
                    minValue = item;
                }
                if (item>maxValue) 
                {
                    maxValue = item;
                }
            }
            Console.WriteLine($"Minimum Value: {minValue}");
            Console.WriteLine($"Maximun Value: {maxValue}");

        }

      
    }
}