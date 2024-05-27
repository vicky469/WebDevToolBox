namespace LeetCode.Array_and_String;

public class MaximumSizeOfASetAfterRemovals_100150
{
    private static int MaximumSetSize(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>();
        var removeTotalCnt = nums1.Length / 2;
        var map = new Dictionary<int, int>();
        foreach (var num in nums1)
            if (!map.ContainsKey(num))
                map.Add(num, 1);
            else
                map[num]++;
        foreach (var num in nums2)
            if (!map.ContainsKey(num))
                map.Add(num, 1);
            else
                map[num]--;


        return set.Count;
    }


    [Theory]
    [InlineData(new[] { 1, 2, 1, 2 }, new[] { 1, 1, 1, 1 }, 2)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 2, 3, 2, 3, 2, 3 }, 5)]
    [InlineData(new[] { 1, 1, 2, 2, 3, 3 }, new[] { 4, 4, 5, 5, 6, 6 }, 6)]
    private void Test_OK(int[] nums1, int[] nums2, int expectedResult)
    {
        var result = MaximumSetSize(nums1, nums2);
        Assert.Equal(expectedResult, result);
    }
}