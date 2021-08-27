using System;
using System.Collections;
using System.Collections.Generic;

namespace _5.__ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("{}))"));
        }


        public static bool IsValid(string s)
        {
            if (s.Length % 2 !=0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if (((c == ')' && stack.Count > 0 && stack.Peek() == '(')) ||
                        ((c == '}' && stack.Count > 0 && stack.Peek() == '{')) ||
                        ((c == ']' && stack.Count > 0 && stack.Peek() == '[')))
                    stack.Pop();

                else
                
                    stack.Push(c);
                
                        
            }

            return stack.Count == 0 ? true : false;
        }
    }
}
