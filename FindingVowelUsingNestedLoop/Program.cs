using System;

namespace FindingVowelUsingNestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CalculateVowels("HELLO! Raihn");
            Console.WriteLine(result);
        }


        public static int CalculateVowels(string text)
        {
            var lowerText = text.ToLower();
            char[] arrayText = lowerText.ToCharArray();
            char[] arrayVowel = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int count = 0;

            for (int i = 0; i < arrayText.Length; i++)
            {
                for (int j = 0; j < arrayVowel.Length; j++)
                {
                    if (arrayText[i] == arrayVowel [j])
                    {
                        count++;
                    }
                }
            }
            return count;
            
        }
    }
}
