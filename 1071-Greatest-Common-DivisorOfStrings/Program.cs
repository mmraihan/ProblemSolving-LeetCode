namespace _1071_Greatest_Common_DivisorOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "ABCABC";
            string str2 = "ABC";
            var result = GcdOfStrings(str1, str2);
            Console.WriteLine(result); // Output: "ABC"

            //// Test case 2
            //string str1 = "ABABAB";
            //string str2 = "ABAB";
            //Console.WriteLine(GcdOfStrings(str1, str2)); // Output: "AB"

            //// Test case 3
            //string str1 = "LEET";
            //string str2 = "CODE";
            //Console.WriteLine(GcdOfStrings(str1, str2)); // Output: ""
        }


        static string GcdOfStrings(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return GcdOfStrings(str2, str1);
            }
            if (str1.Length == str2.Length)
            {
                return str1 == str2 ? str1 : string.Empty;
            }
            if (str2.StartsWith(str1))
            {
                return GcdOfStrings(str1, str2.Substring(str1.Length));
            }

            return string.Empty;
        }
    }
}
