using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeExample
{
    public class Sum3
    {
        //https://leetcode.com/problems/3sum/

        //Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? 
        //    Find all unique triplets in the array which gives the sum of zero.

        //Notice that the solution set must not contain duplicate triplets.

        //        Example 1:

        //Input: nums = [-1,0,1,2,-1,-4]
        //Output: [[-1,-1,2],[-1,0,1]]

        private List<IList<int>> listToSubmit;
        private Dictionary<int, int> notUsedNumbers;

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            listToSubmit = new List<IList<int>>();
            notUsedNumbers = new Dictionary<int, int>();
            Array.Sort(nums);
            FillDictionary(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                notUsedNumbers[nums[i]]--;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int revers = (nums[i] + nums[j]) * -1;
                    if (revers < nums[j])
                    {
                        break;
                    }
                    notUsedNumbers[nums[j]]--;
                    if (notUsedNumbers.ContainsKey(revers) && notUsedNumbers[revers] != 0)
                    {
                        listToSubmit.Add(new List<int>() { nums[i], nums[j], revers });
                    }
                    notUsedNumbers[nums[j]]++;
                }
                notUsedNumbers[nums[i]]++;
            }

            return listToSubmit;
        }

        public void formList(int[] nums, int target, int x, int soFar, List<int> memory)
        {
            int reversSoFar = soFar * (-1);
            if (memory.Count == 2 && notUsedNumbers.ContainsKey(reversSoFar) && notUsedNumbers[reversSoFar] == 0)
            {
                return;
            }
            if (memory.Count == 2 && notUsedNumbers.ContainsKey(reversSoFar) && notUsedNumbers[reversSoFar] != 0)
            {
                memory.Add(reversSoFar);
                if (!listToSubmit.Any(o => o.SequenceEqual(memory)))
                    listToSubmit.Add(memory.ToList());
                return;
            }
            for (int i = x; i < nums.Length; i++)
            {
                memory.Add(nums[i]);
                notUsedNumbers[nums[i]]--;
                formList(nums, target, i + 1, soFar + nums[i], memory);
                notUsedNumbers[nums[i]]++;
                memory.RemoveAt(memory.Count - 1);
            }
        }

        private void FillDictionary(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (notUsedNumbers.ContainsKey(nums[i]))
                {
                    notUsedNumbers[nums[i]]++;
                }
                else
                {
                    notUsedNumbers.Add(nums[i], 1);
                }
            }
        }
    }
}
