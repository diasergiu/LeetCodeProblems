using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExample
{
    // https://leetcode.com/problems/longest-common-subsequence/

    // Given two strings text1 and text2, return the length of their longest common subsequence.

    // A subsequence of a string is a new string generated from the original string with some
    //    characters(can be none) deleted without changing the relative order of the remaining
    //    characters. (eg, "ace" is a subsequence of "abcde" while "aec" is not). A common subsequence
    //    of two strings is a subsequence that is common to both strings.



    //If there is no common subsequence, return 0.

    //        Example 1:

    //Input: text1 = "abcde", text2 = "ace" 
    //Output: 3  
    //Explanation: The longest common subsequence is "ace" and its length is 3.

    public class Longest_Common_Subsequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] cache = new int[text1.Length, text2.Length];
            for (int i = 0; i < text1.Length; i++)
            {
                for (int j = 0; j < text2.Length; j++)
                {
                    cache[i, j] = -1;
                }
            }
            return LongestCommonSubsuquance(text1, text2, 0, 0, cache);
        }
        private int LongestCommonSubsuquance(string s1, string s2, int pozS1, int pozS2, int[,] cache)
        {
            if (pozS1 >= s1.Length || pozS2 >= s2.Length)
            {
                return 0;
            }

            if (cache[pozS1, pozS2] != -1)
            {
                return cache[pozS1, pozS2];
            }
            int with = 0;
            if (s1[pozS1] == s2[pozS2])
            {
                with = LongestCommonSubsuquance(s1, s2, pozS1 + 1, pozS2 + 1, cache) + 1;
            }

            int without = Math.Max(LongestCommonSubsuquance(s1, s2, pozS1 + 1, pozS2, cache), LongestCommonSubsuquance(s1, s2, pozS1, pozS2 + 1, cache));
            cache[pozS1, pozS2] = Math.Max(with, without);
            return cache[pozS1, pozS2];
        }
    }
}
