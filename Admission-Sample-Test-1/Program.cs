using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Admission_Sample_Test_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 2, 1, 4, 5 };
            int[] array3 = { 3, 2, 1, 4, 1 };
            int[] array4 = { 1, 2, 3, 4 };
            int[] array5 = { };
            int[] array6 = { 10 };

            Console.WriteLine(IsCenteredArray(array1));
            Console.WriteLine(IsCenteredArray(array2)); 
            Console.WriteLine(IsCenteredArray(array3)); 
            Console.WriteLine(IsCenteredArray(array4)); 
            Console.WriteLine(IsCenteredArray(array5)); 
            Console.WriteLine(IsCenteredArray(array6)); 
        }

        static int IsCenteredArray(int[] arr)
        {
            if (arr.Length == 0 || arr.Length % 2 == 0)
            {
                return 0; // No middle element or even number of elements
            }

            int middleIndex = arr.Length / 2;
            int middleValue = arr[middleIndex];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != middleIndex && arr[i] <= middleValue)
                {
                    return 0; // Middle element is not strictly greater than all others
                }
            }

            return 1;
        }
    }


    #region Smaple Question
            /* An array with an odd number of elements is said to be centered if all elements(except the middle one) are
            strictly greater than the value of the middle element.Note that only arrays with an odd number of elements have a middle element.
            Write a function that accepts an integer array and returns 1 if it is a centered array, otherwise it returns 0.


            Examples:

                    if the input array is	return
                    { 1, 2, 3, 4, 5}	0 (the middle element 3 is not strictly less than all other elements)
                    {3, 2, 1, 4, 5}
            1(the middle element 1 is strictly less than all other elements)
                    { 3, 2, 1, 4, 1}
            0(the middle element 1 is not strictly less than all other elements)
                    { 1, 2, 3, 4}
            0(no middle element)
                    { }
            0(no middle element)
                    { 10}
                    //1(the middle element 10 is strictly less than all other elements)
            */
    #endregion
}