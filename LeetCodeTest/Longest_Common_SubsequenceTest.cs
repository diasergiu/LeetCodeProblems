using LeetCodeExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTest
{
    [TestClass]
    public class Longest_Common_SubsequenceTest
    {

        [TestMethod]
        public void TestLCS()
        {
            Longest_Common_Subsequence LCS = new Longest_Common_Subsequence();
            string text1 = "abcde", text2 = "ace";
            Assert.IsTrue(LCS.LongestCommonSubsequence(text1, text2) == 3);
        }
    }
}
