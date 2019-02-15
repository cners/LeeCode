
//题目：https://leetcode-cn.com/problems/reverse-words-in-a-string-iii/


//给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。

//示例 1:

//输入: "Let's take LeetCode contest"
//输出: "s'teL ekat edoCteeL tsetnoc" 
//注意：在字符串中，每个单词由单个空格分隔，并且字符串中不会有任何额外的空格。


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _557.反转字符串中的单词_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string oriStr = "Let's take LeetCode contest";
            Console.WriteLine(oriStr);
            Console.WriteLine(solution.ReverseWords(oriStr));
            Console.ReadKey();
        }

    }

    /// <summary>
    /// 执行用时: 248 ms, 在Reverse Words in a String III的C#提交中击败了18.27% 的用户
    /// 执行用时: 220 ms, 在Reverse Words in a String III的C#提交中击败了38.46% 的用户
    /// 思路：堆栈解法
    /// 1、建立一个栈数组
    /// 2、分离各个单词
    /// 3、让每个单词中，每个字符存入一个栈中（Push），然后把该栈放入数组中
    /// 4、遍历栈数组，输出最终结果（Pop)
    /// </summary>
    //public class Solution
    //{
    //    private List<Stack> stacks = new List<Stack>();
    //    private StringBuilder result = new StringBuilder();
    //    public string ReverseWords(string s)
    //    {
    //        if (string.IsNullOrEmpty(s)) return "";
    //        else if (s.Length == 1) return s;

    //        string[] words = s.Split(' ');
    //        foreach (var item in words)
    //        {
    //            Stack stack = new Stack();
    //            for (int i = 0; i < item.Length; i++)
    //                stack.Push(item[i]);
    //            if (stack.Count > 0)
    //                stacks.Add(stack);
    //        }


    //        foreach (var stack in stacks)
    //        {
    //            while (stack.Count != 0)
    //            {
    //                result.Append(stack.Pop());
    //            }
    //            result.Append(" ");
    //        }
    //        return result.ToString().Trim();
    //    }
    //}



    ///
    ///执行用时: 176 ms, 在Reverse Words in a String III的C#提交中击败了67.31% 的用户
    ///思路：Linq解法
    ///
    public class Solution
    {
        public string ReverseWords(string s)
        {
            string[] strs = s.Split(' ');
            return string.Join(" ", strs.ToList().Select(str => str = new string(str.Reverse().ToArray())));
        }
    }
}
