namespace _1431_Kids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputA = [2, 3, 5, 1, 3];
            var inputB = 3;

            var result = KidsWithCandies(inputA, inputB);
            foreach ( var i in result ) 
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }

        static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();

            for (int i = 0; i < candies.Length; i++)
            {
                bool test = false;
                for (int j = 0; j <candies.Length ; j++)
                {
                    if (candies[i] + extraCandies < candies[j])
                    {
                        test = true;
                        break;
                    }
                }
                if (test)
                {
                    result.Add(false);
                }
                else
                {
                    result.Add(true);
                }              
            }
            return result;
        }
        
    }
}
