using LeetCodeExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestTriangle()
        {
            Triangle triangle = new Triangle();
            Assert.IsTrue(triangle.MinimumTotal(new List<IList<int>>{
                                                    new List<int>{2 },
                                                    new List<int>{3,4 },
                                                    new List<int>{ 6,5,7},
                                                    new List<int>{4,1,8, 3 }}) == 11);
        }
    }
}
