//题目：https://leetcode-cn.com/problems/valid-parentheses/

using System;
using System.Collections;

namespace _020.有效的括号
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("([)]"));

            Console.ReadKey();
        }

        static bool IsValid(string s)
        {
            // 耗时：116ms，才击败了76.26%的用户

            if (string.IsNullOrEmpty(s)) return true;
            Stack stack = new Stack();
            Hashtable hashtable = new Hashtable();
            hashtable.Add(')', '(');
            hashtable.Add('}', '{');
            hashtable.Add(']', '[');

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (!hashtable.ContainsKey(current) &&
                    !hashtable.ContainsValue(current))
                    continue;

                if (stack.Count != 0 &&
                    hashtable.ContainsKey(current) &&
                    (char)stack.Peek() == (char)hashtable[current])
                    stack.Pop();
                else
                    stack.Push(current);
            }
            if (stack.Count == 0) return true;
            else return false;
        }
    }
}

