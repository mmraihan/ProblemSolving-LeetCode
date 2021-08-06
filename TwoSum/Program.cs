using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = TwoSum(new int[] { 3,2,4}, 6);
            Console.WriteLine($"[{output[0]}, {output[1]}]");
        }





        public static int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new Exception("Not Found");

        }
    }
}

