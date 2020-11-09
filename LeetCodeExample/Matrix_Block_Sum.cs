using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExample
{

    public class Matrix_Block_Sum
    {
        //Given a m* n matrix mat and an integer K, return a matrix answer where each 
        //    answer[i][j] is the sum of all elements mat[r][c] for i - K <= r <= i + K, j - K <= c <= j + K,
        //    and(r, c) is a valid position in the matrix.

        //        Example 1:
        
        //Input: mat = [[1,2,3],[4,5,6],[7,8,9]], K = 1
        //Output: [[12,21,16],[27,45,33],[24,39,28]]
        public int[][] MatrixBlockSum(int[][] mat, int K)
        {
            int[][] answer = new int[mat.Length][];
            for (int i = 0; i < mat.Length; i++)
            {
                answer[i] = new int[mat[i].Length];
            }
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    int r = i - K;
                    int c = j - K;
                    if (r < 0)
                    {
                        r = 0;
                    }
                    if (c < 0)
                    {
                        c = 0;
                    }
                    for (int q = r; q <= i + K && q < mat.Length; q++)
                    {
                        for (int w = c; w <= j + K && w < mat[q].Length; w++)
                        {
                            answer[i][j] += mat[q][w];
                        }
                    }
                }
            }
            return answer;
        }
    }
}
