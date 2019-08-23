using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
//给定一组非负整数，重新排列它们的顺序使之组成一个最大的整数。

//示例 1:

//输入: [10,2]
//输出: 210
//示例 2:

//输入: [3,30,34,5,9]
//输出: 9534330
//说明: 输出结果可能非常大，所以你需要返回一个字符串而不是整数。

//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/largest-number
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
namespace _179.最大数
{
    public class UnitTest1
    {
        private ITestOutputHelper _output;
        public UnitTest1(ITestOutputHelper outputHelper)
        {
            _output = outputHelper;
        }
        [Theory]
        //[InlineData(new int[] { 10, 2 }, "210")]
        [InlineData(new int[] { 3, 30, 34, 5, 9 }, "9534330")]
        public void CompareString(int[] input, string expected)
        {

            ;
        }


        [Theory]
        [InlineData(new int[] { 0, 0 }, "0")]
        [InlineData(new int[] { 10, 2 }, "210")]
        [InlineData(new int[] { 3, 30, 34, 5, 9 }, "9534330")]
        [InlineData(new int[] { 999999998, 999999997, 999999999 }, "999999999999999998999999997")]
        [InlineData(new int[] { 74, 21, 33, 51, 77, 51, 90, 60, 5, 56 }, "9077746056551513321")]
        public void LargestNumber(int[] input, string expected)
        {
            Solution solution = new Solution();
            var largestNumber = solution.LargestNumber(input);
            Assert.Equal(expected, largestNumber);
        }
    }

    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            // int[] 转 string[]
            string[] r = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                r[i] = nums[i].ToString();
            }

            // 排序
            Array.Sort<string>(r, (a, b) => (b+a).CompareTo(a + b));

            // 汇总结果
            string result = string.Join("", r);

            // 过滤0开头的问题
            if (result[0] == '0')
            {
                return "0";
            }
            return result;
        }
    }
}
