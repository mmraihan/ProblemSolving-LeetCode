using System;
using System.Collections.Generic;
using System.Text;

namespace _4._RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = intToRoman(3);
            Console.WriteLine(result);

        }

        public static string intToRoman(int num)
        {
            int[] intCode = { 100,900,500,400,90,50,40,10,9,5,4,1};
            string[] code = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
            string romanValue = string.Empty;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < intCode.Length; i++)
            {
                while (num>=intCode[i])
                {
                    sb.Append(code[i]);
                    num -= intCode[i];
                    romanValue += code[i];
                }


            }
            return sb.ToString();
        }

     
    }

   
}
