using System;

namespace _4.LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var reult = LongestCommonPrefix(new string[] { "flower", "flow" });

            Console.WriteLine(reult);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length==0)
            {
                return String.Empty;
            }

            string prefix = strs[0];
            for (int i = 0; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }
    }
    }

