using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Sliding_Window_Pattern;
// https://leetcode.com/problems/maximum-sum-of-distinct-subarrays-with-length-k/
public class MaximumSumOfDistinctSubarraysWithLengthK__2461
{
    static long MaximumSubarraySum(int[] nums, int k)
    {
        long maxSum = 0;
        long currentSum = 0;
        var dict = new Dictionary<int,int>();
        
        for (int i = 0; i < nums.Length;i++)
        {
            currentSum = AddCurrentNumber(nums, currentSum, i, dict);
            if (i >= k)
            {
                int left = i - k;
                currentSum = DeleteLeftNumber(nums, left, currentSum, dict); 
            }
            
            if (dict.Count() == k)
            {
                maxSum = System.Math.Max(currentSum, maxSum);
            }
        }

        return maxSum;
    }

    private static long DeleteLeftNumber(int[] nums, int left, long currentSum, Dictionary<int, int> dict)
    {
        currentSum -= nums[left];
        if (dict[nums[left]] == 1)
        {
            dict.Remove(nums[left]);
        }
        else
        {
            dict[nums[left]] --;
        }

        return currentSum;
    }

    private static long AddCurrentNumber(int[] nums, long currentSum, int i, Dictionary<int, int> dict)
    {
        currentSum += nums[i];
        // add nums[i] in map
        if (!dict.ContainsKey(nums[i]))
        {
            dict.Add(nums[i], 1);
        }
        else
        {
            dict[nums[i]]++;
        }

        return currentSum;
    }

    [Theory]
    [InlineData( new int[]{1,5,4,2,9,9,9},3, 15)]
    [InlineData( new int[]{1,1,1,7,8,9},3, 24)]
    [InlineData( new int[]{4,4,4},3, 0)]
    [InlineData( new int[]{9,9,9,1,2,3},3, 12)]
    [InlineData( new int[]{1,2,2},2, 3)]
    private void Test_OK(int[] nums, int k, int expectedResult)
    {
        var result = MaximumSubarraySum(nums, k);
        Assert.Equal(expectedResult, result);
    }
}