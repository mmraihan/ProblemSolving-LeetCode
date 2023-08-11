using System.ComponentModel;

namespace Admission_Sample_Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1 };
            int[] array2 = { 1, 2 };
            int[] array3 = { 1, 2, 3 };
            int[] array4 = { 1, 2, 3, 4 };

            Console.WriteLine(GetNumbers(array1)); // Output: 1
            Console.WriteLine(GetNumbers(array2)); // Output: -1
            Console.WriteLine(GetNumbers(array3)); // Output: 2
            Console.WriteLine(GetNumbers(array4)); // Output: -2
        }


        static int GetNumbers(int[] number)
        {
            var sumEven = 0;
            var subOdd = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    sumEven += number[i];    
                }
                else
                {
                    subOdd += number[i];
                }
             
            }

            return  subOdd- sumEven;
        }

    }
}

#region Question

/*Write a function that takes an array of integers as an argument and returns a value based on the sums of the even 
  and odd numbers in the array. Let X = the sum of the odd numbers in the array and let Y = the sum of the even numbers. 
 The function should return X – Y
The signature of the function is:
int f(int[] a)

Examples

if input array is	return
{1}	1
{ 1, 2}
-1
{ 1, 2, 3}
2
{ 1, 2, 3, 4}
-2
*/
#endregion