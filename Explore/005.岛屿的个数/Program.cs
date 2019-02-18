using System;
using System.Collections.Generic;

//https://leetcode-cn.com/explore/learn/card/queue-stack/217/queue-and-bfs/872/

namespace _005.岛屿的个数
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] lands = new char[,]
            {
                  { '1', '1', '1', '1', '0' },
                  { '1', '1', '1', '1', '0' },
                  { '1', '1', '0', '0', '0'},
                  { '0', '0', '0', '0','1' }
            };

            //lands = new char[,]{
            //    { '1','0','1'}
            //};

            Solution s = new Solution();
            Console.WriteLine(s.NumIslands(lands));

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int NumIslands(char[,] grid)
        {
            if (grid.Length == 0) return 0;
            int rowNum = grid.GetLength(0);
            int colNum = grid.GetLength(1);

            int count = 0;
            for (int i = 0; i < rowNum ; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    if (grid[i, j] == '1')
                    {
                        count++;
                        MarkFlag(grid, i, j);
                    }
                }

            }

            return count;
        }

        public void MarkFlag(char[,] grid, int row, int col)
        {
            int rowNum = grid.GetLength(0);
            int colNum = grid.GetLength(1);
            if (row < 0 || row >= rowNum || col < 0 || col >= colNum || grid[row, col] != '1')
                return;
            grid[row, col] = '2';
            MarkFlag(grid, row + 1, col);
            MarkFlag(grid, row - 1, col);
            MarkFlag(grid, row, col + 1);
            MarkFlag(grid, row, col - 1);
        }
    }

}
