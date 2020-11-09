using LeetCodeExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest
{
    [TestClass]
    public class Matrix01Test
    {
        //Input:
        //[[0,0,0],
        // [0,1,0],
        // [1,1,1]]
        
        //Output:
        //[[0,0,0],
        // [0,1,0],
        // [1,2,1]]

        [TestMethod]
        public void testMatrix()
        {
            Matrix01 matrixtest = new Matrix01();
            int[][] expected = new int[][]
            {
                new int[] {0,0,0},
                new int[] {0,1,0},
                new int[] {1,2,1}
            };
            int[][] result = matrixtest.UpdateMatrix(new int[][] {
                                                  new int[]{0,0,0 },
                                                  new int[]{0,1,0 },
                                                  new int[]{1,1,1 } });
          
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }
    }
}
