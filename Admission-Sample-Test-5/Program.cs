using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Admission_Sample_Test_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new[] { 1, 8, 3, 2 };
            var array2 = new[] { 4, 2, 6, 1 };
            var result = f(array1, array2);

            foreach (var item in result)
            {
                Console.Write(item +",");
            }

        }

        static int[] f(int[] first, int[] second)
        {
            if (first == null || second == null)
            {
                return null;
            }
            int commonCount = 0;

            for (int i = 0; i < first.GetLength(0); i++)
            {
                for (int j = 0; j < second.GetLength(0); j++)
                {
                    if (first[i]== second[j])
                    {
                        commonCount++;
                        break;
                    }
                }
            }

            int[] commonElements = new int[commonCount];
            int index = 0;

            // Fill the common elements

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        commonElements[index++] = first[i];
                        break;
                    }
                }
            }
            return commonElements;


        }


        #region Question

        /*  Write a function to return an array containing all elements common to two given arrays containing distinct positive integers.
          You should not use any inbuilt methods. You are allowed to use any number of arrays.
          The signature of the function is:
          int[] f(int[] first, int[] second)
          Examples

          if input parameters are return
          { 1, 8, 3, 2}, {4, 2, 6, 1}	{1, 2}
          {1, 8, 3, 2, 6}, {2, 6, 1}	{2, 6, 1}
          {1, 3, 7, 9}, {7, 1, 9, 3}	{1, 3, 7, 9}
          {1, 2}, {3, 4}	{}
          {}, {1, 2, 3}	{}
          {1, 2}, {}	{}
          {1, 2}, null	null
          null, {}	null
          null, null	null
                */
        #endregion
    }
}