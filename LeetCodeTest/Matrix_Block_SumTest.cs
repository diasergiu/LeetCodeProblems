using LeetCodeExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest
{
    [TestClass]
    public class Matrix_Block_SumTest
    {
        [TestMethod]
        public void Matrix_Bolck_Test()
        {
            Matrix_Block_Sum MBS = new Matrix_Block_Sum();
            int[][] expected = new int[][]
            {
               new int[]{12, 21, 16 },
               new int[]{27, 45, 33 },
               new int[]{24, 39, 28 }
            };
            int[][] result = MBS.MatrixBlockSum(new int[][] {new int[] { 1, 2, 3 },
                                                          new int[] { 4, 5, 6 },
                                                          new int[] { 7, 8, 9}}, 1);
            for (int i = 0; i < result.Length; i++)
            {
                for(int j = 0; j < result[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }
    }
}
