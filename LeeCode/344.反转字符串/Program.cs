/*
 * 题库：https://leetcode-cn.com/problems/reverse-string/
编写一个函数，其作用是将输入的字符串反转过来。输入字符串以字符数组 char[] 的形式给出。

不要给另外的数组分配额外的空间，你必须原地修改输入数组、使用 O(1) 的额外空间解决这一问题。

你可以假设数组中的所有字符都是 ASCII 码表中的可打印字符。

 

示例 1：

输入：["h","e","l","l","o"]
输出：["o","l","l","e","h"]
示例 2：

输入：["H","a","n","n","a","h"]
输出：["h","a","n","n","a","H"]
 */

using System;

namespace _344.反转字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };

            ReverseString(s);

            Console.ReadKey();
        }

        static void ReverseString(char[] s)
        {
            //// 耗时：832ms
            //char t;
            //for (int i = 0; i < s.Length / 2; i++)
            //{
            //    t = s[s.Length - 1 - i];
            //    s[s.Length - 1 - i] = s[i];
            //    s[i] = t;
            //}


            // 耗时：576ms
            if (s.Length == 0) return;

            int left = 0, right = s.Length - 1;
            while (left <= right)
            {
                char temp = s[left];
                s[left++] = s[right];
                s[right--] = temp;
            }



            //string output = "[";
            //foreach (char item in result)
            //{
            //    output += $"\"{item}\",";
            //}
            //output += output.TrimEnd(',') + "]";
            //Console.Write(output);
        }
    }
}


//解题：https://www.jianshu.com/p/e982ea5bdaa0
