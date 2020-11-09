using LeetCodeExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeTest
{
    [TestClass]
    public class Sum3Test
    {
        [TestMethod]
        public void TestMethod()
        {
            Sum3 sum3 = new Sum3();
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int> { -1, -1, 2 });
            expected.Add(new List<int> { -1, 0, 1 });
            IList<IList<int>> result= sum3.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            var result_expected = expected.Zip(result, (e, r) => new { listExpected = e, listResult = r });

            for(int i = 0; i < expected.Count; i++)
            {
                for(int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }

    }
}
