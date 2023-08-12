
namespace Admission_Sample_Test_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = f(1238021);
            Console.WriteLine(result);
        }
        public static int f(int n)
        {
            int reversed = 0;

            while (n != 0)
            {
                int digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }

            return reversed;
        }


        #region Question

        //Write a function to reverse an integer using numeric operators and without using any arrays or other data structures.
        //The signature of the function is:
        //int f(int n)

        #endregion
    }
}