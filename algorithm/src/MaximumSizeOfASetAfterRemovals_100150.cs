using System.Collections.Generic;

namespace LeetCode;

public class MaximumSizeOfASetAfterRemovals_100150
{
    static int MaximumSetSize(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>();
        var removeTotalCnt = nums1.Length / 2;
        var map = new Dictionary<int, int>();
        foreach (var num in nums1)
        {
            if (!map.ContainsKey(num))
            {
                map.Add(num, 1);
            }
            else
            {
                map[num]++;
            }
        }
        foreach (var num in nums2)
        {
            if (!map.ContainsKey(num))
            {
                map.Add(num, 1);
            }
            else
            {
                map[num]--;
            } 
        }
        
        

        return set.Count;
    }
    
    
    
    [Theory]
    [InlineData(new int[]{1,2,1,2}, new int[]{1,1,1,1}, 2)]
    [InlineData(new int[]{1,2,3,4,5,6}, new int[]{2,3,2,3,2,3}, 5)]
    [InlineData(new int[]{1,1,2,2,3,3}, new int[]{4,4,5,5,6,6}, 6)]
    private void Test_OK(int[] nums1, int[] nums2, int expectedResult)
    {
        var result = MaximumSetSize(nums1, nums2);
        Assert.Equal(expectedResult, result);
    }
}