using System.Net.Http.Headers;
using System.Text;

namespace _1768_Merge_Strings_Alternately
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            var result= MergeAlternately("abc", "pqr");
            Console.WriteLine(result);
        }

        public  static string MergeAlternately(string word1, string word2)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int n1 = word1.Length;
            int n2 = word2.Length;
            int i = 0;
            while (i < n1 || i < n2)
            {
                if (i < n1)
                {
                    stringBuilder.Append(word1[i]);
                   
                }
                if (i < n2)
                {
                    stringBuilder.Append(word2[i]);
                }
                i++;
            }

            return stringBuilder.ToString();
        }

    }
}
