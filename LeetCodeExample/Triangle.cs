using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExample
{
    public class Triangle
    {
        //Given a triangle, find the minimum path sum from top to bottom.
        //    Each step you may move to adjacent numbers on the row below.

        //For example, given the following triangle
        //  [
        //   [2],
        //  [3,4],
        // [6,5,7],
        //[4,1,8,3]
        //  ]

        //The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 11).

        //Note:

        //Bonus point if you are able to do this using only O(n) extra space, where n is the total 
        //number of rows in the triangle.

        public int MinimumTotal(IList<IList<int>> triangle)
        {
            for (int i = triangle.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
                }
            }
            return triangle[0][0];

        }

        private int MinTotal(IList<IList<int>> triangle, int[][] cache, int i, int j)
        {
            if (i == triangle.Count - 1)
            {
                return triangle[i][j];
            }
            if (cache[i][j] != 0)
            {
                return cache[i][j];
            }
            cache[i][j] = Math.Min(MinTotal(triangle, cache, i + 1, j),
                                   MinTotal(triangle, cache, i + 1, j + 1))
                                    + triangle[i][j];
            return cache[i][j];
        }
    }
}
